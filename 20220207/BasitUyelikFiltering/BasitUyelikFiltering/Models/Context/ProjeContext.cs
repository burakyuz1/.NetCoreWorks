using Microsoft.EntityFrameworkCore;

namespace BasitUyelikFiltering.Models.Context
{
    public class ProjeContext : DbContext
    {
        public ProjeContext(DbContextOptions<ProjeContext> option) : base(option)
        {

        }


        public DbSet<Kullanici> Kullanicilar { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kullanici>().HasData(

               new Kullanici() { Id = 1, Email = "mail", Password = "123" },
               new Kullanici() { Id = 2, Email = "gmail", Password = "123" }
            );
        }
    }
}
