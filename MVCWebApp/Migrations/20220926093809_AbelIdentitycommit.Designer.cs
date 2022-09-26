﻿// <auto-generated />
using System;
using MVCWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCWebApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220926093809_AbelIdentitycommit")]
    partial class AbelIdentitycommit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVCWebApp.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "e4a6506e-9f29-4d05-8f44-93f3fa2c7ffa",
                            AccessFailedCount = 0,
                            BirthDate = new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "c2776599-e8bf-4569-8e21-26a6dee2a38c",
                            Email = "admin@adminmvc.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Adminsson",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMINMVC.COM",
                            NormalizedUserName = "ADMIN@ADMINMVC.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBNgZhfjBo5VS4lVbekTLYILhQ5Ixy7tP050KpmGqWnanl+fmCvZJ+jHksZ31lRq8A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e4e5e6e7-bdd5-4429-b922-c4d3b6263c89",
                            TwoFactorEnabled = false,
                            UserName = "admin@adminmvc.com"
                        },
                        new
                        {
                            Id = "beb5a905-8645-41b8-86f7-7de855713270",
                            AccessFailedCount = 0,
                            BirthDate = new DateTime(1990, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "9947c366-0eff-445a-ab7d-54cad41f233e",
                            Email = "user@usermvc.com",
                            EmailConfirmed = false,
                            FirstName = "Adam",
                            LastName = "Adamsson",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@USERMVC.COM",
                            NormalizedUserName = "USER@USERMVC.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENS+CwEhN2Qd4Zy39C2YK4lf47og2E8QOk/oZuQXCT+9rIFa8GtoST6mYBl3hKWKOQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ef104c8b-47d5-4d5e-bac7-38760ca23c30",
                            TwoFactorEnabled = false,
                            UserName = "user@usermvc.com"
                        });
                });

            modelBuilder.Entity("MVCWebApp.Models.City.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryForeignKey")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CountryForeignKey");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CityName = "Stockholm",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            ID = 2,
                            CityName = "Oslo",
                            CountryForeignKey = 2
                        },
                        new
                        {
                            ID = 3,
                            CityName = "Köpenhamn",
                            CountryForeignKey = 3
                        });
                });

            modelBuilder.Entity("MVCWebApp.Models.Country.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CountryName = "Sverige"
                        },
                        new
                        {
                            CountryId = 2,
                            CountryName = "Norge"
                        },
                        new
                        {
                            CountryId = 3,
                            CountryName = "Danmark"
                        });
                });

            modelBuilder.Entity("MVCWebApp.Models.Language.Language", b =>
                {
                    b.Property<string>("LanguageName")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("LanguageName");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            LanguageName = "Franska"
                        },
                        new
                        {
                            LanguageName = "Polska"
                        },
                        new
                        {
                            LanguageName = "Italienska"
                        });
                });

            modelBuilder.Entity("MVCWebApp.Models.Person.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityForeignKey")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CityForeignKey");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CityForeignKey = 1,
                            Name = "Jens Jensson",
                            PhoneNumber = "123456789"
                        },
                        new
                        {
                            ID = 2,
                            CityForeignKey = 2,
                            Name = "Anna Andersson",
                            PhoneNumber = "987654321"
                        },
                        new
                        {
                            ID = 3,
                            CityForeignKey = 3,
                            Name = "Sven Svensson",
                            PhoneNumber = "123123123"
                        });
                });

            modelBuilder.Entity("MVCWebApp.Models.PersonLanguage", b =>
                {
                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("LanguageName")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("PersonId", "LanguageName");

                    b.HasIndex("LanguageName");

                    b.ToTable("PersonLanguages");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            LanguageName = "Franska"
                        },
                        new
                        {
                            PersonId = 2,
                            LanguageName = "Polska"
                        },
                        new
                        {
                            PersonId = 3,
                            LanguageName = "Italienska"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "7b21057d-3999-4d47-a281-233a9c4155d6",
                            ConcurrencyStamp = "3d7edfe8-3021-41b4-b135-451928fb26fc",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "b795e532-093c-4fcb-90dd-ac29a82ad936",
                            ConcurrencyStamp = "ae4edce5-5e92-45e3-8bed-3be633c8b90a",
                            Name = "user",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "e4a6506e-9f29-4d05-8f44-93f3fa2c7ffa",
                            RoleId = "7b21057d-3999-4d47-a281-233a9c4155d6"
                        },
                        new
                        {
                            UserId = "beb5a905-8645-41b8-86f7-7de855713270",
                            RoleId = "b795e532-093c-4fcb-90dd-ac29a82ad936"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MVCWebApp.Models.City.City", b =>
                {
                    b.HasOne("MVCWebApp.Models.Country.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVCWebApp.Models.Person.Person", b =>
                {
                    b.HasOne("MVCWebApp.Models.City.City", "City")
                        .WithMany("People")
                        .HasForeignKey("CityForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVCWebApp.Models.PersonLanguage", b =>
                {
                    b.HasOne("MVCWebApp.Models.Language.Language", "Language")
                        .WithMany("PersonLanguages")
                        .HasForeignKey("LanguageName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCWebApp.Models.Person.Person", "Person")
                        .WithMany("PersonLanguages")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MVCWebApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MVCWebApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCWebApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MVCWebApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}