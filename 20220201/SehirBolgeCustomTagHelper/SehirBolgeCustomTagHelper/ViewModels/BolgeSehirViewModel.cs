using Microsoft.AspNetCore.Mvc.Rendering;
using SehirBolgeCustomTagHelper.Models;
using System.Collections.Generic;

namespace SehirBolgeCustomTagHelper.ViewModels
{
    public class BolgeSehirViewModel
    {
        public int? BolgeId { get; set; }
        public List<SelectListItem> Bolgeler { get; set; }
        public List<Sehir> Sehirler { get; set; }
    }
}
