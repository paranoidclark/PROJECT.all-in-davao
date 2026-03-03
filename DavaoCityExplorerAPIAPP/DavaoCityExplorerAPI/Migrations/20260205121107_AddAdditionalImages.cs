using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DavaoCityExplorerAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddAdditionalImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageID", "ImageURL", "Name" },
                values: new object[,]
                {
                    { 7, "/images/eagle-center.webp", "Philippine Eagle Center" },
                    { 8, "/images/eden-park.webp", "Eden's Nature Park" },
                    { 9, "/images/peoples-park.webp", "People's Park" },
                    { 11, "/images/poblacion-market.webp", "Poblacion Market Central" },
                    { 12, "/images/abreeza-mall.webp", "Abreeza Mall" },
                    { 13, "/images/matina-town-square.webp", "Matina Town Square" },
                    { 14, "/images/jack-ridge.webp", "Jack's Ridge" },
                    { 15, "/images/huckleberry-kitchen.webp", "Huckleberry Southern Kitchen" },
                    { 16, "/images/pearl-farm.webp", "Pearl Farm Beach Resort" },
                    { 17, "/images/abreeza-hotel.webp", "Seda Abreeza Hotel" },
                    { 18, "/images/malagos-resort.webp", "Malagos Garden Resort" },
                    { 19, "/images/yellowfin-restaurant.webp", "Yellow Fin Seafood Restaurant" },
                    { 20, "/images/wishbone-restaurant.webp", "The Wishbone Matina" },
                    { 21, "/images/penongs-restaurant.webp", "Penongs Matina Branch" },
                    { 22, "/images/davao-museum.webp", "Davao Museum of History" },
                    { 23, "/images/bone-museum.webp", "D' Bone Collector Museum" },
                    { 24, "/images/kublai-art-garden.webp", "Kublai Art Garden" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: 24);
        }
    }
}
