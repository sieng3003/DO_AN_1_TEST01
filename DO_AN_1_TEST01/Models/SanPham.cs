using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DO_AN_1_TEST01.Models
{
    public class SanPham
    {
        [Key]
        public int SanPhamId  { get; set; }
        public string TenSanPham { get; set; }
        public float GiaSanPham { get; set; }
        public string Image { get; set; }
        public string MoTa { get; set; }
        [ForeignKey("NhaCungCap")]
        public int? NhaCungCapId { get; set; }
        public NhaCungCap NhaCungCap { get; set; }
        [ForeignKey("LoaiSanPham")]
        public int? LoaiId { get; set; }
        public LoaiSanPham LoaiSanPham { get; set; }
    }
}