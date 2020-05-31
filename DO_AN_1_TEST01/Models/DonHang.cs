using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DO_AN_1_TEST01.Models
{
    public class DonHang
    {
        [Key]
        public int DonHangId { get; set; }
        public DateTime Ngay { get; set; }
        public float PhiGiaoDich { get; set; }
        public float TongTien { get; set; }
        public string GhiChu { get; set; }
        [ForeignKey("KhachHang")]
        public int? KhachHangId { get; set; }
        public KhachHang KhachHang { get; set; }
    }
}