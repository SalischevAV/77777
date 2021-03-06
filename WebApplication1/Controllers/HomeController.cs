﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private List<string> _myStringArr = new List<string>();


        [HttpGet]
        public ActionResult Index()
        {

           //_myStringArr = (List<string>)Session["list"];

            Session["list"] = _myStringArr;
            return View();
        }


        [HttpPost]
        public ActionResult Index(string stringForArray, string action)
        {
            _myStringArr = (List<string>)Session["list"];
            if (action == "add")
                _myStringArr.Add(stringForArray);
            else if (action == "clear")
                _myStringArr.Clear();
            Session["list"] = _myStringArr;
            return View();
        }

        public ActionResult ContextInfo()
        {
            List<string> requestInfoList = new List<string>();
            requestInfoList.Add(HttpContext.Request.HttpMethod);
            foreach (var item in HttpContext.Request.Headers.AllKeys)
                requestInfoList.Add(item);
            requestInfoList.Add(HttpContext.Request.Browser.Browser);
            requestInfoList.Add(HttpContext.Request.RawUrl);
            ViewBag.Context = requestInfoList;
            return View();
        }

        public ActionResult CreateList()
        {
            _myStringArr = (List<string>)Session["list"];
            if (_myStringArr != null)
                return View(_myStringArr);
            else
                return View(new List<string>());
        }

    }
}