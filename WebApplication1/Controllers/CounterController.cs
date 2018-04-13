using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CounterController : Controller
    {
        private int _counter = 0;

        [HttpGet]
        public ActionResult Index()
        {
            Session["Count"] = _counter;
            return View();
        }

        [HttpPost]
        public ActionResult Index(int? counter)
        {
            _counter = (int)Session["Count"];
            _counter++;
            Session["Count"] = _counter;
            return View();
        }
    }
}