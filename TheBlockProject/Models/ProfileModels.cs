using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheBlockProject.Models
{
    public class Race
    {
        [Required]
        public byte Id { get; set; }
        [Required]
        public string Name { get; set; }
    }

    public class Gender
    {
        [Required]
        public byte Id { get; set; }
        [Required]
        public string Name { get; set; }
    }

    public class Neighborhood
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }

    public class Photo
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string Url { get; set; }
        public DateTime DateAdded { get; set; }
    }

    public class Video
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string Url { get; set; }
        public DateTime DateAdded { get; set; }
    }
}