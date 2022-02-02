using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SehirHavaDurumuKontrol.Models
{
    public class Bolge
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string BolgeAd { get; set; }
        public ICollection<Sehir> Sehirler { get; set; }
    }
}