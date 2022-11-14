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

            modelBuilder.Entity("_1.DAL.Models.ChiTietGioHang", b =>
                {
                    b.Property<Guid>("IdGioHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DonGia")
                        .HasColumnType("decimal")
                        .HasColumnName("DonGia");

                    b.Property<Guid>("IdChiTietSp")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuongMua")
                        .HasColumnType("int")
                        .HasColumnName("SoLuongMua");

                    b.HasKey("IdGioHang");

                    b.HasIndex("IdChiTietSp");

                    b.ToTable("ChiTietGioHang");
                });

            modelBuilder.Entity("_1.DAL.Models.ChiTietHoaDon", b =>
                {
                    b.Property<Guid>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DonGia")
                        .HasColumnType("decimal")
                        .HasColumnName("DonGia");

                    b.Property<Guid>("IdChiTietSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuongMua")
                        .HasColumnType("int")
                        .HasColumnName("SoLuongMua");

                    b.HasKey("IdHoaDon");

                    b.HasIndex("IdChiTietSP");

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

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdDanhMuc")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdLoaiSp")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNhaCungCap")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSp")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int")
                        .HasColumnName("SoLuong");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Ten");

                    b.HasKey("IdChiTietSP");

                    b.HasIndex("IdDanhMuc");

                    b.HasIndex("IdLoaiSp");

                    b.HasIndex("IdNhaCungCap");

                    b.HasIndex("IdSp");

                    b.ToTable("ChiTietSanPham");
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

                    b.ToTable("DanhMucs");
                });

            modelBuilder.Entity("_1.DAL.Models.GioHang", b =>
                {
                    b.Property<Guid>("IdGioHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayMuaHang")
                        .HasColumnType("datetime")
                        .HasColumnName("NgayMuaHang");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("datetime")
                        .HasColumnName("NgayThanhToan");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.HasKey("IdGioHang");

                    b.HasIndex("IdKhachHang");

                    b.ToTable("GioHang");
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

                    b.Property<DateTime>("NgayNhan")
                        .HasColumnType("datetime")
                        .HasColumnName("NgayNhan");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("datetime")
                        .HasColumnName("NgayThanhToan");

                    b.Property<Guid?>("NhanVienIdNhanVien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal")
                        .HasColumnName("TongTien");

                    b.HasKey("IdHoaDon");

                    b.HasIndex("IdKhachHang");

                    b.HasIndex("NhanVienIdNhanVien");

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

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Email");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("SDT");

                    b.Property<string>("TenKh")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenKhachHang");

                    b.HasKey("IdKhachHang");

                    b.HasIndex("Email");

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

                    b.ToTable("LoaiSp");
                });

            modelBuilder.Entity("_1.DAL.Models.LoaiTK", b =>
                {
                    b.Property<Guid>("IdLoaiTK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoaiTk")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TenLoaiTK");

                    b.HasKey("IdLoaiTK");

                    b.ToTable("LoaiTK");
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

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int")
                        .HasColumnName("GioiTinh");

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

                    b.HasKey("IdNhanVien");

                    b.HasIndex("Email");

                    b.ToTable("NhanVien");
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

            modelBuilder.Entity("_1.DAL.Models.TaiKhoan", b =>
                {
                    b.Property<string>("TenTaiKhoan")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TenTaiKhoan");

                    b.Property<Guid>("IdLoaiTk")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("MatKhau");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.Property<bool>("TrangThaiPass")
                        .HasColumnType("bit")
                        .HasColumnName("TrangThaiPass");

                    b.HasKey("TenTaiKhoan");

                    b.HasIndex("IdLoaiTk");

                    b.ToTable("TaiKhoan");
                });

            modelBuilder.Entity("_1.DAL.Models.ChiTietGioHang", b =>
                {
                    b.HasOne("_1.DAL.Models.ChiTietSanPham", "ChiTietSanPham")
                        .WithMany()
                        .HasForeignKey("IdChiTietSp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.GioHang", "GioHang")
                        .WithMany()
                        .HasForeignKey("IdGioHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChiTietSanPham");

                    b.Navigation("GioHang");
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

                    b.Navigation("LoaiSp");

                    b.Navigation("NhaCungCap");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("_1.DAL.Models.GioHang", b =>
                {
                    b.HasOne("_1.DAL.Models.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("IdKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");
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
                        .HasForeignKey("NhanVienIdNhanVien");

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("_1.DAL.Models.KhachHang", b =>
                {
                    b.HasOne("_1.DAL.Models.TaiKhoan", "TaiKhoan")
                        .WithMany()
                        .HasForeignKey("Email")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaiKhoan");
                });

            modelBuilder.Entity("_1.DAL.Models.NhanVien", b =>
                {
                    b.HasOne("_1.DAL.Models.TaiKhoan", "TaiKhoan")
                        .WithMany()
                        .HasForeignKey("Email")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaiKhoan");
                });

            modelBuilder.Entity("_1.DAL.Models.TaiKhoan", b =>
                {
                    b.HasOne("_1.DAL.Models.LoaiTK", "LoaiTK")
                        .WithMany()
                        .HasForeignKey("IdLoaiTk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiTK");
                });
#pragma warning restore 612, 618
        }
    }
}
