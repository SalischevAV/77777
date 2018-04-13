using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class NameController : Controller
    {
        private string name;

        public string Method
        {
            get { return HttpContext.Request.HttpMethod; }
        }


        [HttpGet]
        public ActionResult Index()
        {
            name = "привет, Аноним!";
            ViewBag.Name = name;
            ViewBag.Method = Method;
            return View();
        }

        [HttpPost]
        public ActionResult Index(string sameName)
        {
            if (String.IsNullOrEmpty(sameName))
                name = "Введите имя!";
            else
                name = "Привет, " + sameName;

            ViewBag.Name = name;
            ViewBag.Method = Method;
            return View();
        }
    }
}