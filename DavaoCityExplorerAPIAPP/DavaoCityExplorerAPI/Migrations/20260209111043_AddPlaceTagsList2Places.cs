using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DavaoCityExplorerAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddPlaceTagsList2Places : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PlaceTags_TagID",
                table: "PlaceTags",
                column: "TagID");

            migrationBuilder.AddForeignKey(
                name: "FK_PlaceTags_Places_PlaceID",
                table: "PlaceTags",
                column: "PlaceID",
                principalTable: "Places",
                principalColumn: "PlaceID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlaceTags_Tags_TagID",
                table: "PlaceTags",
                column: "TagID",
                principalTable: "Tags",
                principalColumn: "TagID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlaceTags_Places_PlaceID",
                table: "PlaceTags");

            migrationBuilder.DropForeignKey(
                name: "FK_PlaceTags_Tags_TagID",
                table: "PlaceTags");

            migrationBuilder.DropIndex(
                name: "IX_PlaceTags_TagID",
                table: "PlaceTags");
        }
    }
}
