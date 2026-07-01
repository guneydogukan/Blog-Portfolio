using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BLOKV1.Migrations
{
    /// <inheritdoc />
    public partial class mig_11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectImages_Details_ProjectDetailsId",
                table: "ProjectImages");

            migrationBuilder.DropIndex(
                name: "IX_ProjectImages_ProjectDetailsId",
                table: "ProjectImages");

            migrationBuilder.RenameColumn(
                name: "ProjectDetailsId",
                table: "ProjectImages",
                newName: "ProjectId");

            migrationBuilder.AddColumn<int>(
                name: "DetailsId",
                table: "ProjectImages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectImages_DetailsId",
                table: "ProjectImages",
                column: "DetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectImages_Details_DetailsId",
                table: "ProjectImages",
                column: "DetailsId",
                principalTable: "Details",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectImages_Details_DetailsId",
                table: "ProjectImages");

            migrationBuilder.DropIndex(
                name: "IX_ProjectImages_DetailsId",
                table: "ProjectImages");

            migrationBuilder.DropColumn(
                name: "DetailsId",
                table: "ProjectImages");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "ProjectImages",
                newName: "ProjectDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectImages_ProjectDetailsId",
                table: "ProjectImages",
                column: "ProjectDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectImages_Details_ProjectDetailsId",
                table: "ProjectImages",
                column: "ProjectDetailsId",
                principalTable: "Details",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
