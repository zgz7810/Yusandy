using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace YusandySigin.Models
{
    public partial class Member
    {
        public int Id { get; set; }

       
        [DisplayName("帳號")]
        [Required]
        public string UserId { get; set; }

        [DisplayName("密碼")]
        [Required]
        public string Pwd { get; set; }

        [DisplayName("姓名")]
        [Required]
        public string Name { get; set; }

        [DisplayName("地址")]
        [Required]
        public string Address { get; set; }

        [DisplayName("信箱")]
        [Required]
        public string Mail { get; set; }

        [DisplayName("電話")]
        [Required]
        public string Phone { get; set; }

    }
}