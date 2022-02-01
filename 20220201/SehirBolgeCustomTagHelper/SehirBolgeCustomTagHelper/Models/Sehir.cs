using System.ComponentModel.DataAnnotations.Schema;

namespace SehirBolgeCustomTagHelper.Models
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
