using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheBlockProject.Models
{
    public class Race
    {
        public byte Id { get; set; }
        public string Name { get; set; }
    }

    public class Gender
    {
        public byte Id { get; set; }
        public string Name { get; set; }
    }

    public class Neighborhood
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}