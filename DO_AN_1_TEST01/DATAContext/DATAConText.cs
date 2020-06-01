using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DO_AN_1_TEST01.Models;
using System.Data.Entity;


namespace DO_AN_1_TEST01.DATAContext
{
    public class DATAConText: DbContext
    {
        public DATAConText() : base("name=DataContext") { }
        
        public DbSet<Users_model> Users_Models { get; set; }
        public DbSet<SanPham> sanPhams { get; set; }
        public DbSet<KhachHang> khachHangs { get; set; }
        public DbSet<LoaiSanPham> loaiSanPhams { get; set; }
        public DbSet<PhanHoi> phanHois { get; set; }
        public DbSet<NhaCungCap> nhaCungCaps { get; set; }
        public DbSet<GioHang> gioHangs { get; set; }
        public DbSet<DonHang> donHangs { get; set; }
        public DbSet<ChiTietGioHang> chiTietGioHangs { get; set; }
    }
}