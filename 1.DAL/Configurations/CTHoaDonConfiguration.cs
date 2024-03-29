﻿using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configurations
{
    internal class CTHoaDonConfiguration : IEntityTypeConfiguration<ChiTietHoaDon>
    {
        public void Configure(EntityTypeBuilder<ChiTietHoaDon> builder)
        {
            builder.ToTable("ChiTietHoaDon");
            builder.HasKey(c => c.IdCTHoaDon);
            builder.Property(x => x.IdChiTietSP).IsRequired();
            builder.Property(x => x.IdHoaDon).IsRequired();
            builder.Property(c => c.DonGia).HasColumnName("DonGia").HasColumnType("decimal");
            builder.Property(c => c.SoLuongMua).HasColumnName("SoLuongMua").HasColumnType("decimal");
            builder.HasOne(c => c.ChiTietSanPham).WithMany().HasForeignKey(c => c.IdChiTietSP);
            builder.HasOne(c => c.HoaDon).WithMany().HasForeignKey(c => c.IdHoaDon);
        }
    }
}
