﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace DO_AN_1_TEST01.Models
{
    public class LoaiSanPham
    {
        [Key]
        public int LoaiId { get; set; }
        public string TenLoai { get; set; }
        public int SoLuong { get; set; } 
    }
}