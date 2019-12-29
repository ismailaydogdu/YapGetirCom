using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YapGetirCom.BLL;
using YapGetirCom.BLL.Abstract;
using YapGetirCom.DAL;
using YapGetirCom.DTO;
using YapGetirCom.Model;

namespace YapGetirCom.UI.MVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        private readonly IUserService _userService;

        private readonly IUserTypeService _userTypeService;

        public LoginController(IUserService userService, IUserTypeService userTypeService)
        {

            _userService = userService;
            _userTypeService = userTypeService;
        

        }
        public ActionResult Index()
        {
            
            GetUserTypes();
            return View();
        }
        [HttpPost]
        public ActionResult Index(User user)
        {
            try
            {
                _userService.Insert(user);

                GetUserTypes();
                return View();

            }
            catch (Exception)
            {

                throw;
            }
        }



        public ActionResult Login(LoginDTO loginDto)
        {
            User user = _userService.Login(loginDto);
            if (user != null)
            {
                Session["user"] = user;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                GetUserTypes();
                ViewBag.IsSuccess = "Giriş Başarısız";
                return RedirectToAction("Index", "Login");
            }



        }

        public void GetUserTypes()
        {
            List<SelectListItem> userTypeList = new List<SelectListItem>();
            foreach (UserType item in _userTypeService.GetAll().ToList())
            {
                if (item.TypeName != "Yönetici")
                {
                    userTypeList.Add(new SelectListItem { Text = item.TypeName, Value = item.UserTypeID.ToString() });
                }
            }
            ViewBag.UserType = userTypeList;
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}