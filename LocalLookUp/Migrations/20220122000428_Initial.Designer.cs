﻿// <auto-generated />
using LocalLookUp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalLookUp.Migrations
{
    [DbContext(typeof(LocalLookUpContext))]
    [Migration("20220122000428_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("LocalLookUp.Models.Town", b =>
                {
                    b.Property<int>("TownId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Restaurant")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Shop")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("TownId");

                    b.ToTable("Towns");
                });
#pragma warning restore 612, 618
        }
    }
}
