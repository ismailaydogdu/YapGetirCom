﻿using System;
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
   

        
        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }
    }
}