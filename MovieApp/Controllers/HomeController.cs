using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(ProductRepository.Movies);
        }
        public ActionResult Details(int id)
        {
            return View(ProductRepository.GetById(id));
        }
        public ActionResult Contact()
        {
            return View();
        }

    }
}