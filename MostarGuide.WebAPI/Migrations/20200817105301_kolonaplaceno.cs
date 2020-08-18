using Microsoft.EntityFrameworkCore.Migrations;

namespace MostarGuide.WebAPI.Migrations
{
    public partial class kolonaplaceno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Placeno",
                table: "Rezervacije",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Placeno",
                table: "Rezervacije");
        }
    }
}
