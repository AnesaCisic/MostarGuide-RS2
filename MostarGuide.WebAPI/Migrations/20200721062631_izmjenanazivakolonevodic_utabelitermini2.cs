using Microsoft.EntityFrameworkCore.Migrations;

namespace MostarGuide.WebAPI.Migrations
{
    public partial class izmjenanazivakolonevodic_utabelitermini2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Termin_Vodic_Id",
                table: "Termini");

            migrationBuilder.AddForeignKey(
                name: "FK_Termin_Korisnik_Id",
                table: "Termini",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Termin_Korisnik_Id",
                table: "Termini");

            migrationBuilder.AddForeignKey(
                name: "FK_Termin_Vodic_Id",
                table: "Termini",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
