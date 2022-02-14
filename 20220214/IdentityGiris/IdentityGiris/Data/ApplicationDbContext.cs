using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityGiris.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> //user tablosunu customize etmek için.
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
