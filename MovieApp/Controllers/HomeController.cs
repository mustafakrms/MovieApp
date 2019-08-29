using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.Movies);
        }
        public ActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }
        public ActionResult Contact()
        {
            return View();
        }

    }
}