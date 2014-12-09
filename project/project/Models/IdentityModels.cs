using Microsoft.AspNet.Identity.EntityFramework;

namespace project.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string MiddleName { get; set; }
        public string Forename { get; set; }
        public string email { get; set; }
        public string PasswordCashe { get; set; }
        public int Thanks { get; set; }
        public bool IsApproved { get; set; }  
    }

    public class ApplicationRoles:IdentityRole
    {
        public int UnternalDownload { get; set; }
        public int InternalDownload { get; set; }
        public bool IsSolveDownload { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}