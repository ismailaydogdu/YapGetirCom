using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        IRecipeService _recipeService;

        public RecipesController(IProductService productService, IUnitOfProductService unitOfProductService, IUnitAndProductService unitAndProductService, ICategoryService categoryService, IRecipeService recipeService)
        {
            _productService = productService;
            _unitOfProductService = unitOfProductService;
            _unitAndProductService = unitAndProductService;
            _categoryService = categoryService;
            _recipeService = recipeService;
        }

        public ActionResult Index()
        {
            List<Recipe> recipes = _recipeService.GetAll().ToList();
            return View(recipes);
        }

        public ActionResult Add()
        {
            List<Category> categories = _categoryService.GetCategoriesByTypeID(2);
            ViewBag.Categories = new SelectList(categories, "CategoryID", "CategoryName");
            List<UnitOfProduct> unitOfProducts = _unitOfProductService.GetAll().ToList();
            ViewBag.Units = unitOfProducts;
            List<Product> products = _productService.GetAll().ToList();
            ViewBag.Products = new SelectList(products, "ProductID", "ProductName");
            return View();
        }
        [HttpPost]
        public ActionResult Add(Recipe recipe, HttpPostedFileBase fileUpload)
        {

            recipe.UnitAndProductRecipes = (Session["unitAndProductRecipes"] as List<UnitAndProductRecipe>);
            if (fileUpload != null)
            {
                
              string fileName= Guid.NewGuid() + Path.GetExtension(fileUpload.FileName);

                string extension = Server.MapPath("/images/recipes/") + fileName;
                fileUpload.SaveAs(extension);
                recipe.Image = fileName;
            }
            recipe.IsActive = true;
            recipe.UserID = (Session["user"] as User).UserID;
            recipe.CreateDate = DateTime.Now;
            recipe.Price = 0;
            foreach (UnitAndProductRecipe item in recipe.UnitAndProductRecipes)
            {
                recipe.Price += item.UnitAndProduct.Price * item.Quantity;
                item.UnitAndProduct = null;
            }
            
            _recipeService.Insert(recipe);
            
            return RedirectToAction("Index", "Recipes");
        }

        public JsonResult GetUnits(int productID)
        {

            List<UnitAndProduct> unitAndProducts = _unitAndProductService.GetByProductID(productID);
            List<UnitOfProduct> unitOfProducts = new List<UnitOfProduct>();
            foreach (UnitAndProduct item in unitAndProducts)
            {
                unitOfProducts.Add(_unitOfProductService.Get(item.UnitOfProductID));
            }
            return Json(new SelectList(unitOfProducts, "UnitOfProductID", "Name"), JsonRequestBehavior.AllowGet);

        }
        
        public void UnitAndProductRecipeList(int productID, int unitOfProductID, int quantity)
        {
            UnitAndProduct unitAndProduct = _unitAndProductService.GetByUnitOfProductIDAndProductID(productID, unitOfProductID);
            (Session["unitAndProductRecipes"] as List<UnitAndProductRecipe>).Add(new UnitAndProductRecipe { UnitAndProductID = unitAndProduct.UnitAndProductID, Quantity = quantity,UnitAndProduct=unitAndProduct });
           
        }

        public void UnitAndProductRecipeListRemove(int index)
        {
            (Session["unitAndProductRecipes"] as List<UnitAndProductRecipe>).ToList().RemoveAt(index);
        }
    }
}