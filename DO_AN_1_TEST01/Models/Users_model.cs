using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DO_AN_1_TEST01.Models
{
    public class Users_model
    {
        public int UsersId { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int rules { get; set; }//phân quyền
        public int status { get; set; }//1.hoạt động, 2. không hoạt động
    }
}