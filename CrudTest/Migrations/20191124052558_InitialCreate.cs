using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudTest.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    RealName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "RealName" },
                values: new object[,]
                {
                    { 1, "john@beatles.com", "jlennon", "John Lennon" },
                    { 2, "paul@beatles.com", "paulm", "Paul McCartney" },
                    { 3, "george@beatles.com", "gharrison", "George Harrison" },
                    { 4, "ringo@beatles.com", "rstarr", "Richard Starkey" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
