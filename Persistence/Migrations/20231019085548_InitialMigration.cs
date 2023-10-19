using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Isbn_10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Isbn_13 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Description", "Isbn_10", "Isbn_13", "Title" },
                values: new object[,]
                {
                    { new Guid("4d670088-aff7-4e2b-9074-283db0f1ebf7"), "F. Scott Fitzgerald", "The Great Gatsby is a 1925 ", "0743273567", "9780743273565", "The Great Gatsby" },
                    { new Guid("b9d6471b-1d3f-49e2-9618-f3193dbc97f2"), "Charles Dickens", "Book", "1293585899", "2958373967392", "Moby Dick" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
