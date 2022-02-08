using BizimMarket.Models;
using System.Collections.Generic;

namespace BizimMarket.ViewModels
{
    public class HomeViewModel
    {
        public int? SelectedCategoryId { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}
