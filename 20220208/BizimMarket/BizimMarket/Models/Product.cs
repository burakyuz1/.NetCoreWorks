using System.ComponentModel.DataAnnotations;

namespace BizimMarket.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductImage { get; set; }
        [Required]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}