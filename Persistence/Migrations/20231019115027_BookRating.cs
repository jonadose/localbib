using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class BookRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4d670088-aff7-4e2b-9074-283db0f1ebf7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b9d6471b-1d3f-49e2-9618-f3193dbc97f2"));

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Description", "Isbn_10", "Isbn_13", "Rating", "Title" },
                values: new object[,]
                {
                    { new Guid("61e8c388-4d08-454b-8dcc-ff25c6eec0ad"), "F. Scott Fitzgerald", "The Great Gatsby is a 1925 ", "0743273567", "9780743273565", 5, "The Great Gatsby" },
                    { new Guid("67cf139f-3c77-42c3-aaf7-a87da9b2e085"), "Charles Dickens", "Book", "1293585899", "2958373967392", 4, "Moby Dick" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("61e8c388-4d08-454b-8dcc-ff25c6eec0ad"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("67cf139f-3c77-42c3-aaf7-a87da9b2e085"));

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Books");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Description", "Isbn_10", "Isbn_13", "Title" },
                values: new object[,]
                {
                    { new Guid("4d670088-aff7-4e2b-9074-283db0f1ebf7"), "F. Scott Fitzgerald", "The Great Gatsby is a 1925 ", "0743273567", "9780743273565", "The Great Gatsby" },
                    { new Guid("b9d6471b-1d3f-49e2-9618-f3193dbc97f2"), "Charles Dickens", "Book", "1293585899", "2958373967392", "Moby Dick" }
                });
        }
    }
}
