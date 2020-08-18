using Microsoft.EntityFrameworkCore.Migrations;

namespace MostarGuide.WebAPI.Migrations
{
    public partial class uplateizmjena : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Uplate_Uplate_UplataID1",
                table: "Uplate");

            migrationBuilder.DropIndex(
                name: "IX_Uplate_UplataID1",
                table: "Uplate");

            migrationBuilder.DropColumn(
                name: "UplataID1",
                table: "Uplate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UplataID1",
                table: "Uplate",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Uplate_UplataID1",
                table: "Uplate",
                column: "UplataID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Uplate_Uplate_UplataID1",
                table: "Uplate",
                column: "UplataID1",
                principalTable: "Uplate",
                principalColumn: "UplataID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
