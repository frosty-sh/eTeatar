﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eTeatar.Data;

namespace eTeatar.Data.Migrations
{
    [DbContext(typeof(MojContext))]
    [Migration("20190314232012_SlikaLink")]
    partial class SlikaLink
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("eTeatar.Data.Models.Administrator", b =>
                {
                    b.Property<int>("AdministratorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KorisnikId");

                    b.Property<string>("Username");

                    b.HasKey("AdministratorId");

                    b.HasIndex("KorisnikId")
                        .IsUnique()
                        .HasFilter("[KorisnikId] IS NOT NULL");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("eTeatar.Data.Models.Avatar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Link");

                    b.HasKey("Id");

                    b.ToTable("Avatar");
                });

            modelBuilder.Entity("eTeatar.Data.Models.Dvorana", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("TeatarId");

                    b.HasKey("Id");

                    b.HasIndex("TeatarId");

                    b.ToTable("Dvorana");
                });

            modelBuilder.Entity("eTeatar.Data.Models.DvoranaTipSjedista", b =>
                {
                    b.Property<int>("DvoranaId");

                    b.Property<int>("TipSjedistaId");

                    b.Property<int>("BrojSjedista");

                    b.Property<bool>("IsDeleted");

                    b.HasKey("DvoranaId", "TipSjedistaId");

                    b.HasIndex("TipSjedistaId");

                    b.ToTable("DvoranaTipSjedista");
                });

            modelBuilder.Entity("eTeatar.Data.Models.Glumac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("SlikaLink");

                    b.HasKey("Id");

                    b.ToTable("Glumac");
                });

            modelBuilder.Entity("eTeatar.Data.Models.Grad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("eTeatar.Data.Models.Komentar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumVrijeme");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("KupacId");

                    b.Property<int>("ObavijestId");

                    b.Property<string>("Sadrzaj")
                        .IsRequired()
                        .HasMaxLength(1024);

                    b.HasKey("Id");

                    b.HasIndex("KupacId");

                    b.HasIndex("ObavijestId");

                    b.ToTable("Komentar");
                });

            modelBuilder.Entity("eTeatar.Data.Models.Korisnik", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<int?>("AdministratorId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("KorisnikId");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("eTeatar.Data.Models.Kupac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AvatarId");

                    b.Property<int>("GradId");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("KorisnikId");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("TipKorisnikaId");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId");

                    b.HasIndex("GradId");

                    b.HasIndex("KorisnikId")
                        .IsUnique()
                        .HasFilter("[KorisnikId] IS NOT NULL");

                    b.HasIndex("TipKorisnikaId");

                    b.ToTable("Kupac");
                });

            modelBuilder.Entity("eTeatar.Data.Models.Narudzba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CijenaKarte");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("Kolicina");

                    b.Property<int>("KupacId");

                    b.Property<int?>("OcjenaId");

                    b.Property<int>("TerminId");

                    b.Property<int>("TipSjedistaId");

                    b.HasKey("Id");

                    b.HasIndex("KupacId");

                    b.HasIndex("TerminId");

                    b.HasIndex("TipSjedistaId");

                    b.ToTable("Narudzba");
                });

            modelBuilder.Entity("eTeatar.Data.Models.Obavijest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdministratorId");

                    b.Property<DateTime>("DatumVrijeme");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Naslov")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Sadrzaj")
                        .IsRequired()
                        .HasMaxLength(4096);

                    b.Property<string>("SlikaLink");

                    b.HasKey("Id");

                    b.HasIndex("AdministratorId");

                    b.ToTable("Obavijest");
                });

            modelBuilder.Entity("eTeatar.Data.Models.Ocjena", b =>
                {
                    b.Property<int>("Id");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("NarudzbaId");

                    b.Property<string>("Review")
                        .HasMaxLength(512);

                    b.Property<int>("Vrijednost");

                    b.HasKey("Id");

                    b.ToTable("Ocjena");
                });

            modelBuilder.Entity("eTeatar.Data.Models.Predstava", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("NazivIzvornogDjela")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasMaxLength(512);

                    b.Property<string>("ReziserImePrezime")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("SlikaLink");

                    b.Property<string>("Trajanje")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Predstava");
                });

            modelBuilder.Entity("eTeatar.Data.Models.PredstavaZanr", b =>
                {
                    b.Property<int>("PredstavaId");

                    b.Property<int>("ZanrId");

                    b.Property<bool>("IsDeleted");

                    b.HasKey("PredstavaId", "ZanrId");

                    b.HasIndex("ZanrId");

                    b.ToTable("PredstavaZanr");
                });

            modelBuilder.Entity("eTeatar.Data.Models.Teatar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GradId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("GradId");

                    b.ToTable("Teatar");
                });

            modelBuilder.Entity("eTeatar.Data.Models.Termin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BaznaCijenaKarte");

                    b.Property<DateTime>("DatumVrijeme");

                    b.Property<int>("DvoranaId");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("PredstavaId");

                    b.HasKey("Id");

                    b.HasIndex("DvoranaId");

                    b.HasIndex("PredstavaId");

                    b.ToTable("Termin");
                });

            modelBuilder.Entity("eTeatar.Data.Models.TipKorisnika", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cijena");

                    b.Property<float>("CijenaKartePopust");

                    b.Property<int?>("IduciTipKorisnikaId");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsOsnovni");

                    b.Property<string>("Naziv")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IduciTipKorisnikaId");

                    b.ToTable("TipKorisnika");
                });

            modelBuilder.Entity("eTeatar.Data.Models.TipSjedista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CijenaKarteMultiplier");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("TipSjedista");
                });

            modelBuilder.Entity("eTeatar.Data.Models.Uloga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GlumacId");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsGlavnaUloga");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("PredstavaId");

                    b.HasKey("Id");

                    b.HasIndex("GlumacId");

                    b.HasIndex("PredstavaId");

                    b.ToTable("Uloga");
                });

            modelBuilder.Entity("eTeatar.Data.Models.Zanr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Zanr");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("eTeatar.Data.Models.Korisnik")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("eTeatar.Data.Models.Korisnik")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("eTeatar.Data.Models.Korisnik")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("eTeatar.Data.Models.Korisnik")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("eTeatar.Data.Models.Administrator", b =>
                {
                    b.HasOne("eTeatar.Data.Models.Korisnik", "Korisnik")
                        .WithOne("Administrator")
                        .HasForeignKey("eTeatar.Data.Models.Administrator", "KorisnikId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("eTeatar.Data.Models.Dvorana", b =>
                {
                    b.HasOne("eTeatar.Data.Models.Teatar", "Teatar")
                        .WithMany("Dvorane")
                        .HasForeignKey("TeatarId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("eTeatar.Data.Models.DvoranaTipSjedista", b =>
                {
                    b.HasOne("eTeatar.Data.Models.Dvorana", "Dvorana")
                        .WithMany("DvoranaTipSjedista")
                        .HasForeignKey("DvoranaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("eTeatar.Data.Models.TipSjedista", "TipSjedista")
                        .WithMany("DvoranaTipSjedista")
                        .HasForeignKey("TipSjedistaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("eTeatar.Data.Models.Komentar", b =>
                {
                    b.HasOne("eTeatar.Data.Models.Kupac", "Kupac")
                        .WithMany("Komentari")
                        .HasForeignKey("KupacId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("eTeatar.Data.Models.Obavijest", "Obavijest")
                        .WithMany("Komentari")
                        .HasForeignKey("ObavijestId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("eTeatar.Data.Models.Kupac", b =>
                {
                    b.HasOne("eTeatar.Data.Models.Avatar", "Avatar")
                        .WithMany()
                        .HasForeignKey("AvatarId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("eTeatar.Data.Models.Grad", "Grad")
                        .WithMany("Kupci")
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("eTeatar.Data.Models.Korisnik", "Korisnik")
                        .WithOne("Kupac")
                        .HasForeignKey("eTeatar.Data.Models.Kupac", "KorisnikId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("eTeatar.Data.Models.TipKorisnika", "TipKorisnika")
                        .WithMany()
                        .HasForeignKey("TipKorisnikaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("eTeatar.Data.Models.Narudzba", b =>
                {
                    b.HasOne("eTeatar.Data.Models.Kupac", "Kupac")
                        .WithMany("Narudzbe")
                        .HasForeignKey("KupacId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("eTeatar.Data.Models.Termin", "Termin")
                        .WithMany()
                        .HasForeignKey("TerminId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("eTeatar.Data.Models.TipSjedista", "TipSjedista")
                        .WithMany()
                        .HasForeignKey("TipSjedistaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("eTeatar.Data.Models.Obavijest", b =>
                {
                    b.HasOne("eTeatar.Data.Models.Administrator", "Administrator")
                        .WithMany("Obavijesti")
                        .HasForeignKey("AdministratorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("eTeatar.Data.Models.Ocjena", b =>
                {
                    b.HasOne("eTeatar.Data.Models.Narudzba", "Narudzba")
                        .WithOne("Ocjena")
                        .HasForeignKey("eTeatar.Data.Models.Ocjena", "Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("eTeatar.Data.Models.PredstavaZanr", b =>
                {
                    b.HasOne("eTeatar.Data.Models.Predstava", "Predstava")
                        .WithMany("PredstavaZanr")
                        .HasForeignKey("PredstavaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("eTeatar.Data.Models.Zanr", "Zanr")
                        .WithMany("PredstavaZanr")
                        .HasForeignKey("ZanrId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("eTeatar.Data.Models.Teatar", b =>
                {
                    b.HasOne("eTeatar.Data.Models.Grad", "Grad")
                        .WithMany("Teatari")
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("eTeatar.Data.Models.Termin", b =>
                {
                    b.HasOne("eTeatar.Data.Models.Dvorana", "Dvorana")
                        .WithMany("Termini")
                        .HasForeignKey("DvoranaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("eTeatar.Data.Models.Predstava", "Predstava")
                        .WithMany("Termini")
                        .HasForeignKey("PredstavaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("eTeatar.Data.Models.TipKorisnika", b =>
                {
                    b.HasOne("eTeatar.Data.Models.TipKorisnika", "IduciTipKorisnika")
                        .WithMany()
                        .HasForeignKey("IduciTipKorisnikaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("eTeatar.Data.Models.Uloga", b =>
                {
                    b.HasOne("eTeatar.Data.Models.Glumac", "Glumac")
                        .WithMany("Uloge")
                        .HasForeignKey("GlumacId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("eTeatar.Data.Models.Predstava", "Predstava")
                        .WithMany("Uloge")
                        .HasForeignKey("PredstavaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
