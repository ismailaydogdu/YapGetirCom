using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YapGetirCom.BLL.Abstract;
using YapGetirCom.Model;

namespace YapGetirCom.UI.MVC.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        // GET: Admin/Order
        IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public ActionResult Index()
        {
            List<Order> orders = _orderService.GetByRestaurantID((Session["restaurant"] as Restaurant).RestaurantID);
            return View(orders);
        }
    }
}