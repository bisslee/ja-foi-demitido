﻿// <auto-generated />
using System;
using Biss.Fired.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Biss.Fired.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class MyAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Biss.Fired.Api.Models.Fired", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FiredAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("IP")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ValidadedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("WasFired")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Fired");
                });

            modelBuilder.Entity("Biss.Fired.Api.Models.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("EmailWarning")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("FiredId")
                        .HasColumnType("int");

                    b.Property<string>("IP")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<int?>("MediaTypeId")
                        .HasColumnType("int");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ValidadedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FiredId");

                    b.HasIndex("MediaTypeId");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("Biss.Fired.Api.Models.MediaType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MediaType");
                });

            modelBuilder.Entity("Biss.Fired.Api.Models.Media", b =>
                {
                    b.HasOne("Biss.Fired.Api.Models.Fired", "Fired")
                        .WithMany()
                        .HasForeignKey("FiredId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Biss.Fired.Api.Models.MediaType", "MediaType")
                        .WithMany()
                        .HasForeignKey("MediaTypeId");

                    b.Navigation("Fired");

                    b.Navigation("MediaType");
                });
#pragma warning restore 612, 618
        }
    }
}
