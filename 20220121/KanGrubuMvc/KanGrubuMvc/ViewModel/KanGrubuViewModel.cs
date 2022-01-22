using KanGrubuMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KanGrubuMvc.ViewModel
{
    public class KanGrubuViewModel
    {
        public List<Verici> Vericiler{ get; set; }
        public List<Alici> Alicilar{ get; set; }
    }
}
