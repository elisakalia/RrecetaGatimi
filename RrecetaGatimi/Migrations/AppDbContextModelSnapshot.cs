﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RrecetaGatimi.Data;

#nullable disable

namespace RrecetaGatimi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("RrecetaGatimi.Data.Model.Receta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Autori")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataPublikimit")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailiAutorit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pershkrimi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulli")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Receta");
                });
#pragma warning restore 612, 618
        }
    }
}