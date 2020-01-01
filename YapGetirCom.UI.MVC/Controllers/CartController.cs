using YapGetirCom.UI.MVC.Cart;
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
    public class CartController : Controller
    {
        IRecipeService _recipeService;
        IRestaurantService _restaurantService;
        ICookService _cookService;
        IPaymentService _paymentService;
        IOrderService _orderService;
        public CartController(IRecipeService recipeService,IRestaurantService restaurantService,ICookService cookService, IPaymentService paymentService, IOrderService orderService)
        {
            _recipeService = recipeService;
            _restaurantService = restaurantService;
            _cookService = cookService;
            _paymentService = paymentService;
            _orderService = orderService;
        }

        public ActionResult Index()
        {
            
            ViewBag.Restaurants = new SelectList(_restaurantService.GetAll(),"RestaurantID","CompanyName");
            ViewBag.Cooks = new SelectList(_cookService.GetAll(), "CookID", "FirstName");
            ViewBag.Payments = new SelectList(_paymentService.GetAll(), "PaymentID", "PaymentType");
            return View();
        }

        #region Sepet Listesi
        public JsonResult List()
        {
            if (Session["sepet"] != null)
            {
                ProductCart cart = Session["sepet"] as ProductCart;
                List<ProductVM> productList = cart.ChartProductList.Select(x => new ProductVM
                {
                    Id = x.Id,
                    ProductName = x.ProductName,
                    UnitPrice = x.UnitPrice,
                    UnitsInstock = x.UnitsInstock,
                    Quantity = x.Quantity
                }).ToList();

                return Json(productList, JsonRequestBehavior.AllowGet);
            }

            return Json("Empty", JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region Sepete Ekleme
        [HttpPost]
        public JsonResult Add(int id)
        {
            Recipe recipe = _recipeService.Get(id);
            ProductVM vm = new ProductVM
            {
                Id = recipe.RecipeID,
                ProductName = recipe.RecipeName,
                UnitPrice = recipe.Price,
                UnitsInstock = 0,
                Quantity = 1
            };

            if (Session["sepet"] != null)
            {
                ProductCart cart = Session["sepet"] as ProductCart;
                cart.AddCart(vm);
                Session["sepet"] = cart;
            }
            else
            {
                ProductCart cart = new ProductCart();
                cart.AddCart(vm);
                Session.Add("sepet", cart);
            }
            return Json("");
        }
        #endregion

        #region Ürün Azaltma
        public JsonResult DecreaseCart(int id)
        {
            if (Session["sepet"] != null)
            {
                ProductCart cart = Session["sepet"] as ProductCart;
                cart.DecreaseCart(id);
                Session["sepet"] = cart;
            }
            return Json("");
        }
        #endregion

        #region Ürün Arttırma
        public JsonResult IncreaseCart(int id)
        {
            ProductCart cart = Session["sepet"] as ProductCart;
            cart.IncreaseCart(id);
            Session["sepet"] = cart;
            return Json("");
        }
        #endregion

        #region Sepetten Ürün Silme
        public JsonResult Remove(int id)
        {
            ProductCart cart = Session["sepet"] as ProductCart;
            cart.RemoveChart(id);
            Session["sepet"] = cart;
            return Json("");
        }
        #endregion


        public ActionResult Order()
        {
            return View();
        }
       [HttpPost]
        public ActionResult Order(Order order)
        {
            int restId = order.RestaurantID;
            int cookId = order.CookID;
            int paymetId = order.PaymentID;
            string adres = order.Address;
            DateTime dateTime = order.RequestedDate;
          
                ProductCart cart = Session["sepet"] as ProductCart;
                List<ProductVM> productList = cart.ChartProductList.Select(x => new ProductVM
                {
                    Id = x.Id,
                    ProductName = x.ProductName,
                    UnitPrice = x.UnitPrice,
                    UnitsInstock = x.UnitsInstock,
                    Quantity = x.Quantity
                }).ToList();

            foreach (ProductVM item in productList)
            {
                order.RestaurantID = restId;
                order.CookID = cookId;
                order.PaymentID = paymetId;
                order.Address = adres;
                order.RequestedDate = dateTime;
                order.RecipeID = item.Id;
                order.Quantity = item.Quantity;
                order.OrderPrice = (decimal)item.UnitPrice * item.Quantity;
                order.UserID = ((User)Session["user"]).UserID;
                order.OrderDate = DateTime.Now;
                order.IsActive = true;
                order.CreateDate = DateTime.Now;
                order.OrderStatus = "Onaylanmadı";
               _orderService.Insert(order);
                order = new Order();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}