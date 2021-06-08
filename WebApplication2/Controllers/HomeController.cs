using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yusandy.Models;

namespace Yusandy.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Kind> kinds = new List<Kind>(); //建立料理類別清單
            kinds.Add(new Kind { Id = "Cf",Name = "中式料理" });  //把"中式料理"加入清單
            kinds.Add(new Kind { Id = "Ff", Name = "法式料理" });  //把"法式料理"加入清單
            kinds.Add(new Kind { Id = "Jf", Name = "日式料理" });  //把"日式料理"加入清單
            kinds.Add(new Kind { Id = "Thf", Name = "泰式料理" });  //把"泰式料理"加入清單
            
            return View(kinds);  //顯示kinds清單
        }

        
    }
}