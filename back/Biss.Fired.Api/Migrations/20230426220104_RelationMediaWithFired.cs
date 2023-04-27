using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biss.Fired.Api.Migrations
{
    /// <inheritdoc />
    public partial class RelationMediaWithFired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FiredId",
                table: "Media",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Media_FiredId",
                table: "Media",
                column: "FiredId");

            migrationBuilder.AddForeignKey(
                name: "FK_Media_Fired_FiredId",
                table: "Media",
                column: "FiredId",
                principalTable: "Fired",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Media_Fired_FiredId",
                table: "Media");

            migrationBuilder.DropIndex(
                name: "IX_Media_FiredId",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "FiredId",
                table: "Media");
        }
    }
}
