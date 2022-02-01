using System.ComponentModel.DataAnnotations.Schema;

namespace SehirBolgeCustomTagHelper.Models
{
    public class Bolge
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string BolgeAd { get; set; }
    }
}
