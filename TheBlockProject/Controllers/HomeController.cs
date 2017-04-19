using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBlockProject.Models;
using TheBlockProject.ViewModels;

namespace TheBlockProject.Controllers
{
    [AllowAnonymous]
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

        public ViewResult Index()
        {
            // If user is logged-in, return dashboard view
            if (!User.Identity.IsAuthenticated) return View();

            var viewModel = new DashboardViewModel();
            return View("Dashboard");
            // else return welcome view for all users
        }
    }
}