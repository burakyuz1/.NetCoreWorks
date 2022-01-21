using Microsoft.EntityFrameworkCore;

namespace SchoolMVC.Models
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) :
            base(options) //Ayarları taşır.(Hangi Db, Hangi sunucu,)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student() {Id = 1, Name = "Bilge", Surname = "Lorem"},
                new Student() {Id = 2, Name = "Ezgi", Surname= "Ipsum"},
                new Student() {Id = 3, Name = "Koray", Surname = "Amet"},
                new Student() {Id = 4, Name = "Burak", Surname = "Elit"});

        }
    }
}