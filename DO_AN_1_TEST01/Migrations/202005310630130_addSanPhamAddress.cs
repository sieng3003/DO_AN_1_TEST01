namespace DO_AN_1_TEST01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSanPhamAddress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietGioHangs",
                c => new
                    {
                        CTGioHangId = c.Int(nullable: false, identity: true),
                        PhiGiaoDich = c.Single(nullable: false),
                        ThanhTien = c.Single(nullable: false),
                        GioHangId = c.Int(),
                        SanPhamId = c.Int(),
                    })
                .PrimaryKey(t => t.CTGioHangId)
                .ForeignKey("dbo.GioHangs", t => t.GioHangId)
                .ForeignKey("dbo.SanPhams", t => t.SanPhamId)
                .Index(t => t.GioHangId)
                .Index(t => t.SanPhamId);
            
            CreateTable(
                "dbo.GioHangs",
                c => new
                    {
                        GioHangId = c.Int(nullable: false, identity: true),
                        TongTien = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.GioHangId);
            
            CreateTable(
                "dbo.SanPhams",
                c => new
                    {
                        SanPhamId = c.Int(nullable: false, identity: true),
                        TenSanPham = c.String(),
                        GiaSanPham = c.Single(nullable: false),
                        Image = c.String(),
                        MoTa = c.String(),
                        NhaCungCapId = c.Int(),
                        LoaiId = c.Int(),
                    })
                .PrimaryKey(t => t.SanPhamId)
                .ForeignKey("dbo.LoaiSanPhams", t => t.LoaiId)
                .ForeignKey("dbo.NhaCungCaps", t => t.NhaCungCapId)
                .Index(t => t.NhaCungCapId)
                .Index(t => t.LoaiId);
            
            CreateTable(
                "dbo.LoaiSanPhams",
                c => new
                    {
                        LoaiId = c.Int(nullable: false, identity: true),
                        TenLoai = c.String(),
                        SoLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LoaiId);
            
            CreateTable(
                "dbo.NhaCungCaps",
                c => new
                    {
                        NhaCungCapId = c.Int(nullable: false, identity: true),
                        TenNhanCungCap = c.String(),
                        Diachi = c.String(),
                        Sdt = c.String(),
                    })
                .PrimaryKey(t => t.NhaCungCapId);
            
            CreateTable(
                "dbo.DonHangs",
                c => new
                    {
                        DonHangId = c.Int(nullable: false, identity: true),
                        Ngay = c.DateTime(nullable: false),
                        PhiGiaoDich = c.Single(nullable: false),
                        TongTien = c.Single(nullable: false),
                        GhiChu = c.String(),
                        KhachHangId = c.Int(),
                    })
                .PrimaryKey(t => t.DonHangId)
                .ForeignKey("dbo.KhachHangs", t => t.KhachHangId)
                .Index(t => t.KhachHangId);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        KhachHangId = c.Int(nullable: false, identity: true),
                        TenKhachHang = c.String(),
                        DiaChi = c.String(),
                        Sdt = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.KhachHangId);
            
            CreateTable(
                "dbo.PhanHois",
                c => new
                    {
                        PhanHoiId = c.Int(nullable: false, identity: true),
                        NoiDung = c.String(),
                    })
                .PrimaryKey(t => t.PhanHoiId);
            
            CreateTable(
                "dbo.Users_model",
                c => new
                    {
                        UsersId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        PassWord = c.String(),
                        rules = c.Int(nullable: false),
                        status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UsersId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DonHangs", "KhachHangId", "dbo.KhachHangs");
            DropForeignKey("dbo.ChiTietGioHangs", "SanPhamId", "dbo.SanPhams");
            DropForeignKey("dbo.SanPhams", "NhaCungCapId", "dbo.NhaCungCaps");
            DropForeignKey("dbo.SanPhams", "LoaiId", "dbo.LoaiSanPhams");
            DropForeignKey("dbo.ChiTietGioHangs", "GioHangId", "dbo.GioHangs");
            DropIndex("dbo.DonHangs", new[] { "KhachHangId" });
            DropIndex("dbo.SanPhams", new[] { "LoaiId" });
            DropIndex("dbo.SanPhams", new[] { "NhaCungCapId" });
            DropIndex("dbo.ChiTietGioHangs", new[] { "SanPhamId" });
            DropIndex("dbo.ChiTietGioHangs", new[] { "GioHangId" });
            DropTable("dbo.Users_model");
            DropTable("dbo.PhanHois");
            DropTable("dbo.KhachHangs");
            DropTable("dbo.DonHangs");
            DropTable("dbo.NhaCungCaps");
            DropTable("dbo.LoaiSanPhams");
            DropTable("dbo.SanPhams");
            DropTable("dbo.GioHangs");
            DropTable("dbo.ChiTietGioHangs");
        }
    }
}
