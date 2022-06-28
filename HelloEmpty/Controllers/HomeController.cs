using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloEmpty.Models;

namespace HelloEmpty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HelloMessage msg = new HelloMessage()
            {
                Message = "Welcome to Asp.Net MVC !"
            };

            ViewBag.Noti = "Input message and click submit";


            return View(msg);
        }

        [HttpPost]
        public IActionResult Index(HelloMessage obj)
        {
            ViewBag.Noti = "Input Changed";
            return View(obj);
        }
    }
}
