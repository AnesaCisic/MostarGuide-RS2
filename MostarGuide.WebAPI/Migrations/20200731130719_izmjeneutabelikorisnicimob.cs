using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MostarGuide.WebAPI.Migrations
{
    public partial class izmjeneutabelikorisnicimob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatumRegistracije",
                table: "KorisniciMob");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "KorisniciMob");

            migrationBuilder.AddColumn<string>(
                name: "BrojTelefona",
                table: "KorisniciMob",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrojTelefona",
                table: "KorisniciMob");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumRegistracije",
                table: "KorisniciMob",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "KorisniciMob",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
