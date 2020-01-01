using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YapGetirCom.BLL.Abstract;
using YapGetirCom.Model;
using YapGetirCom.UI.MVC.Models;

namespace YapGetirCom.UI.MVC.Controllers
{
    public class FavoriteController : Controller
    {
        // GET: Favorite
        private IRecipeService _recipeService;
        private IRestaurantService _restaurantService;

        public FavoriteController(IRecipeService recipeService, IRestaurantService restaurantService)
        {
            _recipeService = recipeService;
            _restaurantService = restaurantService;
        }
        public ActionResult Index()
        {
            HomeVM homeVm = new HomeVM();

            List<Recipe> recipes = _recipeService.GetAll().ToList();

            foreach (Recipe item in recipes)
            {
                if (item.IsFavourite == true)
                {
                    homeVm.Recipes.Add(item);
                }
            }

            List<Restaurant> restaurants = _restaurantService.GetAll().ToList();
            foreach (Restaurant item in restaurants)
            {
                if (item.IsFavourite == true)
                {
                    homeVm.Restaurants.Add(item);
                }
            }

            return View(homeVm);
        }
    }
}