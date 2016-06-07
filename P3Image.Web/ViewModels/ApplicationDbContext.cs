using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace P3Image.Web.ViewModels
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", false)
        {
        }

        public DbSet<CategoryViewModel> CategoryViewModels { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}