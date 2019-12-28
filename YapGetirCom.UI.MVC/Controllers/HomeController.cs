using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YapGetirCom.BLL.Abstract;
using YapGetirCom.BLL.Concrete;
using YapGetirCom.Model;

namespace YapGetirCom.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        //private IUserService _userService;
        //public HomeController(IUserService userService)
        //{
        //    _userService = userService;
        //}
        // GET: Home
        public ActionResult Index()
        {
            //List<User> users = _userService.GetAll().ToList();
            //if (users != null)
            //{
            //    return View(users);
            //}

            return View();
        }
    }
}