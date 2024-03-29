﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Data;

namespace WebAPI.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI.Data.ChiTietHD", b =>
                {
                    b.Property<Guid>("MaHD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaHH")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DonGia")
                        .HasColumnType("int");

                    b.Property<byte>("GiamGia")
                        .HasColumnType("tinyint");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaHD", "MaHH");

                    b.HasIndex("MaHH");

                    b.ToTable("ChiTietHD");
                });

            modelBuilder.Entity("WebAPI.Data.HangHoa", b =>
                {
                    b.Property<Guid>("MaHH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DonGia")
                        .HasColumnType("int");

                    b.Property<byte>("GiamGia")
                        .HasColumnType("tinyint");

                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<string>("TenHH")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaHH");

                    b.HasIndex("Id");

                    b.ToTable("HangHoa");
                });

            modelBuilder.Entity("WebAPI.Data.HoaDon", b =>
                {
                    b.Property<Guid>("MaHD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChiNhanHang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayDat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<DateTime?>("NgayGiao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiNhan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SDT")
                        .HasColumnType("int");

                    b.Property<int>("TinhTrangHD")
                        .HasColumnType("int");

                    b.HasKey("MaHD");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("WebAPI.Data.Loai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Loai");
                });

            modelBuilder.Entity("WebAPI.Data.ChiTietHD", b =>
                {
                    b.HasOne("WebAPI.Data.HoaDon", "HoaDon")
                        .WithMany("chiTietHDs")
                        .HasForeignKey("MaHD")
                        .HasConstraintName("FK_CTHD_HoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Data.HangHoa", "HangHoa")
                        .WithMany("chiTietHDs")
                        .HasForeignKey("MaHH")
                        .HasConstraintName("FK_CTHD_HangHoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HangHoa");

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("WebAPI.Data.HangHoa", b =>
                {
                    b.HasOne("WebAPI.Data.Loai", "Loai")
                        .WithMany("HangHoas")
                        .HasForeignKey("Id");

                    b.Navigation("Loai");
                });

            modelBuilder.Entity("WebAPI.Data.HangHoa", b =>
                {
                    b.Navigation("chiTietHDs");
                });

            modelBuilder.Entity("WebAPI.Data.HoaDon", b =>
                {
                    b.Navigation("chiTietHDs");
                });

            modelBuilder.Entity("WebAPI.Data.Loai", b =>
                {
                    b.Navigation("HangHoas");
                });
#pragma warning restore 612, 618
        }
    }
}
