using Microsoft.EntityFrameworkCore.Migrations;

namespace MostarGuide.WebAPI.Migrations
{
    public partial class novakolonarezervacije : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "UkupanIznos",
                table: "Rezervacije",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UkupanIznos",
                table: "Rezervacije");
        }
    }
}
