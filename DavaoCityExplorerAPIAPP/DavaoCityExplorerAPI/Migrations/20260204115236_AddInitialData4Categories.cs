using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DavaoCityExplorerAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialData4Categories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "ImageID", "Path", "Title" },
                values: new object[,]
                {
                    { 1, "From the majestic peaks of Mt. Apo to the sanctuary of the Philippine Eagle, witness the icons that define the South.", 1, "/attractions", "Discover Nature’s Grandest Stage" },
                    { 2, "Hunt for authentic pearls, weave through bustling night markets, or enjoy world-class retail therapy in the heart of the city.", 2, "/shopping", "Malls, Markets & Memories" },
                    { 3, "Experience the vibrant nightlife, live local music, and the festive spirit that comes alive when the sun goes down.", 3, "/entertainment", "The Pulse of the City" },
                    { 4, "Whether you seek 5-star luxury by the sea or a cozy backpacker’s haven, find your perfect sanctuary here.", 4, "/accommodation", "Your Home in the South" },
                    { 5, "Dare to taste the King of Fruits, savor the freshest Tuna, and dive into a culinary landscape you won’t find anywhere else.", 5, "/foodscene", "A Feast of Flavors" },
                    { 6, "Walk through time at the museums, meet the 11 tribes, and discover the rich heritage that weaves the city together.", 6, "/art&museum", "The Soul of Davao" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 6);
        }
    }
}
