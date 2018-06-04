﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Xamarin_day4_webapplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult TallennaEnnatys(int? id)
        {
            if (id.HasValue)
            {
                int arvaustenMäärä = id.Value;
                //TODO: tallennus tietokantaan
            }
            var ok = new { success = true };
            return Json(ok, JsonRequestBehavior.AllowGet);
        }
    }
}