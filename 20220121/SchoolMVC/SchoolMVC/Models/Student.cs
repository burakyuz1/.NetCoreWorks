﻿using System.ComponentModel.DataAnnotations;

namespace SchoolMVC.Models
{
    public class Student
    {
        public int Id  { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }

        [Required,MaxLength(50)]
        public string Surname { get; set; }
    }
}