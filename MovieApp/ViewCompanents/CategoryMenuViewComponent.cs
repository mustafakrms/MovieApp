﻿using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.ViewCompanents
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["action"].ToString()=="Index")
            {
                ViewBag.SelectedCategory = RouteData?.Values["id"];
            }
            
            return View(CategoryRepository.Categories);
        }
    }
}
