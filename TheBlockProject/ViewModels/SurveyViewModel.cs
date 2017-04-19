using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheBlockProject.Models
{
    public class SurveyViewModel
    {
        public IEnumerable<Question> Questions { get; set; }
        public IEnumerable<Answer> Answers { get; set; }
        public ApplicationUser User { get; set; }
        public int[] UserAnswerIds { get; set; }
    }
}