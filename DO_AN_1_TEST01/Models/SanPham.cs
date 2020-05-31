using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DO_AN_1_TEST01.Models
{
    public class SanPham
    {
        public int SanPhamId  { get; set; }
        public string TenSanPham { get; set; }
        public float GiaSanPham { get; set; }
        public string Image { get; set; }
        public string MoTa { get; set; }
        public int NhaCungCapId { get; set; }
        public int LoaiId { get; set; }
        public NhaCungCap NhaCungCap { get; set; }
        public LoaiSanPham LoaiSanPham { get; set; }
    }
}