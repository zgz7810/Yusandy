using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;


namespace YusandyShoppingCar.Models
{

    //下拉式選單模組
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

   


    public class ChineseFoodCarrige
    {
        public int Id { get; set; }

        [DisplayName("產品編號")]
        public string PId { get; set; }

        [DisplayName("產品名稱")]
        public string Name { get; set; }

        [DisplayName("產品價格")]
        public int Price { get; set; }

        [DisplayName("產品種類")]
        public string Kind { get; set; }

        [DisplayName("產品圖示")]
        public string Img { get; set; }
    }
   

 }