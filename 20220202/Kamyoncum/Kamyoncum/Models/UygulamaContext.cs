using Microsoft.EntityFrameworkCore;

namespace Kamyoncum.Models
{
    public class UygulamaContext : DbContext
    {
        public UygulamaContext(DbContextOptions<UygulamaContext> options) : base(options)
        {

        }
        public DbSet<Soz> Sozler { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Soz>().
                HasData(
                    new Soz() { Kod = 1, Icerik = "Ölüme gidelim dedin de mazot mu yok dedik…" },
                    new Soz() { Kod = 2, Icerik = "İleride güzel günler göreceğiz demişlerdi. Daha ne kadar gideceğiz?" },
                    new Soz() { Kod = 3, Icerik = "Adımı avucuna yaz. Beni hatırladıkça avucunu yalarsın." },
                    new Soz() { Kod = 4, Icerik = "Arkadaşın çok olur ama zor gününde yok olur!" },
                    new Soz() { Kod = 5, Icerik = "Otopsi istiyorum! Hayallerim kendi eceliyle ölmüş olamaz." },
                    new Soz() { Kod = 6, Icerik = "Mevzu atlı karıncalar değil. Dönen dolaplar!" },
                    new Soz() { Kod = 7, Icerik = "Gönlünde yer yoksa güzelim, Fark etmez ben ayakta da giderim." },
                    new Soz() { Kod = 8, Icerik = "Kalp dediğin atıyor zaten. Marifet ritmi değiştirmekte." },
                    new Soz() { Kod = 9, Icerik = "Her şeyi bilmene gerek yok. Haddini bil yeter." },
                    new Soz() { Kod = 10, Icerik = "Ahlarla kaybettiğini keşkelerle arayacaksın…!" }
                );


            modelBuilder.Entity<Soz>().HasKey(x => x.Kod);

            modelBuilder.Entity<Soz>().Property(x => x.Kod).UseIdentityColumn();

            modelBuilder.Entity<Soz>().Property(x => x.Icerik).IsRequired().HasMaxLength(5000);


        }
    }
}
