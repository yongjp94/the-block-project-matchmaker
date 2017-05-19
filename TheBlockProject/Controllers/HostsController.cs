using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using TheBlockProject.Models;
using TheBlockProject.ViewModels;

namespace TheBlockProject.Controllers
{
    public class HostsController : Controller
    {
        private ApplicationDbContext _context;

        public HostsController()
        {
            _context = new ApplicationDbContext();
            
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Hosts
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var user = _context.Users.Single(u => u.Id == userId);

            if (user.UserTypeId == UserType.HOST)
            {
                // Host is not permitted to view this page
                return RedirectToAction("Index", "Profile");
            }

            // If user is resident but have not completed survey, redirect to survey
            if (user.UserTypeId == UserType.RESIDENT && !user.SurveyComplete) return RedirectToAction("Index", "Survey");
            
            var hosts = _context.Users.Include(u => u.UserType)
                .Include(u => u.Neighborhood)
                .Where(u => u.SurveyComplete && u.UserTypeId == UserType.HOST).ToList();

            var percentages = hosts.ToDictionary(host => host.Id, host => GetMatchPercentage(user.Id, host.Id));

            var viewModel = new HostListViewModel()
            {
                Hosts = hosts,
                HostsPercentage = percentages,
                User = user
            };

            return View(viewModel);
            
        }

        // GET: Hosts/Details/:id
        public ActionResult Details(string id)
        {
            var host = _context.Users.Include(u => u.Gender)
                .Include(u => u.Neighborhood)
                .Include(u => u.Race)
                .Include(u => u.UserType)
                .Single(u => u.Id == id);
            var hostAnswers = _context.UserAnswers.Where(ua => ua.ApplicationUserId == id).ToList();

            var query = from userAnswer in hostAnswers
                join answerItem in _context.Answers.Include(a => a.Question).ToList()
                on userAnswer.AnswerId equals answerItem.Id
                select answerItem;

            var answers = query.ToList();
            var photos = _context.Photos.Where(p => p.UserId == id);
            var videos = _context.Videos.Where(v => v.UserId == id);

            var viewModel = new ProfileViewModel()
            {
                User = host,
                Answers = answers,
                Photos = photos,
                Videos = videos
            };

            return View(viewModel);
        }

        // Send resident's request to see host
        public ActionResult SendRequest(string senderId, string receiverId)
        {
            // If request already exists, redirect
            if (_context.Requests
                .Any(r =>
                    r.SenderId == senderId &&
                    r.ReceiverId == receiverId)) return Redirect("Index");
            
            
            var req = new Request()
            {
                SenderId = senderId,
                ReceiverId = receiverId,
                CreatedDate = DateTime.Today,
                Status = RequestStatus.PENDING
            };

            try
            {
                _context.Requests.Add(req);
                _context.SaveChanges();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            return RedirectToAction("Index", "Home");
        }
        





        private int GetMatchPercentage(string residentId, string hostId)
        {
            var ret = 0;
            var residentAnswers = _context.UserAnswers.Where(ua => ua.ApplicationUserId == residentId);
            
            // If resident hasn't completed survey return 0
            if (!residentAnswers.Any()) return ret;
            
            // If resident has completed survey, compare with host's answers
            var hostAnswers = _context.UserAnswers.Where(ua => ua.ApplicationUserId == hostId);

            var query = from residentItem in residentAnswers
                join hostItem in hostAnswers
                on residentItem.AnswerId equals hostItem.AnswerId
                select residentItem;
            var commonAnswersNum = query.Count();

            int totalCommonQuestionsNum = _context.Questions.Count(q => q.SurveyId == 3);
            double perc = 100.0 * commonAnswersNum / totalCommonQuestionsNum;
            ret = Convert.ToInt32(perc);
            

            return ret;
        }
    }
}