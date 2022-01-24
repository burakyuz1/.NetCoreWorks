using System.ComponentModel.DataAnnotations;

namespace UniversityMVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Display(Name = "Last Name")]
        [Required, MaxLength(50)]
        public string LastName { get; set; }
    }
}
