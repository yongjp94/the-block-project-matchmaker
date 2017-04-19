using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;
using TheBlockProject.Models;
using TheBlockProject.ViewModels;

namespace TheBlockProject.Controllers
{
   
    public class ProfileController : Controller
    {
        private ApplicationDbContext _context;

        public ProfileController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Profile
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var user = _context.Users.Include(u => u.Gender)
                .Include(u => u.Neighborhood)
                .Include(u => u.Race)
                .Single(u => u.Id == userId);

            var userAnswers = _context.UserAnswers.Where(ua => ua.ApplicationUserId == userId).ToList();
            var allAnswers = _context.Answers.Include(a => a.Question).ToList();

            var query = from answerItem in allAnswers
                join userAnswer in userAnswers
                on answerItem.Id equals userAnswer.AnswerId
                select answerItem;

            var viewModel = new ProfileViewModel()
            {
                User = user,
                Answers = query.ToList()

            };

            // Load images and videos only for hosts
            if (user.UserTypeId == UserType.HOST)
            {
                // query and insert photos & videos for user

                var photos = _context.Photos.Where(p => p.UserId == userId).ToList();
                var videos = _context.Videos.Where(p => p.UserId == userId).ToList();

                viewModel.Photos = photos;
                viewModel.Videos = videos;
            }

            return View(viewModel);
        }
    }
}