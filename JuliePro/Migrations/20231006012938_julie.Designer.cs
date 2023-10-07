﻿// <auto-generated />
using System;
using JuliePro.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JuliePro.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231006012938_julie")]
    partial class julie
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JuliePro.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<double>("StartWeight")
                        .HasColumnType("float");

                    b.Property<int>("TrainerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(2009, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Felixun.trudeau@juliePro.ca",
                            FirstName = "FélixUn",
                            LastName = "TrudeauUn",
                            StartWeight = 100.0,
                            TrainerId = 1
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(2008, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Felixdeux.trudeau@juliePro.ca",
                            FirstName = "FélixDeux",
                            LastName = "TrudeauDeux",
                            StartWeight = 200.0,
                            TrainerId = 1
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(2007, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Felixtrois.trudeau@juliePro.ca",
                            FirstName = "FélixTrois",
                            LastName = "TrudeauTrois",
                            StartWeight = 300.0,
                            TrainerId = 1
                        });
                });

            modelBuilder.Entity("JuliePro.Models.Objective", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("AchievedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<double>("DistanceKm")
                        .HasColumnType("float");

                    b.Property<double>("LostWeightKg")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Objectives");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            DistanceKm = 2.0,
                            LostWeightKg = 2.0,
                            Name = "Objective1"
                        },
                        new
                        {
                            Id = 2,
                            AchievedDate = new DateTime(2020, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerId = 1,
                            DistanceKm = 3.0,
                            LostWeightKg = 3.0,
                            Name = "Objective2"
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 2,
                            DistanceKm = 4.0,
                            LostWeightKg = 4.0,
                            Name = "Objective3"
                        },
                        new
                        {
                            Id = 4,
                            CustomerId = 2,
                            DistanceKm = 5.0,
                            LostWeightKg = 5.0,
                            Name = "Objective4"
                        },
                        new
                        {
                            Id = 5,
                            AchievedDate = new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerId = 3,
                            DistanceKm = 6.0,
                            LostWeightKg = 6.0,
                            Name = "Objective5"
                        },
                        new
                        {
                            Id = 6,
                            AchievedDate = new DateTime(2022, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerId = 3,
                            DistanceKm = 7.0,
                            LostWeightKg = 7.0,
                            Name = "Objective6"
                        });
                });

            modelBuilder.Entity("JuliePro.Models.Speciality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Specialities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Perte de poids"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Course"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Halthérophilie"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Réhabilitation"
                        });
                });

            modelBuilder.Entity("JuliePro.Models.Trainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("SpecialityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SpecialityId");

                    b.ToTable("Trainers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Chrystal.lapierre@juliepro.ca",
                            FirstName = "Chrystal",
                            LastName = "Lapierre",
                            Photo = "Chrystal.png",
                            SpecialityId = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "Felix.trudeau@juliePro.ca",
                            FirstName = "Félix",
                            LastName = "Trudeau",
                            Photo = "Felix.png",
                            SpecialityId = 2
                        },
                        new
                        {
                            Id = 3,
                            Email = "Frank.StJohn@juliepro.ca",
                            FirstName = "François",
                            LastName = "Saint-John",
                            Photo = "Francois.png",
                            SpecialityId = 1
                        },
                        new
                        {
                            Id = 4,
                            Email = "JC.Bastien@juliepro.ca",
                            FirstName = "Jean-Claude",
                            LastName = "Bastien",
                            Photo = "JeanClaude.png",
                            SpecialityId = 4
                        },
                        new
                        {
                            Id = 5,
                            Email = "JinLee.godette@juliepro.ca",
                            FirstName = "Jin Lee",
                            LastName = "Godette",
                            Photo = "Jin Lee.png",
                            SpecialityId = 3
                        },
                        new
                        {
                            Id = 6,
                            Email = "Karine.Lachance@juliepro.ca",
                            FirstName = "Karine",
                            LastName = "Lachance",
                            Photo = "Karine.png",
                            SpecialityId = 2
                        },
                        new
                        {
                            Id = 7,
                            Email = "Ramone.Esteban@juliepro.ca",
                            FirstName = "Ramone",
                            LastName = "Esteban",
                            Photo = "Ramone.png",
                            SpecialityId = 3
                        });
                });

            modelBuilder.Entity("JuliePro.Models.Objective", b =>
                {
                    b.HasOne("JuliePro.Models.Customer", "Customer")
                        .WithMany("Objectives")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("JuliePro.Models.Trainer", b =>
                {
                    b.HasOne("JuliePro.Models.Speciality", "Speciality")
                        .WithMany("Trainers")
                        .HasForeignKey("SpecialityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Speciality");
                });

            modelBuilder.Entity("JuliePro.Models.Customer", b =>
                {
                    b.Navigation("Objectives");
                });

            modelBuilder.Entity("JuliePro.Models.Speciality", b =>
                {
                    b.Navigation("Trainers");
                });
#pragma warning restore 612, 618
        }
    }
}
