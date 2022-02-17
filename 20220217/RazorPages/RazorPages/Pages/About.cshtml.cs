using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages
{
    public class AboutModel : PageModel
    {
        public AboutInfo Info { get; set; }
        public void OnGet()
        {
            Info = new AboutInfo
            {
                Name = "Burak",
                Surname = "Akyuz",
                Age = 27,
                FavouriteColor = "Gray"
            };
        }

        public class AboutInfo
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }
            public string FavouriteColor { get; set; }
        }
    }
}
