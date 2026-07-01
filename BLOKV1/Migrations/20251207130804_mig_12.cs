using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BLOKV1.Migrations
{
    /// <inheritdoc />
    public partial class mig_12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectImages_Details_DetailsId",
                table: "ProjectImages");

            migrationBuilder.RenameColumn(
                name: "DetailsId",
                table: "ProjectImages",
                newName: "ProjectDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectImages_DetailsId",
                table: "ProjectImages",
                newName: "IX_ProjectImages_ProjectDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectImages_Details_ProjectDetailId",
                table: "ProjectImages",
                column: "ProjectDetailId",
                principalTable: "Details",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectImages_Details_ProjectDetailId",
                table: "ProjectImages");

            migrationBuilder.RenameColumn(
                name: "ProjectDetailId",
                table: "ProjectImages",
                newName: "DetailsId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectImages_ProjectDetailId",
                table: "ProjectImages",
                newName: "IX_ProjectImages_DetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectImages_Details_DetailsId",
                table: "ProjectImages",
                column: "DetailsId",
                principalTable: "Details",
                principalColumn: "Id");
        }
    }
}
