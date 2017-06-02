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

             
            var userId = User.Identity.GetUserId();
            var user = _context.Users.Single(u => u.Id == userId);
            if (user.SurveyComplete) RedirectToAction("Index", "Profile");
            

            var userTypeId = user.UserTypeId;

            var questions = _context.Questions.Where(q => (q.SurveyId == userTypeId || q.SurveyId == 3) && q.QuestionTypeId < 3).ToList();

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
        [HttpPost]
        public ActionResult Submit(SurveyViewModel viewModel)
        {
            var userAnswerIds = viewModel.UserAnswerIds;
            var userId = User.Identity.GetUserId();

            var surveyComplete = true;

            foreach (var t in userAnswerIds)
            {
                var currentAnswerBlock = t;
                if (_context.Answers.Any(a => a.Id == currentAnswerBlock))
                {
                    var ua = new UserAnswer()
                    {
                        ApplicationUserId = userId,
                        AnswerId = t
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



            return RedirectToAction("More", "Survey");
        }

        public ActionResult More()
        {
            var userId = User.Identity.GetUserId();
            var user = _context.Users.Single(u => u.Id == userId);
            var userTypeId = user.UserTypeId;
            var questions = _context.Questions.Where(q => (q.SurveyId == userTypeId || q.SurveyId == 3) && q.QuestionTypeId == 3).ToList();

            // add new user answers only if user has not completed all questions
            var questionsCount =
                _context.Questions.Where(q => q.SurveyId == userTypeId || q.SurveyId == 3).ToList().Count;
            var userAnswersCount =
                _context.UserAnswers.Where(ua => ua.ApplicationUserId == userId).ToList().Count;

            if (userAnswersCount < questionsCount)
            {
                foreach (var question in questions)
                {
                    try
                    {
                        _context.Answers.Add(new Answer()
                        {
                            QuestionId = question.Id,
                            Text = "Please, write \"N/A\" if the question is not applicable to you."

                        });
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                    }
                }

                try
                {
                    _context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                RedirectToAction("Index", "Profile");
            }



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
                UserAnswerTexts = new string[questions.Count]
            };




            return View(surveyViewModel);
        }

        public ActionResult SubmitMore(SurveyViewModel viewModel)
        {
            var userAnswerTexts = viewModel.UserAnswerTexts;
            var userId = User.Identity.GetUserId();

            var user = _context.Users.Single(u => u.Id == userId);

            var userTypeId = user.UserTypeId;

            var questions = _context.Questions.Where(q => (q.SurveyId == userTypeId || q.SurveyId == 3) && q.QuestionTypeId == 3).ToList();

            var answers = _context.Answers.Include(a => a.Question);

            var query = from questionItem in questions
                        join answerItem in answers
                        on questionItem.Id equals answerItem.QuestionId
                        select answerItem;

            var answerRefs = query.ToList();

            for (var i = 0; i < userAnswerTexts.Length; i++)
            {
                var currentAnswer = answerRefs[i];
                currentAnswer.Text = userAnswerTexts[i];
                try
                {
                    
                    _context.UserAnswers.Add(new UserAnswer()
                    {
                        AnswerId = currentAnswer.Id,
                        ApplicationUserId = userId
                    });
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Profile");
        }


        /*
         *         public ViewResult Edit()
        {
            var userId = User.Identity.GetUserId();
            var user = _context.Users.Single(u => u.Id == userId);
            var userAnswers = _context.UserAnswers.Include(ua => ua.Answer).Where(ua => ua.ApplicationUserId == userId);
            var answers = new List<Answer>();
            var questions = new List<Question>();
            var userAnswerIds = new List<int>();

            foreach (var ua in userAnswers)
            {
                answers.Add(ua.Answer);
            }

            foreach (var a in answers)
            {
                questions.Add(_context.Questions.Single(q => q.Id == a.QuestionId));
                userAnswerIds.Add(a.Id);
            }

            questions = questions.Where(q => q.QuestionTypeId < 3).ToList();


            var surveyViewModel = new SurveyViewModel()
            {
                User = user,
                Questions = questions,
                Answers = answers,
                UserAnswerIds = userAnswerIds.ToArray()
            };

            return View("Index", surveyViewModel);
        }
         */

    }
}