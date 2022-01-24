using Microsoft.EntityFrameworkCore;

namespace UniversityMVC.Models
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student() { Id = 1, Name = "Alex", LastName = "Parker" },
                new Student() { Id = 2, Name = "Mary", LastName = "Black" },
                new Student() { Id = 3, Name = "Chris", LastName = "White" },
                new Student() { Id = 4, Name = "Brown", LastName = "Jhonson" }
                );
        }
    }
}
