using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BizimMarket.Attributes
{
    public class GecerliImageAttribute : ValidationAttribute
    {
        public int MaxDosyaBoyutuMB { get; set; } = 1;
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }

            var resim = (IFormFile)value;
            if (!resim.ContentType.StartsWith("image/"))
            {
                ErrorMessage = "Geçersiz Resim Dosyası";
                return false;
            }
            else if (resim.Length > MaxDosyaBoyutuMB * 1024 * 1024)
            { 
                ErrorMessage = $"Resim dosyası {MaxDosyaBoyutuMB}MB'dan büyük olamaz.";
                return false;
            }
            return true;
        }
    }
}
