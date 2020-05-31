using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DO_AN_1_TEST01.Models
{
    public class PhanHoi
    {
        [Key]
        public int PhanHoiId { get; set; }
        public string NoiDung { get; set; }
        [ForeignKey("Users_model")]
        public int UsersId { get; set; }
        public Users_model Users_Model { get; set; }
    }
}