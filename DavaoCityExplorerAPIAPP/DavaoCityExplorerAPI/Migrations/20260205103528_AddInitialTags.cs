using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DavaoCityExplorerAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialTags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "TagName" },
                values: new object[,]
                {
                    { 1, "Wildlife" },
                    { 2, "Conservation" },
                    { 3, "Nature" },
                    { 4, "Mountain Resort" },
                    { 5, "Adventure" },
                    { 6, "Hiking" },
                    { 7, "Public Park" },
                    { 8, "Family" },
                    { 9, "Street Food" },
                    { 12, "Thrifting" },
                    { 13, "Night Market" },
                    { 14, "Souvenirs" },
                    { 15, "Pearls" },
                    { 16, "Handicrafts" },
                    { 17, "Shopping Mall" },
                    { 18, "Convention" },
                    { 19, "Luxury" },
                    { 20, "Live Bands" },
                    { 21, "Food Park" },
                    { 22, "Nightlife" },
                    { 23, "City View" },
                    { 24, "Dining" },
                    { 25, "History" },
                    { 26, "Cocktails" },
                    { 27, "Heritage House" },
                    { 28, "Bar" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 28);
        }
    }
}
