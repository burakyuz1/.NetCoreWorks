using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TurkiyeBilgi.Models
{
    public class Bolge
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string BolgeAd { get; set; }
        public ICollection<Sehir> Sehirler { get; set; }
    }
}
