using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YusandyRegister.Models
{
    public class Register
    {
        public string User { get; set; }  //帳號屬性
        public string Pwd { get; set; }  //密碼屬性
        public string Name { get; set; }  //姓名屬性
        public string Adr { get; set; }  //地址屬性
        public string Tel { get; set; }  //電話屬性
        public string Mail { get; set; }  //信箱屬性
        public DateTime Bd { get; set; }  //生日屬性
    }
}