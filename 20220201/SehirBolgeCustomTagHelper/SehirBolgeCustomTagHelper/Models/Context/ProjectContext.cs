using Microsoft.EntityFrameworkCore;

namespace SehirBolgeCustomTagHelper.Models.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> option) : base(option)
        {

        }

        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Bolge> Bolgeler { get; set; }

    }
}
