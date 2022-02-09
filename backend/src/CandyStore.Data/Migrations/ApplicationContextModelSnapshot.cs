﻿// <auto-generated />
using System;
using CandyStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CandyStore.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.14");

            modelBuilder.Entity("CandyStore.Domain.Product", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(20,2)");

                    b.HasKey("Id");

                    b.ToTable("TBPRODUCT");
                });
#pragma warning restore 612, 618
        }
    }
}
