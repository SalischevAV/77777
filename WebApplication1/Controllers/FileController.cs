using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class FileController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index (string fileName)
        {
            string path = Server.MapPath("~/Content/" + fileName);
            if (System.IO.File.Exists(path))
                return File(path, "application / pdf");
            else
                return HttpNotFound();
        }


    }
}