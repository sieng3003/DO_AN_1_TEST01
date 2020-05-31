using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DO_AN_1_TEST01.Models
{
    public class GioHang
    {
        [Key]
        public int GioHangId { get; set; }
        public float TongTien { get; set; }
        
    }
}