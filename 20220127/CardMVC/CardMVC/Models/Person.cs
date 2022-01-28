using System;
using System.ComponentModel.DataAnnotations;

namespace CardMVC.Models
{
    public class Person
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string ImageLink { get; set; }
        [Required]
        public string URL { get; set; }

    }
}
