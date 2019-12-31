using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YapGetirCom.BLL.Abstract;
using YapGetirCom.Model;

namespace YapGetirCom.UI.MVC.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        ICategoryService _categoryService;
        public ProductController(IProductService productService,ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products= _productService.GetAll().ToList();
            List<Category> categories = _categoryService.GetCategoriesByTypeID(3);
            ViewBag.Categories = categories;
            return View(products);
        }
    }
}