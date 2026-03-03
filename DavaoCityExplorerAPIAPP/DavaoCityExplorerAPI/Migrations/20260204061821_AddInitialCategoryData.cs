using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DavaoCityExplorerAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialCategoryData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageID", "ImageURL", "Name" },
                values: new object[,]
                {
                    { 1, "/images/masonry-attractions.webp", "Davao City Hall" },
                    { 2, "/images/masonry-shopping.webp", "Davao Downtown Area" },
                    { 3, "/images/masonry-entertainment.webp", "Davao Clubs" },
                    { 4, "/images/masonry-accommodations.webp", "Marco Polo Building" },
                    { 5, "/images/masonry-foodscene.webp", "Roxas Night Market" },
                    { 6, "/images/masonry-art&museum.webp", "Davao Museum" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 6);
        }
    }
}
