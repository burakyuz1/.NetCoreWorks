using Microsoft.EntityFrameworkCore;

namespace TurkiyeBilgi.Models.Context
{
    public class TurkiyeContext : DbContext
    {
        public TurkiyeContext(DbContextOptions<TurkiyeContext> option) : base(option)
        {
        }


        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Bolge> Bolgeler { get; set; }

    }
}
