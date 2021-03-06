﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectAMT.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            //throw new StackOverflowException();
            return View();
        }
        [ActionName("about-this-atm")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("about");
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Having trouble? Send us a message";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.TheMessage = "Thank, we got your message!";

            return View();
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETWVC5ATM";
            if(letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            return Content(serial);
        }
    }
}