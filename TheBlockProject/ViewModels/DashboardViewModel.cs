using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheBlockProject.Models;

namespace TheBlockProject.ViewModels
{
    public class DashboardViewModel
    {
        public ApplicationUser User { get; set; }
        public IEnumerable<Request> Requests { get; set; }
    }
}