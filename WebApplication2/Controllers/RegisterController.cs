using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YusandyRegister.Models;

namespace WebApplication2.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Register register)
        {
            string msg = "";
            msg = $"您的資料是:<br>"
                + $"帳號:{register.User}"
                + $"密碼:{register.Pwd}"
                + $"姓名:{register.Name}"
                + $"地址:{register.Adr}"
                + $"電話:{register.Tel}"
                + $"信箱:{register.Mail}"
                + $"生日:{register.Bd.ToShortDateString()}";
            ViewBag.Msg = msg;
            return View(register);
        }
    }
}