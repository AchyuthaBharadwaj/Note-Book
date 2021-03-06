﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Notebook.Models;
using Notebook.Models.HomeViewModels;

namespace Notebook.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeModel model = new HomeModel();
            return View(model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
