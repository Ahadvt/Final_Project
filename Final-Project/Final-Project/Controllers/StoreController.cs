﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
