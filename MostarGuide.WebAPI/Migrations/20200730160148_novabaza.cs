using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MostarGuide.WebAPI.Migrations
{
    public partial class novabaza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Izleti",
                columns: table => new
                {
                    IzletId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    BrojMjesta = table.Column<int>(nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(5, 2)", nullable: false),
                    Slika = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Izleti", x => x.IzletId);
                });

            migrationBuilder.CreateTable(
                name: "Kategorije",
                columns: table => new
                {
                    KategorijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorije", x => x.KategorijaId);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Telefon = table.Column<string>(maxLength: 20, nullable: true),
                    KorisnickoIme = table.Column<string>(maxLength: 50, nullable: false),
                    LozinkaHash = table.Column<string>(maxLength: 500, nullable: false),
                    LozinkaSalt = table.Column<string>(maxLength: 50, nullable: false),
                    Status = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.KorisnikID);
                });

            migrationBuilder.CreateTable(
                name: "KorisniciMob",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    DatumRegistracije = table.Column<DateTime>(type: "datetime", nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    KorisnickoIme = table.Column<string>(maxLength: 50, nullable: false),
                    LozinkaHash = table.Column<string>(maxLength: 50, nullable: false),
                    LozinkaSalt = table.Column<string>(maxLength: 50, nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisniciMob", x => x.KorisnikID);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    UlogaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Opis = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.UlogaID);
                });

            migrationBuilder.CreateTable(
                name: "Sekcije",
                columns: table => new
                {
                    SekcijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategorijaId = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Opis = table.Column<string>(maxLength: 500, nullable: false),
                    Adresa = table.Column<string>(maxLength: 100, nullable: false),
                    Webstranica = table.Column<string>(maxLength: 50, nullable: false),
                    Telefon = table.Column<string>(maxLength: 25, nullable: false),
                    Slika = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sekcije", x => x.SekcijaId);
                    table.ForeignKey(
                        name: "FK_Sekcije_Kategorije_KategorijaId",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorije",
                        principalColumn: "KategorijaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Termini",
                columns: table => new
                {
                    TerminId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IzletId = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    Vrijeme = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Termini", x => x.TerminId);
                    table.ForeignKey(
                        name: "FK_Termin_Izlet_Id",
                        column: x => x.IzletId,
                        principalTable: "Izleti",
                        principalColumn: "IzletId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Termin_Korisnik_Id",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OcjeneIzleti",
                columns: table => new
                {
                    OcjenaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IzletId = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ocjena = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OcjeneIzleti", x => x.OcjenaID);
                    table.ForeignKey(
                        name: "FK_Ocjene_Izleti",
                        column: x => x.IzletId,
                        principalTable: "Izleti",
                        principalColumn: "IzletId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OcjeneIzleti_Korisnici",
                        column: x => x.KorisnikId,
                        principalTable: "KorisniciMob",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KorisniciUloge",
                columns: table => new
                {
                    KorisnikUlogaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikID = table.Column<int>(nullable: false),
                    UlogaID = table.Column<int>(nullable: false),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisniciUloge", x => x.KorisnikUlogaID);
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Korisnici",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Uloge",
                        column: x => x.UlogaID,
                        principalTable: "Uloge",
                        principalColumn: "UlogaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OcjeneSekcije",
                columns: table => new
                {
                    OcjenaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SekcijaId = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ocjena = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OcjeneSekcije", x => x.OcjenaID);
                    table.ForeignKey(
                        name: "FK_OcjeneSekcije_Korisnici",
                        column: x => x.KorisnikId,
                        principalTable: "KorisniciMob",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ocjene_Sekcije",
                        column: x => x.SekcijaId,
                        principalTable: "Sekcije",
                        principalColumn: "SekcijaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacije",
                columns: table => new
                {
                    RezervacijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerminId = table.Column<int>(nullable: false),
                    KorisnikMobId = table.Column<int>(nullable: false),
                    DatumRezervacije = table.Column<DateTime>(type: "datetime", nullable: false),
                    BrojOsoba = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacije", x => x.RezervacijaId);
                    table.ForeignKey(
                        name: "FK_Rezervacije_KorisniciMob_KorisnikMobId",
                        column: x => x.KorisnikMobId,
                        principalTable: "KorisniciMob",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervacije_Termini_TerminId",
                        column: x => x.TerminId,
                        principalTable: "Termini",
                        principalColumn: "TerminId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "CS_Email",
                table: "Korisnici",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "CS_KorisnickoIme",
                table: "Korisnici",
                column: "KorisnickoIme",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_KorisnikID",
                table: "KorisniciUloge",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_UlogaID",
                table: "KorisniciUloge",
                column: "UlogaID");

            migrationBuilder.CreateIndex(
                name: "IX_OcjeneIzleti_IzletId",
                table: "OcjeneIzleti",
                column: "IzletId");

            migrationBuilder.CreateIndex(
                name: "IX_OcjeneIzleti_KorisnikId",
                table: "OcjeneIzleti",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_OcjeneSekcije_KorisnikId",
                table: "OcjeneSekcije",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_OcjeneSekcije_SekcijaId",
                table: "OcjeneSekcije",
                column: "SekcijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_KorisnikMobId",
                table: "Rezervacije",
                column: "KorisnikMobId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_TerminId",
                table: "Rezervacije",
                column: "TerminId");

            migrationBuilder.CreateIndex(
                name: "IX_Sekcije_KategorijaId",
                table: "Sekcije",
                column: "KategorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Termini_IzletId",
                table: "Termini",
                column: "IzletId");

            migrationBuilder.CreateIndex(
                name: "IX_Termini_KorisnikId",
                table: "Termini",
                column: "KorisnikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KorisniciUloge");

            migrationBuilder.DropTable(
                name: "OcjeneIzleti");

            migrationBuilder.DropTable(
                name: "OcjeneSekcije");

            migrationBuilder.DropTable(
                name: "Rezervacije");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Sekcije");

            migrationBuilder.DropTable(
                name: "KorisniciMob");

            migrationBuilder.DropTable(
                name: "Termini");

            migrationBuilder.DropTable(
                name: "Kategorije");

            migrationBuilder.DropTable(
                name: "Izleti");

            migrationBuilder.DropTable(
                name: "Korisnici");
        }
    }
}
