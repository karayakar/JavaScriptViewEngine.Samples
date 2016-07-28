﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sample.MvcCore1.ReactHotModuleReloading.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("/index.html");
        }
    }
}