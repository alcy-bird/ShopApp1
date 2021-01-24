using Microsoft.AspNetCore.Mvc;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WEBUI.Contollers
{
    public class homeController:Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.Greeting = saat > 12 ? "iyi günler" : "günaydın";
            ViewBag.Username = "ahşe";
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
