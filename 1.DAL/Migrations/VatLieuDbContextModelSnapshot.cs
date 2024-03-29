﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL.Models;

namespace _1.DAL.Migrations
{
    [DbContext(typeof(VatLieuDbContext))]
    partial class VatLieuDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_1.DAL.Models.ChiTietHoaDon", b =>
                {
                    b.Property<Guid>("IdCTHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DonGia")
                        .HasColumnType("decimal")
                        .HasColumnName("DonGia");

                    b.Property<Guid>("IdChiTietSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("SoLuongMua")
                        .HasColumnType("decimal")
                        .HasColumnName("SoLuongMua");

                    b.HasKey("IdCTHoaDon");

                    b.HasIndex("IdChiTietSP");

                    b.HasIndex("IdHoaDon");

                    b.ToTable("ChiTietHoaDon");
                });

            modelBuilder.Entity("_1.DAL.Models.ChiTietSanPham", b =>
                {
                    b.Property<Guid>("IdChiTietSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal")
                        .HasColumnName("GiaBan");

                    b.Property<decimal>("GiaNhap")
                        .HasColumnType("decimal")
                        .HasColumnName("GiaNhap");

                    b.Property<byte[]>("HinhAnh")
                        .HasColumnType("image")
                        .HasColumnName("HinhAnh");

                    b.Property<Guid>("IdDanhMuc")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdDonVi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdLoaiSp")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNhaCungCap")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSp")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("SoLuong")
                        .HasColumnType("decimal")
                        .HasColumnName("SoLuong");

                    b.HasKey("IdChiTietSP");

                    b.HasIndex("IdDanhMuc");

                    b.HasIndex("IdDonVi");

                    b.HasIndex("IdLoaiSp");

                    b.HasIndex("IdNhaCungCap");

                    b.HasIndex("IdSp");

                    b.ToTable("ChiTietSP");
                });

            modelBuilder.Entity("_1.DAL.Models.DanhMuc", b =>
                {
                    b.Property<Guid>("IdDanhMuc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenDanhMuc")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenDanhMuc");

                    b.HasKey("IdDanhMuc");

                    b.ToTable("DanhMuc");
                });

            modelBuilder.Entity("_1.DAL.Models.DonVi", b =>
                {
                    b.Property<Guid>("IdDonVi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenDonVi")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TenDonVi");

                    b.HasKey("IdDonVi");

                    b.ToTable("DonVi");
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDon", b =>
                {
                    b.Property<Guid>("IdHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNhanVien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime")
                        .HasColumnName("NgayTao");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("datetime")
                        .HasColumnName("NgayThanhToan");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal")
                        .HasColumnName("TongTien");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.HasKey("IdHoaDon");

                    b.HasIndex("IdKhachHang");

                    b.HasIndex("IdNhanVien");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("_1.DAL.Models.KhachHang", b =>
                {
                    b.Property<Guid>("IdKhachHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ĐiaChi");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int")
                        .HasColumnName("GioiTinh");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("SDT");

                    b.Property<string>("TenKh")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenKhachHang");

                    b.HasKey("IdKhachHang");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("_1.DAL.Models.LoaiSp", b =>
                {
                    b.Property<Guid>("IdLoaiSp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenLoaiSp")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenLoaiSp");

                    b.HasKey("IdLoaiSp");

                    b.ToTable("LoaiSanPham");
                });

            modelBuilder.Entity("_1.DAL.Models.NhaCungCap", b =>
                {
                    b.Property<Guid>("IdNhaCungCap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenNhaCungCap")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenNhaCC");

                    b.HasKey("IdNhaCungCap");

                    b.ToTable("NhaCungCap");
                });

            modelBuilder.Entity("_1.DAL.Models.NhanVien", b =>
                {
                    b.Property<Guid>("IdNhanVien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ĐiaChi");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Email");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("bit")
                        .HasColumnName("GioiTinh");

                    b.Property<bool>("IdLoaiTk")
                        .HasColumnType("bit")
                        .HasColumnName("IdLoaiTk");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("MatKhau");

                    b.Property<DateTime>("NamSinh")
                        .HasColumnType("datetime")
                        .HasColumnName("NamSinh");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("SĐT");

                    b.Property<string>("TenNv")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenNhanVien");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit")
                        .HasColumnName("TrangThaiTK");

                    b.Property<bool>("TrangThaiPass")
                        .HasColumnType("bit")
                        .HasColumnName("TrangThaiPass");

                    b.HasKey("IdNhanVien");

                    b.ToTable("NhanVien");

                    b.HasData(
                        new
                        {
                            IdNhanVien = new Guid("1ab623c4-9afc-4f78-bddd-fe7d01862113"),
                            DiaChi = "ninh bình",
                            Email = "1",
                            GioiTinh = true,
                            IdLoaiTk = true,
                            MatKhau = "1",
                            NamSinh = new DateTime(2003, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SDT = "1",
                            TenNv = "1",
                            TrangThai = true,
                            TrangThaiPass = true
                        });
                });

            modelBuilder.Entity("_1.DAL.Models.SanPham", b =>
                {
                    b.Property<Guid>("IdSp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenSp")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenSanPham");

                    b.HasKey("IdSp");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("_1.DAL.Models.ChiTietHoaDon", b =>
                {
                    b.HasOne("_1.DAL.Models.ChiTietSanPham", "ChiTietSanPham")
                        .WithMany()
                        .HasForeignKey("IdChiTietSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.HoaDon", "HoaDon")
                        .WithMany()
                        .HasForeignKey("IdHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChiTietSanPham");

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("_1.DAL.Models.ChiTietSanPham", b =>
                {
                    b.HasOne("_1.DAL.Models.DanhMuc", "DanhMuc")
                        .WithMany()
                        .HasForeignKey("IdDanhMuc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.DonVi", "DonVi")
                        .WithMany()
                        .HasForeignKey("IdDonVi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.LoaiSp", "LoaiSp")
                        .WithMany()
                        .HasForeignKey("IdLoaiSp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.NhaCungCap", "NhaCungCap")
                        .WithMany()
                        .HasForeignKey("IdNhaCungCap")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("IdSp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DanhMuc");

                    b.Navigation("DonVi");

                    b.Navigation("LoaiSp");

                    b.Navigation("NhaCungCap");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDon", b =>
                {
                    b.HasOne("_1.DAL.Models.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("IdKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("IdNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });
#pragma warning restore 612, 618
        }
    }
}
