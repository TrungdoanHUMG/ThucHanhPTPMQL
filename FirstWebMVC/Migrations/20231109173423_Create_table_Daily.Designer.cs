﻿// <auto-generated />
using FirstWebMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirstWebMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231109173423_Create_table_Daily")]
    partial class Create_table_Daily
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("FirstWebMVC.Models.Daily", b =>
                {
                    b.Property<string>("MaDaiLy")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DienThoai")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MaHTPP")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NguoiDaiDien")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenDaiLy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaDaiLy");

                    b.ToTable("Daily");
                });

            modelBuilder.Entity("FirstWebMVC.Models.Employee", b =>
                {
                    b.Property<string>("fname")
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("fname");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("FirstWebMVC.Models.Person", b =>
                {
                    b.Property<string>("fname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("fname");

                    b.ToTable("Persons");
                });
#pragma warning restore 612, 618
        }
    }
}
