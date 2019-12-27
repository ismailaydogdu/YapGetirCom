using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YapGetirCom.BLL.Abstract;
using YapGetirCom.Model;

namespace YapGetirCom.UI.MVC.Controllers
{
    public class DenemeController : Controller
    {
        private readonly IUserService _userService;
        
        public DenemeController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: Deneme
        public ActionResult Index()
        {   
            List<User> users = _userService.GetAll().ToList();
            if (users!=null)
            {
                return View(users);
            }

            return View();


        }
    }
}