// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SehirBolgeCustomTagHelper.Models.Context;

namespace SehirBolgeCustomTagHelper.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20220201202328_seedDatas")]
    partial class seedDatas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SehirBolgeCustomTagHelper.Models.Bolge", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("BolgeAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bolgeler");
                });

            modelBuilder.Entity("SehirBolgeCustomTagHelper.Models.Sehir", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("BolgeId")
                        .HasColumnType("int");

                    b.Property<int>("Nufus")
                        .HasColumnType("int");

                    b.Property<string>("SehirAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BolgeId");

                    b.ToTable("Sehirler");
                });

            modelBuilder.Entity("SehirBolgeCustomTagHelper.Models.Sehir", b =>
                {
                    b.HasOne("SehirBolgeCustomTagHelper.Models.Bolge", "Bolge")
                        .WithMany()
                        .HasForeignKey("BolgeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bolge");
                });
#pragma warning restore 612, 618
        }
    }
}
