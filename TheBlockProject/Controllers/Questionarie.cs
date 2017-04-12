﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheBlockProject.Controllers
{
    public class Questionarie
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string QuestionType { get; set; }
        public string SurveyType { get; set; }
        public bool IsRequired { get; set; }

    }
}