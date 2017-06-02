using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.WebPages;
using Microsoft.Ajax.Utilities;

namespace TheBlockProject.Models
{
    /*public class SurveyManager
    {
        
    }*/

    public class Survey
    {
        [Required]
        public byte Id { get; set; }
        [Required]
        public string Name { get; set; }
    }

    public class UserAnswer
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        [Required]
        public int AnswerId { get; set; }
        public Answer Answer { get; set; }

    }


    public class Question
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        public string Text2 { get; set; }
        public string Comment { get; set; }
        [Required]
        public byte SurveyId { get; set; }
        [Required]
        public byte QuestionTypeId { get; set; }
        public QuestionType QuestionType { get; set; }
    }

    public class QuestionType
    {
        [Required]
        public byte Id { get; set; }
        [Required]
        public string Name { get; set; }
    }

    public class Answer
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}