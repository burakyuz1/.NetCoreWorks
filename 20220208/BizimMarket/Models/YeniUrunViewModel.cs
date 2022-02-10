﻿using BizimMarket.Attributes;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BizimMarket.Models
{
    public class YeniUrunViewModel
    {
        [Required(ErrorMessage = "Ad alanı zorunlu")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Fiyat alanı zorunlu")]
        public decimal? Fiyat { get; set; }

        [Required(ErrorMessage = "Kategori alanı zorunlu")]
        public int? KategoriId { get; set; }
        [GecerliImage(MaxDosyaBoyutuMB = 2)] //Custom image
        public IFormFile Resim { get; set; }
    }
}
