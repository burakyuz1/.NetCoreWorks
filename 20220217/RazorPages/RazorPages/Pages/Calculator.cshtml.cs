using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages
{
    public class CalculatorModel : PageModel
    {
        [Required]
        [BindProperty]
        public double? Number1 { get; set; }
        [Required]
        [BindProperty]
        public double? Number2 { get; set; }
        public double? Result { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                Result = Math.Pow(Number1.Value, Number2.Value);
            }
        }
    }
}
