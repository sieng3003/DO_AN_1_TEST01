using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using DO_AN_1_TEST01.Models;

namespace DO_AN_1_TEST01.Models
{
    public class ChiTietGioHang
    {
        [Key]
        public int CTGioHangId { get; set; }
        public float PhiGiaoDich { get; set; }
        public float ThanhTien { get; set; }
        [ForeignKey("GioHang")]
        public int? GioHangId { get; set; }
        public GioHang GioHang { get; set; }
        //[ForeignKey("Users_model")]
        //public int? UsersId { get; set; }
        //public Users_model Users_Model { get; set; }
        [ForeignKey("SanPham")]
        public int? SanPhamId { get; set; }
        public SanPham SanPham { get; set; }
    }
}