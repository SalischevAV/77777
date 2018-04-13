using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class RedirectController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string myNumber)
        {
            int sameNumber;
            if (Int32.TryParse(myNumber, out sameNumber))
            {
                TempData["number"] = sameNumber;
                if (sameNumber <= 0)
                    return RedirectToAction("Doubler", "Redirect");
                else
                    return RedirectToAction("Square", "Redirect");
            }
            else
                return RedirectToAction("Index", "Redirect");
        }

        public ActionResult Doubler(int? number)
        {
            if (number == null)
            {
                if(TempData["number"]==null)
                    return RedirectToAction("Index", "Redirect");
                else
                number = (int)TempData["number"];
            }
            ViewBag.Result = number * 2;
            return View();
        }

        public ActionResult Square(int? number)
        {
            if (number == null)
            {
                if (TempData["number"] == null)
                    return RedirectToAction("Index", "Redirect");
                else
                    number = (int)TempData["number"];
            }
            ViewBag.Result = number * number;
            return View();
        }
    }
}