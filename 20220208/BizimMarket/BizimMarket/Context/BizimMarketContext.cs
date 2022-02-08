using BizimMarket.Models;
using Microsoft.EntityFrameworkCore;

namespace BizimMarket.Context
{
    public class BizimMarketContext : DbContext
    {
        public BizimMarketContext(DbContextOptions<BizimMarketContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, CategoryName = "Atıştırmalık" },
                new Category() { Id = 2, CategoryName = "Dondurma" },
                new Category() { Id = 3, CategoryName = "Fırın" }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, ProductName = "Kinder Joy 20g", ProductPrice = 7.90m, ProductImage = "kinderjoy.jpg", CategoryId = 1 },
                new Product() { Id = 2, ProductName = "Toblerone Sütlü Çikolata 100g", ProductPrice = 18.90m, ProductImage = "toblerone.jpg", CategoryId = 1 },
                new Product() { Id = 3, ProductName = "Tadelle Fındık Dolgulu Sütlü Çikolata 30g", ProductPrice = 4.95m, ProductImage = "tadelle.jpg", CategoryId = 1 },
                new Product() { Id = 4, ProductName = "Algida Maraş Usulü Sade Çikolata Dondurma 500ml", ProductPrice = 28.50m, ProductImage = "algidamaras.jpg", CategoryId = 2 },
                new Product() { Id = 5, ProductName = "Carte d'Or Selection Meyve Şöleni 850ml", ProductPrice = 36.90m, ProductImage = "cartedormeyve.jpg", CategoryId = 2 },
                new Product() { Id = 6, ProductName = "Minik Sandviç 10'lu", ProductPrice = 17.90m, ProductImage = "miniksandvic.jpg", CategoryId = 3 }
            );
        }
    }
}