﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MostarGuide.WebAPI.Database;

namespace MostarGuide.WebAPI.Migrations
{
    [DbContext(typeof(MostarGuideContext))]
    partial class MostarGuideContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MostarGuide.WebAPI.Database.Izleti", b =>
                {
                    b.Property<int>("IzletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojMjesta")
                        .HasColumnType("int");

                    b.Property<decimal>("Cijena")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("image");

                    b.HasKey("IzletId");

                    b.ToTable("Izleti");
                });

            modelBuilder.Entity("MostarGuide.WebAPI.Database.Kategorije", b =>
                {
                    b.Property<int>("KategorijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("KategorijaId");

                    b.ToTable("Kategorije");
                });

            modelBuilder.Entity("MostarGuide.WebAPI.Database.Korisnici", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KorisnikID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LozinkaHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("LozinkaSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool?>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("KorisnikId");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasName("CS_Email")
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("KorisnickoIme")
                        .IsUnique()
                        .HasName("CS_KorisnickoIme");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("MostarGuide.WebAPI.Database.KorisniciMob", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KorisnikID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrojTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LozinkaHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LozinkaSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("KorisnikId");

                    b.ToTable("KorisniciMob");
                });

            modelBuilder.Entity("MostarGuide.WebAPI.Database.KorisniciUloge", b =>
                {
                    b.Property<int>("KorisnikUlogaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KorisnikUlogaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumIzmjene")
                        .HasColumnType("datetime");

                    b.Property<int>("KorisnikId")
                        .HasColumnName("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int>("UlogaId")
                        .HasColumnName("UlogaID")
                        .HasColumnType("int");

                    b.HasKey("KorisnikUlogaId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("UlogaId");

                    b.ToTable("KorisniciUloge");
                });

            modelBuilder.Entity("MostarGuide.WebAPI.Database.OcjeneIzleti", b =>
                {
                    b.Property<int>("OcjenaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OcjenaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime");

                    b.Property<int>("IzletId")
                        .HasColumnType("int");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("Ocjena")
                        .HasColumnType("int");

                    b.HasKey("OcjenaId");

                    b.HasIndex("IzletId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("OcjeneIzleti");
                });

            modelBuilder.Entity("MostarGuide.WebAPI.Database.OcjeneSekcije", b =>
                {
                    b.Property<int>("OcjenaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OcjenaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("Ocjena")
                        .HasColumnType("int");

                    b.Property<int>("SekcijaId")
                        .HasColumnType("int");

                    b.HasKey("OcjenaId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("SekcijaId");

                    b.ToTable("OcjeneSekcije");
                });

            modelBuilder.Entity("MostarGuide.WebAPI.Database.Rezervacije", b =>
                {
                    b.Property<int>("RezervacijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojOsoba")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumRezervacije")
                        .HasColumnType("datetime");

                    b.Property<int>("KorisnikMobId")
                        .HasColumnType("int");

                    b.Property<int>("TerminId")
                        .HasColumnType("int");

                    b.HasKey("RezervacijaId");

                    b.HasIndex("KorisnikMobId");

                    b.HasIndex("TerminId");

                    b.ToTable("Rezervacije");
                });

            modelBuilder.Entity("MostarGuide.WebAPI.Database.Sekcije", b =>
                {
                    b.Property<int>("SekcijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("KategorijaId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<byte[]>("Slika")
                        .HasColumnType("image");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("Webstranica")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("SekcijaId");

                    b.HasIndex("KategorijaId");

                    b.ToTable("Sekcije");
                });

            modelBuilder.Entity("MostarGuide.WebAPI.Database.Termini", b =>
                {
                    b.Property<int>("TerminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IzletId")
                        .HasColumnType("int");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<DateTime>("VrijemeTermina")
                        .HasColumnType("datetime2");

                    b.HasKey("TerminId");

                    b.HasIndex("IzletId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Termini");
                });

            modelBuilder.Entity("MostarGuide.WebAPI.Database.Uloge", b =>
                {
                    b.Property<int>("UlogaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UlogaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("UlogaId");

                    b.ToTable("Uloge");
                });

            modelBuilder.Entity("MostarGuide.WebAPI.Database.KorisniciUloge", b =>
                {
                    b.HasOne("MostarGuide.WebAPI.Database.Korisnici", "Korisnik")
                        .WithMany("KorisniciUloge")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK_KorisniciUloge_Korisnici")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MostarGuide.WebAPI.Database.Uloge", "Uloga")
                        .WithMany("KorisniciUloge")
                        .HasForeignKey("UlogaId")
                        .HasConstraintName("FK_KorisniciUloge_Uloge")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MostarGuide.WebAPI.Database.OcjeneIzleti", b =>
                {
                    b.HasOne("MostarGuide.WebAPI.Database.Izleti", "Izlet")
                        .WithMany("Ocjene")
                        .HasForeignKey("IzletId")
                        .HasConstraintName("FK_Ocjene_Izleti")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MostarGuide.WebAPI.Database.KorisniciMob", "Korisnik")
                        .WithMany("OcjeneIzleti")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK_OcjeneIzleti_Korisnici")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MostarGuide.WebAPI.Database.OcjeneSekcije", b =>
                {
                    b.HasOne("MostarGuide.WebAPI.Database.KorisniciMob", "Korisnik")
                        .WithMany("OcjeneSekcije")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK_OcjeneSekcije_Korisnici")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MostarGuide.WebAPI.Database.Sekcije", "Sekcije")
                        .WithMany("Ocjene")
                        .HasForeignKey("SekcijaId")
                        .HasConstraintName("FK_Ocjene_Sekcije")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MostarGuide.WebAPI.Database.Rezervacije", b =>
                {
                    b.HasOne("MostarGuide.WebAPI.Database.KorisniciMob", "Korisnik")
                        .WithMany("Rezervacije")
                        .HasForeignKey("KorisnikMobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MostarGuide.WebAPI.Database.Termini", "Termin")
                        .WithMany("Rezervacije")
                        .HasForeignKey("TerminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MostarGuide.WebAPI.Database.Sekcije", b =>
                {
                    b.HasOne("MostarGuide.WebAPI.Database.Kategorije", "Kategorija")
                        .WithMany("Sekcije")
                        .HasForeignKey("KategorijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MostarGuide.WebAPI.Database.Termini", b =>
                {
                    b.HasOne("MostarGuide.WebAPI.Database.Izleti", "Izlet")
                        .WithMany("Termini")
                        .HasForeignKey("IzletId")
                        .HasConstraintName("FK_Termin_Izlet_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MostarGuide.WebAPI.Database.Korisnici", "Korisnik")
                        .WithMany("Termini")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK_Termin_Korisnik_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
