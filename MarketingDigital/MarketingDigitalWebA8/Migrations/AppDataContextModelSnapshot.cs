﻿// <auto-generated />
using System;
using MarketingDigitalWebA8.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MarketingDigitalWebA8.Migrations
{
    [DbContext(typeof(AppDataContext))]
    partial class AppDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MarketingDigitalWebA8.Models.DbModels.EmpresaCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.ToTable("EmpresaCliente");
                });
#pragma warning restore 612, 618
        }
    }
}