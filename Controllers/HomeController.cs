﻿using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
