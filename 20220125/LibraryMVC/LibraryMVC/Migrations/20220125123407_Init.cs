using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryMVC.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookPublishYear = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookAuthor", "BookName", "BookPublishYear", "Description" },
                values: new object[,]
                {
                    { 1, "Lev Tolstoy", "Anna Karenina", 1877, "Regarded as Tolstoy's most important novel, Anna Karenina is an absolutely heartbreaking and heartbreaking story. Trapped in her loveless marriage, Anna does the unthinkable and gives up everything she has for the handsome Count Vronsky." },
                    { 2, "Harper Lee", "To Kill a Mockingbird", 1960, "One of the most beloved stories of all time, translated into more than forty languages, laying the groundwork for an Oscar-winning feature film and a Pulitzer Prize-winning film that was chosen as one of the best novels of the twentieth century, To Kill a Mockingbird is a gripping, heart-wrenching and heart-wrenching story set in America's south, poisoned by brutal prejudice. A remarkable growth story. In a world of bewitching beauty and brutal inequalities, the story of a man who risks everything to defend a \"nigger\" who has been wrongly accused of a horrific crime is told through the eyes of a child protagonist." },
                    { 3, "Jen Jacques Rousseau", "Emile", 1762, "Emile, or On Education, or Emile, or the Treatise on Education, is a treatise on the nature of education and the nature of man, written by Jean-Jacques Rousseau. Considered by Rousseau \"the best and most important of all my writings\"." },
                    { 4, "Oğuz Atay", "Bir Bilim Adamının Romanı", 1975, "A Scientist's Novel, Oğuz Atay's professor from ITU Faculty of Civil Engineering. Dr. It is the novel of Mustafa Inan in which he tells his life story." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
