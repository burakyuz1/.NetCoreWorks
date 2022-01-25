using System.ComponentModel.DataAnnotations;

namespace LibraryMVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please fill \"book name\" area."), Display(Name = "Book Name")]
        public string BookName { get; set; }
        [Required(ErrorMessage = "Please fill \"book author\" area."), Display(Name = "Author Name & Surname")]
        public string BookAuthor { get; set; }

        [Required(ErrorMessage = "Please fill \"publish year\" area."), Range(1700, 2022, ErrorMessage = "Publish year must be range of 1700-2022"), Display(Name = "Publish Year")]
        public int? BookPublishYear { get; set; }
        public string Description { get; set; }

    }
}
