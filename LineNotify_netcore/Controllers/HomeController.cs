﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LineNotify_netcore.Models;

namespace LineNotify_netcore.Controllers
{
    public class HomeController : Controller
    {
        readonly string token;

        public HomeController()
        {
            token = "Pd8OH3yI8quQyZyc4Xpe5wu3Kr1UOlz3MM4t32HwEeK";
        }

        public IActionResult Index()
        {
            LineNotify_netcore.Helpers.LineNotifySend.SendMessage("Test", token);

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
