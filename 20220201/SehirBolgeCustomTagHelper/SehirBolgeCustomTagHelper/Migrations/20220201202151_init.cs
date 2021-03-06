using Microsoft.EntityFrameworkCore.Migrations;

namespace SehirBolgeCustomTagHelper.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bolgeler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    BolgeAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolgeler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sehirler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    SehirAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BolgeId = table.Column<int>(type: "int", nullable: false),
                    Nufus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sehirler_Bolgeler_BolgeId",
                        column: x => x.BolgeId,
                        principalTable: "Bolgeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sehirler_BolgeId",
                table: "Sehirler",
                column: "BolgeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sehirler");

            migrationBuilder.DropTable(
                name: "Bolgeler");
        }
    }
}
