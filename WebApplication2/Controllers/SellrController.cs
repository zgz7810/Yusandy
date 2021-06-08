using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YusandyShoppingCar.Models;
using System.Web.Security;
using System.Data.SqlClient;



namespace YusandyShoppingCar.Controllers
{
    public class CarrigeController : Controller
    {
        

        public ActionResult Sell()
        {
           ///商品選擇頁面下拉式選單控制器
            List<Item> im = new List<Item>()
            {
                new Item() {Id = 1, Name="中式料理" },
                new Item() {Id = 2, Name="日式料理" },
                new Item() {Id = 3, Name="法式料理" },
                new Item() {Id = 3, Name="泰式料理" },
                new Item() {Id = 3, Name="加勒比海料理" },
                new Item() {Id = 3, Name="古早味美食" },
                new Item() {Id = 3, Name="烘焙甜點" },
                new Item() {Id = 3, Name="減脂健身餐" },
            };
            
            ViewBag.Items = new SelectList(im, "Id", "Name");
            return View();
        }




        //中式料理控制器

        dbYusandyShoppingCarEntities db = new dbYusandyShoppingCarEntities();   //建立中式料理資料表"ChineseFoodCarrige"
       
        public ActionResult CF()
        {
            var cfcarrige = db.Name.OrderByDescending(m => m.fId).ToList();  //將"ChineseFoodCarrige"資料表中的商品欄位"cfProduct"指派給變數" cfcarrige"
            return View(cfcarrige);

        }

    }
}