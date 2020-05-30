using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DO_AN_1_TEST01.Models
{
    public class KhachHang
    {
        public int KhachHangId {get;set;}
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }

    }
}