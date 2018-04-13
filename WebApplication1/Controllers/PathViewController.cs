using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class PathViewController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string value)
        {
            int number = 0;
            if (Int32.TryParse(value, out number))
                if (number > 0)
                    return View("~/Views/PathView/PathView02.cshtml");
                else return View("~/Views/PathView/PathView03.cshtml");
            else return View("~/Views/PathView/PathView01.cshtml");

        }
    }
}