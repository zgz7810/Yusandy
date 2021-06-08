using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YusandyCarrige.Models;

namespace WebApplication2.Views.Home
{
    public class testController : Controller
    {
        // GET: test
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Id = "Cf", Name = "玉囊鎖鮮露(5入)", Price = 100 });
            return View(products);
        }
    }
}