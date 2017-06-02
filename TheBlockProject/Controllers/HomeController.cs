using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using TheBlockProject.Models;
using TheBlockProject.ViewModels;
using System.Data.Entity;

namespace TheBlockProject.Controllers
{
    
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            // If user is not logged in, show welcome view
            if (!User.Identity.IsAuthenticated) return View();


            // Else show dashboard
            return RedirectToAction("DashBoard", "Home");
        }

        public ViewResult DashBoard()
        {
            var userId = this.User.Identity.GetUserId();
            var requests = _context.Requests
                .Include(req => req.Sender)
                .Include(req => req.Receiver)
                .Where(req => req.ReceiverId == userId || req.SenderId == userId);

            var viewModel = new DashboardViewModel()
            {
                User = _context.Users.Include(u => u.UserType).SingleOrDefault(u => u.Id == userId),
                Requests = requests
            };

            return View(viewModel);
        }

        public ActionResult UpdateRequest(int requestId, string newStatus)
        {
            try
            {
                _context.Requests.Single(r => r.Id == requestId).Status = newStatus;
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            var userId = User.Identity.GetUserId();
            var viewModel = new DashboardViewModel()
            {
                User = _context.Users.Include(u => u.UserType).SingleOrDefault(u => u.Id == userId),
                Requests = _context.Requests
                        .Include(req => req.Sender)
                        .Include(req => req.Receiver)
                        .Where(req => req.ReceiverId == userId || req.SenderId == userId)
            };
            

            return View("Dashboard", viewModel);
        }
    }
}