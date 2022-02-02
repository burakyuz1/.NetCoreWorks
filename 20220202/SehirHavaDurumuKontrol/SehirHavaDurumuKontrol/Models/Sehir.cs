using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SehirHavaDurumuKontrol.Models
{
    public class Sehir
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string SehirAd { get; set; }
        public Bolge Bolge { get; set; }
        public int BolgeId { get; set; }
        public int Nufus { get; set; }
    }
}
