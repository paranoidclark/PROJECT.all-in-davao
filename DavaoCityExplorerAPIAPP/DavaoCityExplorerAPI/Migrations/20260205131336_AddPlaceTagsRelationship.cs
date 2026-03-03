using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DavaoCityExplorerAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddPlaceTagsRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlaceTags",
                columns: new[] { "PlaceID", "TagID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 25 },
                    { 4, 9 },
                    { 4, 12 },
                    { 4, 13 },
                    { 5, 14 },
                    { 5, 15 },
                    { 5, 16 },
                    { 6, 17 },
                    { 6, 18 },
                    { 6, 19 },
                    { 7, 20 },
                    { 7, 21 },
                    { 7, 22 },
                    { 8, 23 },
                    { 8, 24 },
                    { 8, 25 },
                    { 9, 26 },
                    { 9, 27 },
                    { 9, 28 },
                    { 10, 8 },
                    { 10, 19 },
                    { 11, 19 },
                    { 11, 23 },
                    { 11, 24 },
                    { 12, 2 },
                    { 12, 3 },
                    { 12, 16 },
                    { 13, 24 },
                    { 13, 28 },
                    { 14, 24 },
                    { 15, 24 },
                    { 16, 2 },
                    { 16, 3 },
                    { 16, 25 },
                    { 17, 2 },
                    { 17, 3 },
                    { 17, 25 },
                    { 18, 2 },
                    { 18, 16 },
                    { 18, 25 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 3, 25 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 5, 15 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 6, 17 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 6, 18 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 6, 19 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 7, 20 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 7, 21 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 7, 22 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 8, 23 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 8, 24 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 8, 25 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 9, 26 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 9, 27 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 9, 28 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 10, 19 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 11, 19 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 11, 23 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 11, 24 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 12, 16 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 13, 24 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 13, 28 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 14, 24 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 15, 24 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 16, 25 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 17, 3 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 17, 25 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 18, 16 });

            migrationBuilder.DeleteData(
                table: "PlaceTags",
                keyColumns: new[] { "PlaceID", "TagID" },
                keyValues: new object[] { 18, 25 });
        }
    }
}
