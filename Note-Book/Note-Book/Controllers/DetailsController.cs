using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Note_Book.Entity;

namespace Note_Book.Controllers
{
    public class DetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Anime(int id)
        {
            var model = new Anime().get_fav();
            return View(model);
        }
    }
}