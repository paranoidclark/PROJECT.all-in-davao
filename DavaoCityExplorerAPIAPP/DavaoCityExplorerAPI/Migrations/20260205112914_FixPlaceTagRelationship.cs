using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DavaoCityExplorerAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixPlaceTagRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Places_Tags_TagID",
                table: "Places");

            migrationBuilder.DropIndex(
                name: "IX_Places_TagID",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "TagID",
                table: "Places");

            migrationBuilder.CreateTable(
                name: "PlaceTags",
                columns: table => new
                {
                    PlaceID = table.Column<int>(type: "int", nullable: false),
                    TagID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceTags", x => new { x.PlaceID, x.TagID });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlaceTags");

            migrationBuilder.AddColumn<int>(
                name: "TagID",
                table: "Places",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Places_TagID",
                table: "Places",
                column: "TagID");

            migrationBuilder.AddForeignKey(
                name: "FK_Places_Tags_TagID",
                table: "Places",
                column: "TagID",
                principalTable: "Tags",
                principalColumn: "TagID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
