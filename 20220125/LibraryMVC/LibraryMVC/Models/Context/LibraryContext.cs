using Microsoft.EntityFrameworkCore;

namespace LibraryMVC.Models.Context
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book() { Id = 1, BookName = "Anna Karenina", BookAuthor = "Lev Tolstoy", BookPublishYear = 1877, Description = "Regarded as Tolstoy's most important novel, Anna Karenina is an absolutely heartbreaking and heartbreaking story. Trapped in her loveless marriage, Anna does the unthinkable and gives up everything she has for the handsome Count Vronsky." },
                new Book() { Id = 2, BookName = "To Kill a Mockingbird", BookAuthor = "Harper Lee", BookPublishYear = 1960, Description = "One of the most beloved stories of all time, translated into more than forty languages, laying the groundwork for an Oscar-winning feature film and a Pulitzer Prize-winning film that was chosen as one of the best novels of the twentieth century, To Kill a Mockingbird is a gripping, heart-wrenching and heart-wrenching story set in America's south, poisoned by brutal prejudice. A remarkable growth story. In a world of bewitching beauty and brutal inequalities, the story of a man who risks everything to defend a \"nigger\" who has been wrongly accused of a horrific crime is told through the eyes of a child protagonist." },
                new Book() { Id = 3, BookName = "Emile", BookAuthor = "Jen Jacques Rousseau", BookPublishYear = 1762, Description = "Emile, or On Education, or Emile, or the Treatise on Education, is a treatise on the nature of education and the nature of man, written by Jean-Jacques Rousseau. Considered by Rousseau \"the best and most important of all my writings\"." },
                new Book() { Id = 4, BookName = "Bir Bilim Adamının Romanı", BookAuthor = "Oğuz Atay", BookPublishYear = 1975, Description = "A Scientist's Novel, Oğuz Atay's professor from ITU Faculty of Civil Engineering. Dr. It is the novel of Mustafa Inan in which he tells his life story." }
                );
        }
    }
}
