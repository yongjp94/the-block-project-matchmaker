using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheBlockProject.Models;

namespace TheBlockProject.ViewModels
{
    public class ProfileViewModel
    {
        public ApplicationUser User { get; set; }
        public IEnumerable<Answer> Answers { get; set; }
        public IEnumerable<Photo> Photos { get; set; }
        public IEnumerable<Video> Videos { get; set; }
        public string Biography { get; set; }
        public string VideoUrl { get; set; }
        public byte[] ImageData { get; set; }
        public HttpPostedFileBase File { get; set; }
    }
}