using System.Collections.Generic;

namespace TheBlockProject.Controllers
{

    public class ProfileBuilder
    {
        public static KeyValuePair<string, int> GENDER_MALE = new KeyValuePair<string, int>("Male", 1);
        public static KeyValuePair<string, int> GENDER_FEMALE = new KeyValuePair<string, int>("Female", 2);
        public static KeyValuePair<string, int> GENDER_GAY = new KeyValuePair<string, int>("Gay", 3);
        public static KeyValuePair<string, int> GENDER_LES = new KeyValuePair<string, int>("Lesbian", 4);

        public static int RACE_KOREAN = 1;
        public const int RACE_WHITE = 2;
        public const int RACE_AFRICAN_AMERICAN = 3;
        public const int RACE_MEXICAN = 4;
        public const int RACE_CHINESE = 5;
        public const int RACE_JAPAN = 6;

        public const int LAN_KOREAN = 1;
        public const int LAN_ENGLISH = 2;
        public const int LAN_SPANISH = 3;
        public const int LAN_CHINESE = 4;
        public const int LAN_JAPANESE= 5;

        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Gender { get; set; }
        public int Age { get; set; }
        public string PhoneNum { get; set; }
        public string Address { get; set; }
        public string Neighborhood { get; set; }
        public string Race { get; set; }
        public bool IsMarried { get; set; }
        public string PrimaryLanguage { get; set; }
        public string OtherLanguage { get; set; }
//        public List<Questionarie> Questionarie { get; set; }

        public ProfileBuilder()
        {
        }
        
    }
}