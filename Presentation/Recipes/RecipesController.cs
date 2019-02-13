using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Recipes
{
    public class RecipesController : Controller
    {
        // GET: Recipes
        public ActionResult Index()
        {
            ViewBag.Recipes = "Recipes from controller";
            return View();
        }
    }
}