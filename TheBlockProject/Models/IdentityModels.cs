using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TheBlockProject.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public byte GenderId { get; set; }
        public Gender Gender { get; set; }

        [Required]
        public int Age { get; set; }
        
        [Required]
        [Display(Name = "Phone Number")]
        public override string PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Neighborhood")]
        public int NeighborhoodId { get; set; }
        public Neighborhood Neighborhood { get; set; }

        [Required]
        [Display(Name = "Race")]
        public byte RaceId { get; set; }
        public Race Race { get; set; }

        [Required]
        [Display(Name = "Is Married")]
        public bool IsMarried { get; set; }

        [Required]
        [Display(Name = "Primary Language")]
        public string PrimaryLanguage { get; set; }

        [Required]
        [Display(Name = "Other Language")]
        public string OtherLanguage { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Race> Races { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Neighborhood> Neighborhoods { get; set; }


        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}