using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YapGetirCom.BLL.Abstract;
using YapGetirCom.DTO;
using YapGetirCom.Model;

namespace YapGetirCom.UI.MVC.Areas.Admin.Controllers
{
    public class AdminLoginController : Controller
    {
        IUserService _userService;
        public AdminLoginController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginDTO loginDTO)
        {
            try
            { 
                Restaurant restaurant = _userService.RestaurantLogin(loginDTO).Restaurants.First();
                Session["restaurant"] = restaurant;
                return RedirectToAction("Index", "Order");
            }
            catch (Exception ex)
            {

                ViewBag.IsSucces = ex;
                return View();
            }
            
        }
    }
}