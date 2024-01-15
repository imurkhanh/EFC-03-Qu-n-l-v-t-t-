﻿// <auto-generated />
using System;
using EFC_03.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFC_03.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240114151213_v2")]
    partial class v2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFC_03.Entity.ChiTietPhieuNhap", b =>
                {
                    b.Property<int>("ChiTietPhieuNhapId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChiTietPhieuNhapId"));

                    b.Property<int>("PhieuNhapId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongNhap")
                        .HasColumnType("int");

                    b.Property<int>("VatTuId")
                        .HasColumnType("int");

                    b.HasKey("ChiTietPhieuNhapId");

                    b.HasIndex("PhieuNhapId");

                    b.HasIndex("VatTuId");

                    b.ToTable("ChiTietPhieuNhap");
                });

            modelBuilder.Entity("EFC_03.Entity.ChiTietPhieuXuat", b =>
                {
                    b.Property<int>("ChiTietPhieuXuatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChiTietPhieuXuatId"));

                    b.Property<int>("PhieuXuatId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongXuat")
                        .HasColumnType("int");

                    b.Property<int>("VatTuId")
                        .HasColumnType("int");

                    b.HasKey("ChiTietPhieuXuatId");

                    b.HasIndex("PhieuXuatId");

                    b.HasIndex("VatTuId");

                    b.ToTable("ChiTietPhieuXuat");
                });

            modelBuilder.Entity("EFC_03.Entity.PhieuNhap", b =>
                {
                    b.Property<int>("PhieuNhapId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhieuNhapId"));

                    b.Property<string>("MaPhieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayNhap")
                        .HasColumnType("datetime2");

                    b.Property<string>("TieuDe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhieuNhapId");

                    b.ToTable("PhieuNhap");
                });

            modelBuilder.Entity("EFC_03.Entity.PhieuXuat", b =>
                {
                    b.Property<int>("PhieuXuatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhieuXuatId"));

                    b.Property<string>("MaPhieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayXuat")
                        .HasColumnType("datetime2");

                    b.Property<string>("TieuDe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhieuXuatId");

                    b.ToTable("PhieuXuat");
                });

            modelBuilder.Entity("EFC_03.Entity.VatTu", b =>
                {
                    b.Property<int>("VatTuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VatTuId"));

                    b.Property<int>("SoLuongTon")
                        .HasColumnType("int");

                    b.Property<string>("TenVatTu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VatTuId");

                    b.ToTable("VatTu");
                });

            modelBuilder.Entity("EFC_03.Entity.ChiTietPhieuNhap", b =>
                {
                    b.HasOne("EFC_03.Entity.PhieuNhap", "PhieuNhap")
                        .WithMany()
                        .HasForeignKey("PhieuNhapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFC_03.Entity.VatTu", "VatTu")
                        .WithMany()
                        .HasForeignKey("VatTuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhieuNhap");

                    b.Navigation("VatTu");
                });

            modelBuilder.Entity("EFC_03.Entity.ChiTietPhieuXuat", b =>
                {
                    b.HasOne("EFC_03.Entity.PhieuXuat", "PhieuXuat")
                        .WithMany()
                        .HasForeignKey("PhieuXuatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFC_03.Entity.VatTu", "VatTu")
                        .WithMany()
                        .HasForeignKey("VatTuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhieuXuat");

                    b.Navigation("VatTu");
                });
#pragma warning restore 612, 618
        }
    }
}
