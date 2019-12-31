using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YapGetirCom.BLL.Abstract;
using YapGetirCom.Model;

namespace YapGetirCom.UI.MVC.Controllers
{
    public class RecipesController : Controller
    {
        // GET: Recipes
        IProductService _productService;
        IUnitOfProductService _unitOfProductService;
        IUnitAndProductService _unitAndProductService;
        ICategoryService _categoryService;
        
        public RecipesController(IProductService productService, IUnitOfProductService unitOfProductService, IUnitAndProductService unitAndProductService,ICategoryService categoryService)
        {
            _productService = productService;
            _unitOfProductService = unitOfProductService;
            _unitAndProductService = unitAndProductService;
            _categoryService = categoryService;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            List<Category> categories = _categoryService.GetCategoriesByTypeID(2);
            ViewBag.Categories = categories;
            List<UnitOfProduct> unitOfProducts = _unitOfProductService.GetAll().ToList();
            ViewBag.Units = unitOfProducts;
            List<Product> products = _productService.GetAll().ToList();
            ViewBag.Products = new SelectList(products,"ProductID","ProductName");
            return View();
        }

        public JsonResult GetUnits(int productID)
        {

            List<UnitAndProduct> unitAndProducts=  _unitAndProductService.GetByProductID(productID);
            List<UnitOfProduct> unitOfProducts = new List<UnitOfProduct>();
            foreach (UnitAndProduct item in unitAndProducts)
            {
                unitOfProducts.Add(_unitOfProductService.Get(item.UnitOfProductID));
            }
            return Json(new SelectList(unitOfProducts, "UnitOfProductID", "Name"), JsonRequestBehavior.AllowGet);

        }
        
        Recipe recipe = new Recipe();
        public void UnitAndProductRecipeList(int productID,int unitOfProductID,int quantity)
        {
            UnitAndProduct unitAndProduct= _unitAndProductService.GetByUnitOfProductIDAndProductID(productID, unitOfProductID);
            recipe.UnitAndProductRecipes.Add(new UnitAndProductRecipe { UnitAndProductID = unitAndProduct.UnitAndProductID, Quantity = quantity });


        }
    }
}