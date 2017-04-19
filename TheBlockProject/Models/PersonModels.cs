using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheBlockProject.Models
{
    public class Person
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Relation { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }

    public class HouseholdMember : Person
    {
        [Required]
        public string UserId { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        [Required]
        public byte GenderId { get; set; }
    }

}