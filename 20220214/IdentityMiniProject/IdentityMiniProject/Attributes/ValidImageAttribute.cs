using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityMiniProject.Attributes
{
    public class ValidImageAttribute : ValidationAttribute
    {
        private static readonly int defaultSize = 102400;
        public int ImageSize { get; set; } = defaultSize;
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }

            IFormFile image = (IFormFile)value;

            if (!image.ContentType.StartsWith("image/"))
            {
                ErrorMessage = "Please choose an image.";
                return false;
            }
            if (image.Length > ImageSize * 2 * 102400)
            {
                ErrorMessage = $"Maximum size should be {ImageSize}MB";
                return false;
            }
            return true;
        }
    }
}
