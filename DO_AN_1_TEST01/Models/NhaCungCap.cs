using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DO_AN_1_TEST01.Models
{
    public class NhaCungCap
    {
        [Key]
        public int NhaCungCapId { get; set; }
        public string TenNhanCungCap { get; set; }
        public string Diachi { get; set; }
        public string Sdt { get; set; }
        
    }
}