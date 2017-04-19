using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using TheBlockProject.Models;

namespace TheBlockProject.Controllers
{
    public class SurveyController : Controller
    {
        private ApplicationDbContext _context;

        public SurveyController()
        {
            _context = new ApplicationDbContext();
            
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Survey/:id
        public ActionResult Index()
        {
            var userName = User.Identity.GetUserName();
            var user = _context.Users.Single(u => u.UserName == userName);
            

            var userTypeId = user.UserTypeId;

            var questions = _context.Questions.Where(q => q.SurveyId == userTypeId || q.SurveyId == 3).ToList();

            var answers = _context.Answers.Include(a => a.Question);
            var query = from questionItem in questions
                join answerItem in answers
                on questionItem.Id equals answerItem.QuestionId
                select answerItem;

            var surveyViewModel = new SurveyViewModel()
            {
                User = user,
                Questions = questions,
                Answers = query.ToList(),
                UserAnswerIds = new int[questions.Count]

            };
            
            return View(surveyViewModel);
        }


        // Submits the user's survey answers
        public ActionResult Submit(SurveyViewModel viewModel)
        {
            var userAnswerIds = viewModel.UserAnswerIds;
            var userId = User.Identity.GetUserId();
            var surveyComplete = true;

            // Add each answer to UserAnswer
            for (var i = 0; i < userAnswerIds.Length; i++)
            {
                var currentAnswerBlock = userAnswerIds[i];
                if (_context.Answers.Any(a => a.Id == currentAnswerBlock))
                {
                    UserAnswer ua = new UserAnswer()
                    {
                        ApplicationUserId = userId,
                        AnswerId = userAnswerIds[i]
                    };
                    try
                    {
                        _context.UserAnswers.Add(ua);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }

                }
                else
                {
                    surveyComplete = false;
                }
            }

            // Update user's survey completion status
            try
            {
                _context.Users.Single(u => u.Id == userId).SurveyComplete = surveyComplete;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Profile");
        }
    }
}