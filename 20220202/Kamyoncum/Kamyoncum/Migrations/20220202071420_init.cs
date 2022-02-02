using Microsoft.EntityFrameworkCore.Migrations;

namespace Kamyoncum.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sozler",
                columns: table => new
                {
                    Kod = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icerik = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sozler", x => x.Kod);
                });

            migrationBuilder.InsertData(
                table: "Sozler",
                columns: new[] { "Kod", "Icerik" },
                values: new object[,]
                {
                    { 1, "Ölüme gidelim dedin de mazot mu yok dedik…" },
                    { 2, "İleride güzel günler göreceğiz demişlerdi. Daha ne kadar gideceğiz?" },
                    { 3, "Adımı avucuna yaz. Beni hatırladıkça avucunu yalarsın." },
                    { 4, "Arkadaşın çok olur ama zor gününde yok olur!" },
                    { 5, "Otopsi istiyorum! Hayallerim kendi eceliyle ölmüş olamaz." },
                    { 6, "Mevzu atlı karıncalar değil. Dönen dolaplar!" },
                    { 7, "Gönlünde yer yoksa güzelim, Fark etmez ben ayakta da giderim." },
                    { 8, "Kalp dediğin atıyor zaten. Marifet ritmi değiştirmekte." },
                    { 9, "Her şeyi bilmene gerek yok. Haddini bil yeter." },
                    { 10, "Ahlarla kaybettiğini keşkelerle arayacaksın…!" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sozler");
        }
    }
}
