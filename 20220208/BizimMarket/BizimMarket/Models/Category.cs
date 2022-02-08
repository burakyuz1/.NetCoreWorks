using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BizimMarket.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}