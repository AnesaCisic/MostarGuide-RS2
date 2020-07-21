using Microsoft.EntityFrameworkCore.Migrations;

namespace MostarGuide.WebAPI.Migrations
{
    public partial class izmjenanazivakolonevodic_utabelitermini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Termin_Vodic_Id",
                table: "Termini");

            migrationBuilder.DropIndex(
                name: "IX_Termini_VodicId",
                table: "Termini");

            migrationBuilder.DropColumn(
                name: "VodicId",
                table: "Termini");

            migrationBuilder.AddColumn<int>(
                name: "KorisnikId",
                table: "Termini",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Termini_KorisnikId",
                table: "Termini",
                column: "KorisnikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Termin_Vodic_Id",
                table: "Termini",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Termin_Vodic_Id",
                table: "Termini");

            migrationBuilder.DropIndex(
                name: "IX_Termini_KorisnikId",
                table: "Termini");

            migrationBuilder.DropColumn(
                name: "KorisnikId",
                table: "Termini");

            migrationBuilder.AddColumn<int>(
                name: "VodicId",
                table: "Termini",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Termini_VodicId",
                table: "Termini",
                column: "VodicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Termin_Vodic_Id",
                table: "Termini",
                column: "VodicId",
                principalTable: "Korisnici",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
