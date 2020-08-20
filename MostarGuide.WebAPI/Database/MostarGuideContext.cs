using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MostarGuide.WebAPI.Database
{
    public class MostarGuideContext : DbContext
    {
        public MostarGuideContext(DbContextOptions<MostarGuideContext> options) : base(options)
        {

        }

        public virtual DbSet<Izleti> Izleti { get; set; }
        public virtual DbSet<Kategorije> Kategorije { get; set; }
        public virtual DbSet<Sekcije> Sekcije { get; set; }
        public virtual DbSet<OcjeneIzleti> OcjeneIzleti { get; set; }
        public virtual DbSet<OcjeneSekcije> OcjeneSekcije { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }
        public virtual DbSet<KorisniciUloge> KorisniciUloge { get; set; }
        public virtual DbSet<KorisniciMob> KorisniciMob { get; set; }
        public virtual DbSet<Rezervacije> Rezervacije { get; set; }
        public virtual DbSet<Uloge> Uloge { get; set; }
        public virtual DbSet<Termini> Termini { get; set; }
        public virtual DbSet<Uplate> Uplate { get; set; }
        public virtual DbSet<Favoriti> Favoriti { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=IB160037;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Uloge>(entity =>
            {
                entity.HasKey(e => e.UlogaId);

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis).HasMaxLength(200);

            });

            modelBuilder.Entity<Korisnici>(entity =>
            {
                entity.HasKey(e => e.KorisnikId);

                entity.HasIndex(e => e.Email)
                    .HasName("CS_Email")
                    .IsUnique();

                entity.HasIndex(e => e.KorisnickoIme)
                    .HasName("CS_KorisnickoIme")
                    .IsUnique();

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Telefon).HasMaxLength(20);
            });

            modelBuilder.Entity<KorisniciUloge>(entity =>
            {
                entity.HasKey(e => e.KorisnikUlogaId);

                entity.Property(e => e.KorisnikUlogaId).HasColumnName("KorisnikUlogaID");

                entity.Property(e => e.DatumIzmjene).HasColumnType("datetime");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK_KorisniciUloge_Korisnici");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.UlogaId)
                    .HasConstraintName("FK_KorisniciUloge_Uloge");
            });

            modelBuilder.Entity<Termini>(entity =>
            {
                entity.HasKey(e => e.TerminId);

                //entity.Property(e => e.VrijemeTermina).HasColumnType("datetime");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Termini)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK_Termin_Korisnik_Id");

                entity.HasOne(d => d.Izlet)
                   .WithMany(p => p.Termini)
                   .HasForeignKey(d => d.IzletId)
                   .HasConstraintName("FK_Termin_Izlet_Id");
            });

            modelBuilder.Entity<Izleti>(entity =>
            {
                entity.HasKey(e => e.IzletId);

                entity.Property(e => e.Slika).HasColumnType("image");

                entity.Property(e => e.Cijena).HasColumnType("decimal(5, 2)");

                //entity.Property(e => e.Status)
                //    .IsRequired()
                //    .HasDefaultValueSql("((1))");

            });

            modelBuilder.Entity<Rezervacije>(entity =>
            {
                
                entity.HasKey(e => e.RezervacijaId);

                entity.Property(e => e.DatumRezervacije).HasColumnType("datetime");


                entity.HasIndex(e => e.KorisnikMobId);

                entity.HasIndex(e => e.TerminId);


                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.KorisnikMobId);

                entity.HasOne(d => d.Termin)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.TerminId);
                
            });

            modelBuilder.Entity<Kategorije>(entity =>
            {
                entity.HasKey(e => e.KategorijaId);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(20);

            });

            modelBuilder.Entity<Sekcije>(entity =>
            {
                entity.HasKey(e => e.SekcijaId);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Slika).HasColumnType("image");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(500);


                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Webstranica)
                   .IsRequired()
                   .HasMaxLength(50);

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Sekcije)
                    .HasForeignKey(d => d.KategorijaId);
            });

            modelBuilder.Entity<OcjeneIzleti>(entity =>
            {
                entity.HasKey(e => e.OcjenaId);

                entity.Property(e => e.OcjenaId).HasColumnName("OcjenaID");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                //entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                //entity.Property(e => e.IzletId).HasColumnName("IzletID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.OcjeneIzleti)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK_OcjeneIzleti_Korisnici");

                entity.HasOne(d => d.Izlet)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.IzletId)
                    .HasConstraintName("FK_Ocjene_Izleti");
            });

            modelBuilder.Entity<KorisniciMob>(entity =>
            {
                entity.HasKey(e => e.KorisnikId);

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                //entity.Property(e => e.DatumRegistracije).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OcjeneSekcije>(entity =>
            {
                entity.HasKey(e => e.OcjenaId);

                entity.Property(e => e.OcjenaId).HasColumnName("OcjenaID");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                //entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                //entity.Property(e => e.SekcijaId).HasColumnName("SekcijaID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.OcjeneSekcije)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK_OcjeneSekcije_Korisnici");

                entity.HasOne(d => d.Sekcije)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.SekcijaId)
                    .HasConstraintName("FK_Ocjene_Sekcije");
            });
        }


    }
}
