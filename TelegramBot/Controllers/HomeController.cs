﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TelegramBot.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Мой телега бот";
        }
    }
}

     /*   public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
*/