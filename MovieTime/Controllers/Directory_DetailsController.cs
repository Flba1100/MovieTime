﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MovieTime.Controllers
{
    public class Directory_DetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
