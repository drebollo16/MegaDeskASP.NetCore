﻿// <auto-generated />
using System;
using MegaDeskASP.NetCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MegaDeskASP.NetCore.Migrations
{
    [DbContext(typeof(MegaDeskASPNetCoreContext))]
    partial class MegaDeskASPNetCoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MegaDeskASP.NetCore.Models.Desk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryChoice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DeskDepth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DeskWidth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfDrawers")
                        .HasColumnType("int");

                    b.Property<DateTime>("QuoteDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("QuoteTotal")
                        .HasColumnType("real");

                    b.Property<string>("SurfaceMaterial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Desk");
                });
#pragma warning restore 612, 618
        }
    }
}
