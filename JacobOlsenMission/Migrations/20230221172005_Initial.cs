using Microsoft.EntityFrameworkCore.Migrations;

namespace JacobOlsenMission.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<short>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieID);
                    table.ForeignKey(
                        name: "FK_Responses_Categorys_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categorys",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Action/Adventure" });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "Drama" });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 4, "Fantasy" });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 5, "Horror" });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 6, "Mystery" });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 7, "Romance" });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 8, "Thriller" });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 9, "Crime" });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 10, "Musical" });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 11, "Family" });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 12, "Science Fiction" });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 13, "Other" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "CategoryId", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, 1, "David Soren", false, "No one", "Greatest Movie.", "PG", "Turbo", (short)2013 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "CategoryId", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, 2, "Joel Crawford", false, "No one", "Excellent Movie.", "PG", "Puss In Boots: The Last Wish", (short)2022 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "CategoryId", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, 3, "David Soren", false, "No one", "Inspirational.", "PG13", "Miracle On Ice", (short)1981 });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_CategoryId",
                table: "Responses",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Categorys");
        }
    }
}
