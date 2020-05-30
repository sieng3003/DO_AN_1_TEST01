using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DO_AN_1_TEST01.Models
{
    public class DonHang
    {
        public int DonHangId { get; set; }
        public DateTime Ngay { get; set; }
        public float PhiGiaoDich { get; set; }
        public float TongTien { get; set; }
        public string GhiChu { get; set; }
        public int KhachHangId { get; set; }
        public KhachHang KhachHang { get; set; }
    }
}