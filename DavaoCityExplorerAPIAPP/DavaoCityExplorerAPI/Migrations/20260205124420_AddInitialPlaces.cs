using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DavaoCityExplorerAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialPlaces : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "PlaceID", "CategoryID", "ImageID", "Location", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, 1, 7, "Malagos, Baguio District", "Philippine Eagle Center", 4.7999999999999998 },
                    { 2, 1, 8, "Toril, Davao City", "Eden Nature Park", 4.7000000000000002 },
                    { 3, 1, 9, "Palma Gil St, Poblacion", "People's Park", 4.5 },
                    { 4, 2, 5, "Roxas Avenue", "Roxas Night Market", 4.7999999999999998 },
                    { 5, 2, 11, "C. Bangoy St, Poblacion", "Poblacion Market Central", 4.5999999999999996 },
                    { 6, 2, 12, "J.P. Laurel Ave, Poblacion District", "Abreeza Mall", 4.7000000000000002 },
                    { 7, 3, 13, "McArthur Highway, Matina", "Matina Town Square (MTS)", 4.5 },
                    { 8, 3, 14, "Shrine Hills, Matina", "Jack's Ridge", 4.5999999999999996 },
                    { 9, 3, 15, "Oboza Compound, Rizal St", "Huckleberry Southern Kitchen", 4.4000000000000004 },
                    { 10, 4, 16, "Samal Island", "Pearl Farm Beach Resort", 4.9000000000000004 },
                    { 11, 4, 17, "J.P. Laurel Ave, Bajada", "Seda Abreeza Hotel", 4.7000000000000002 },
                    { 12, 4, 18, "Malagos, Calinan", "Malagos Garden Resort", 4.5999999999999996 },
                    { 13, 5, 19, "Quimpo Blvd, Ecoland", "Yellow Fin Seafood Restaurant", 4.7000000000000002 },
                    { 14, 5, 20, "Water District Matina, Along Gen. Douglas MacArthur Hwy,", "The Wishbone", 4.7999999999999998 },
                    { 15, 5, 21, "Erya Bldg, Pag-Asa Village", "Penong's Matina Aplaya", 4.5 },
                    { 16, 6, 22, "Insular Village, Lanang", "Davao Museum of History", 4.5999999999999996 },
                    { 17, 6, 23, "San Pedro St, Poblacion", "D' Bone Collector Museum", 4.7999999999999998 },
                    { 18, 6, 24, "Kapatagan, Digos (Nearby)", "Kublai Art Garden", 4.7000000000000002 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceID",
                keyValue: 18);
        }
    }
}
