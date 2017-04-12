using System.Collections.Generic;

namespace TheBlockProject.Controllers
{

    public class Profile
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public string PhoneNum { get; set; }
        public string Address { get; set; }
        public string Neighborhood { get; set; }
        public string Race { get; set; }
        public bool IsMarried { get; set; }
        public string PrimaryLanguage { get; set; }
        public string OtherLanguage { get; set; }
        public List<Questionarie> Questionarie { get; set; }

        public Profile()
        {
        }
    }
}