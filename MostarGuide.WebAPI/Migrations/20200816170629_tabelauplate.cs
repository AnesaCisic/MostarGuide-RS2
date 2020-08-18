using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MostarGuide.WebAPI.Migrations
{
    public partial class tabelauplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KorisniciUloge_Korisnici",
                table: "KorisniciUloge");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisniciUloge_Uloge",
                table: "KorisniciUloge");

            migrationBuilder.AlterColumn<int>(
                name: "UlogaID",
                table: "KorisniciUloge",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "KorisnikID",
                table: "KorisniciUloge",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DatumIzmjene",
                table: "KorisniciUloge",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.CreateTable(
                name: "Uplate",
                columns: table => new
                {
                    UplataID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RezervacijaID = table.Column<int>(nullable: false),
                    Iznos = table.Column<decimal>(nullable: false),
                    UplataID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uplate", x => x.UplataID);
                    table.ForeignKey(
                        name: "FK_Uplate_Rezervacije_RezervacijaID",
                        column: x => x.RezervacijaID,
                        principalTable: "Rezervacije",
                        principalColumn: "RezervacijaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Uplate_Uplate_UplataID1",
                        column: x => x.UplataID1,
                        principalTable: "Uplate",
                        principalColumn: "UplataID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Uplate_RezervacijaID",
                table: "Uplate",
                column: "RezervacijaID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Uplate_UplataID1",
                table: "Uplate",
                column: "UplataID1");

            migrationBuilder.AddForeignKey(
                name: "FK_KorisniciUloge_Korisnici",
                table: "KorisniciUloge",
                column: "KorisnikID",
                principalTable: "Korisnici",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisniciUloge_Uloge",
                table: "KorisniciUloge",
                column: "UlogaID",
                principalTable: "Uloge",
                principalColumn: "UlogaID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KorisniciUloge_Korisnici",
                table: "KorisniciUloge");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisniciUloge_Uloge",
                table: "KorisniciUloge");

            migrationBuilder.DropTable(
                name: "Uplate");

            migrationBuilder.AlterColumn<int>(
                name: "UlogaID",
                table: "KorisniciUloge",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KorisnikID",
                table: "KorisniciUloge",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DatumIzmjene",
                table: "KorisniciUloge",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisniciUloge_Korisnici",
                table: "KorisniciUloge",
                column: "KorisnikID",
                principalTable: "Korisnici",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisniciUloge_Uloge",
                table: "KorisniciUloge",
                column: "UlogaID",
                principalTable: "Uloge",
                principalColumn: "UlogaID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
