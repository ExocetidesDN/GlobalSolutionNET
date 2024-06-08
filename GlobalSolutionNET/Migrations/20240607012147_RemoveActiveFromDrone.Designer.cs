﻿// <auto-generated />
using System;
using GlobalSolutionNET.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace GlobalSolutionNET.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240607012147_RemoveActiveFromDrone")]
    partial class RemoveActiveFromDrone
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GlobalSolutionNET.Models.Entities.Drone", b =>
                {
                    b.Property<int>("DroneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DroneId"));

                    b.Property<int>("LicenseID")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<int>("OperatorId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("DroneId");

                    b.HasIndex("OperatorId");

                    b.ToTable("Drones");
                });

            modelBuilder.Entity("GlobalSolutionNET.Models.Entities.DroneMission", b =>
                {
                    b.Property<int>("DroneId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("MissionId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("DroneId", "MissionId");

                    b.HasIndex("MissionId");

                    b.ToTable("DroneMissions");
                });

            modelBuilder.Entity("GlobalSolutionNET.Models.Entities.FlightLicense", b =>
                {
                    b.Property<int>("LicenseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LicenseId"));

                    b.Property<int>("DroneId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("IssuedDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.HasKey("LicenseId");

                    b.HasIndex("DroneId")
                        .IsUnique();

                    b.ToTable("FlightLicenses");
                });

            modelBuilder.Entity("GlobalSolutionNET.Models.Entities.Mission", b =>
                {
                    b.Property<int>("MissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MissionId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("MissionId");

                    b.ToTable("Missions");
                });

            modelBuilder.Entity("GlobalSolutionNET.Models.Entities.Operator", b =>
                {
                    b.Property<int>("OperatorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OperatorId"));

                    b.Property<string>("Certificantion")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.HasKey("OperatorId");

                    b.ToTable("Operators");
                });

            modelBuilder.Entity("GlobalSolutionNET.Models.Entities.Drone", b =>
                {
                    b.HasOne("GlobalSolutionNET.Models.Entities.Operator", "Operator")
                        .WithMany("Drones")
                        .HasForeignKey("OperatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Operator");
                });

            modelBuilder.Entity("GlobalSolutionNET.Models.Entities.DroneMission", b =>
                {
                    b.HasOne("GlobalSolutionNET.Models.Entities.Drone", "Drone")
                        .WithMany("DroneMissions")
                        .HasForeignKey("DroneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GlobalSolutionNET.Models.Entities.Mission", "Mission")
                        .WithMany("DroneMissions")
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drone");

                    b.Navigation("Mission");
                });

            modelBuilder.Entity("GlobalSolutionNET.Models.Entities.FlightLicense", b =>
                {
                    b.HasOne("GlobalSolutionNET.Models.Entities.Drone", "Drone")
                        .WithOne("FlightLicense")
                        .HasForeignKey("GlobalSolutionNET.Models.Entities.FlightLicense", "DroneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drone");
                });

            modelBuilder.Entity("GlobalSolutionNET.Models.Entities.Drone", b =>
                {
                    b.Navigation("DroneMissions");

                    b.Navigation("FlightLicense")
                        .IsRequired();
                });

            modelBuilder.Entity("GlobalSolutionNET.Models.Entities.Mission", b =>
                {
                    b.Navigation("DroneMissions");
                });

            modelBuilder.Entity("GlobalSolutionNET.Models.Entities.Operator", b =>
                {
                    b.Navigation("Drones");
                });
#pragma warning restore 612, 618
        }
    }
}
