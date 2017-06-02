using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheBlockProject.Models;

namespace TheBlockProject.ViewModels
{
    public class HostListViewModel
    {
        public Dictionary<string, int> HostsPercentage;
        public IEnumerable<ApplicationUser> Hosts;
        public ApplicationUser User;
        public IEnumerable<Photo> Photos { get; set; }
    }
}