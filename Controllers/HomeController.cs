﻿using Microsoft.AspNetCore.Mvc;

namespace MioCorso.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
