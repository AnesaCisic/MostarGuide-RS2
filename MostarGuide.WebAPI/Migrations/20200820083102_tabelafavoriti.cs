using Microsoft.EntityFrameworkCore.Migrations;

namespace MostarGuide.WebAPI.Migrations
{
    public partial class tabelafavoriti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "Sekcije");

            migrationBuilder.CreateTable(
                name: "Favorit",
                columns: table => new
                {
                    FavoritId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikId = table.Column<int>(nullable: false),
                    SekcijaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorit", x => x.FavoritId);
                    table.ForeignKey(
                        name: "FK_Favorit_KorisniciMob_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "KorisniciMob",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favorit_Sekcije_SekcijaId",
                        column: x => x.SekcijaId,
                        principalTable: "Sekcije",
                        principalColumn: "SekcijaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favorit_KorisnikId",
                table: "Favorit",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorit_SekcijaId",
                table: "Favorit",
                column: "SekcijaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorit");

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "Sekcije",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");
        }
    }
}
