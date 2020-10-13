using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieProject.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Rate = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Name", "Rate" },
                values: new object[,]
                {
                    { 1, "Capen Philips", 6 },
                    { 2, "Cast Away", 5 },
                    { 3, " Dolemite is My Name", 5 },
                    { 4, "It Chapter Two", 8 },
                    { 5, "Invisible Life", 7 },
                    { 6, " I Lost My Body", 8 },
                    { 7, " American Factory", 6 },
                    { 8, " Plus One", 3 },
                    { 9, "Crawl", 7 },
                    { 10, "Space fighter", 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
