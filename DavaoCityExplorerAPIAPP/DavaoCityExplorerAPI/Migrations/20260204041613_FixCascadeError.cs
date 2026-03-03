using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DavaoCityExplorerAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixCascadeError : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ImageID",
                table: "Places",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "ImageID",
                table: "Places",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
