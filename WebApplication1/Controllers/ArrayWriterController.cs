using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ArrayWriterController : Controller
    {
       

        private int[] FillArray(int min, int max)
        {
            int middle;
            int size = Math.Abs(max - min);
            //if (max < min)
            //{
            //    middle = min;
            //    min = max;
            //    max = middle;
            //}

            int[] myArr = new int[size+1];
            for (int i = 0; i <= size; i++)
            {
                if (min < max)
                    myArr[i] = min++;
                else
                    myArr[i] = min--;
            }
            return myArr;
        }
        [HttpGet]
        public ActionResult Index()
        {
            int[] myArr = FillArray(0, 0);
            return View(myArr);
        }

        [HttpPost]
        public ActionResult Index(int min = 0, int max=0)
        {
            int[] myArr = FillArray(min, max);
            return View(myArr);
        }
    }
}