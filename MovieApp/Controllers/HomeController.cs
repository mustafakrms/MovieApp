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
            // ProductRepository.Movies
            // CategoryRepository.Category


            MovieCategoryModel model = new MovieCategoryModel();
            model.Categories = CategoryRepository.Categories;
            model.Movies = MovieRepository.Movies;



            return View(model);
        }
        public ActionResult Details(int id)
        {
            MovieCategoryModel model = new MovieCategoryModel();
            model.Categories = CategoryRepository.Categories;
            model.Movie = MovieRepository.GetById(id);
            return View(model);
        }
        public ActionResult Contact()
        {
            return View();
        }

    }
}