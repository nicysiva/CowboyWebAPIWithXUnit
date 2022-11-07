﻿// <auto-generated />
using System;
using CowboyWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CowboyWebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CowboyWebAPI.Models.CowboyDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Created_By")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("Created_Date")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hair")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<decimal>("Latitude")
                        .HasPrecision(12, 9)
                        .HasColumnType("decimal(12,9)");

                    b.Property<decimal>("Longitude")
                        .HasPrecision(12, 9)
                        .HasColumnType("decimal(12,9)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Updated_By")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("Updated_Date")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("tbl_CowboyDetails");
                });

            modelBuilder.Entity("CowboyWebAPI.Models.CowboyGunBulletsMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BulletsLeft")
                        .HasColumnType("int");

                    b.Property<int>("Cowboy_Id")
                        .HasColumnType("int");

                    b.Property<int>("Gun_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Cowboy_Id");

                    b.HasIndex("Gun_Id");

                    b.ToTable("tbl_CowboyGunBulletsMapping");
                });

            modelBuilder.Entity("CowboyWebAPI.Models.GunDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("GunName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxNumberOfBullets")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("tbl_GunDetails");
                });

            modelBuilder.Entity("CowboyWebAPI.Models.CowboyGunBulletsMapping", b =>
                {
                    b.HasOne("CowboyWebAPI.Models.CowboyDetails", "Cowboy_Details")
                        .WithMany()
                        .HasForeignKey("Cowboy_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CowboyWebAPI.Models.GunDetails", "Gun_Details")
                        .WithMany()
                        .HasForeignKey("Gun_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cowboy_Details");

                    b.Navigation("Gun_Details");
                });
#pragma warning restore 612, 618
        }
    }
}
