using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirHavaDurumuKontrol.ViewModels
{
    public class BolgeSehirViewModel
    {
        public int BolgeId{ get; set; }
        public List<SelectListItem> Sehirler { get; set; }
        public List<SelectListItem> Bolgeler { get; set; }
    }
}
