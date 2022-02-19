using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityMiniProject.Data.Migrations
{
    public partial class columnNameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Soyad",
                table: "AspNetUsers",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "Ad",
                table: "AspNetUsers",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "AspNetUsers",
                newName: "Soyad");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AspNetUsers",
                newName: "Ad");
        }
    }
}
