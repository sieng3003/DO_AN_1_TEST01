using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DO_AN_1_TEST01.Models
{
    public class ChiTietGioHang
    {
        public int CTGioHangId { get; set; }
        public float PhiGiaoDich { get; set; }
        public float ThanhTien { get; set; }
        public int GioHangId { get; set; }
        public int UsersId { get; set; }
        public int SanPhamId { get; set; }
        public GioHang GioHang { get; set; }
        public Users_model Users_Model { get; set; }
        public SanPham SanPham { get; set; }
    }
}