using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheBlockProject.Models
{
    public class RequestStatus
    {
        public const string PENDING = "Pending";
        public const string DECLINED = "Declined";
        public const string ACCEPTED = "Accepted";
    }

    public class Request
    {        

        [Required]
        public int Id { get; set; }

        [Required]
        public string SenderId { get; set; }
        public ApplicationUser Sender { get; set; }

        public string ReceiverId { get; set; }
        public ApplicationUser Receiver { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
    }
}