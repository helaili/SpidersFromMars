﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SpidersFromMars.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            //MASTER
             return View();
        }
    }
}
