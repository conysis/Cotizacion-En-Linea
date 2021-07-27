﻿// <auto-generated />
using System;
using CotizLicitAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CotizLicitAPI.Migrations
{
    [DbContext(typeof(LicitacionContext))]
    partial class LicitacionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CotizLicitAPI.Models.Licitacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Expediente")
                        .IsRequired()
                        .HasColumnType("nvarchar(9)");

                    b.Property<DateTime>("FecApertura")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FecCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdProveedor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Licitacions");
                });
#pragma warning restore 612, 618
        }
    }
}
