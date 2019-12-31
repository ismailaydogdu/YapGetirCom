using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YapGetirCom.BLL.Abstract;
using YapGetirCom.Model;

namespace YapGetirCom.UI.MVC.Controllers
{
    public class RestaurantController : Controller
    {
        IRestaurantService _restaurantService;
        ICategoryService _categoryService;
        public RestaurantController(IRestaurantService restaurantService,ICategoryService categoryService)
        {
            _restaurantService = restaurantService;
            _categoryService = categoryService;
        }
        // GET: Restaurant
        public ActionResult Index()
        {
            List<Category> categories = _categoryService.GetCategoriesByTypeID(1);
            ViewBag.Categories = categories;
            List<Restaurant> restaurants = _restaurantService.GetAll().ToList();
            return View(restaurants);
        }
    }
}