using Microsoft.EntityFrameworkCore.Migrations;

namespace MostarGuide.WebAPI.Migrations
{
    public partial class izmjenanazivaufavoriti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorit_KorisniciMob_KorisnikId",
                table: "Favorit");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorit_Sekcije_SekcijaId",
                table: "Favorit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Favorit",
                table: "Favorit");

            migrationBuilder.RenameTable(
                name: "Favorit",
                newName: "Favoriti");

            migrationBuilder.RenameIndex(
                name: "IX_Favorit_SekcijaId",
                table: "Favoriti",
                newName: "IX_Favoriti_SekcijaId");

            migrationBuilder.RenameIndex(
                name: "IX_Favorit_KorisnikId",
                table: "Favoriti",
                newName: "IX_Favoriti_KorisnikId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Favoriti",
                table: "Favoriti",
                column: "FavoritId");

            migrationBuilder.AddForeignKey(
                name: "FK_Favoriti_KorisniciMob_KorisnikId",
                table: "Favoriti",
                column: "KorisnikId",
                principalTable: "KorisniciMob",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Favoriti_Sekcije_SekcijaId",
                table: "Favoriti",
                column: "SekcijaId",
                principalTable: "Sekcije",
                principalColumn: "SekcijaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favoriti_KorisniciMob_KorisnikId",
                table: "Favoriti");

            migrationBuilder.DropForeignKey(
                name: "FK_Favoriti_Sekcije_SekcijaId",
                table: "Favoriti");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Favoriti",
                table: "Favoriti");

            migrationBuilder.RenameTable(
                name: "Favoriti",
                newName: "Favorit");

            migrationBuilder.RenameIndex(
                name: "IX_Favoriti_SekcijaId",
                table: "Favorit",
                newName: "IX_Favorit_SekcijaId");

            migrationBuilder.RenameIndex(
                name: "IX_Favoriti_KorisnikId",
                table: "Favorit",
                newName: "IX_Favorit_KorisnikId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Favorit",
                table: "Favorit",
                column: "FavoritId");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorit_KorisniciMob_KorisnikId",
                table: "Favorit",
                column: "KorisnikId",
                principalTable: "KorisniciMob",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorit_Sekcije_SekcijaId",
                table: "Favorit",
                column: "SekcijaId",
                principalTable: "Sekcije",
                principalColumn: "SekcijaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
