﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TranVanTinh_KTRAFE.Controllers
{
    public class HomeController : Controller
    {
      

        public ActionResult MasterLayout()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}