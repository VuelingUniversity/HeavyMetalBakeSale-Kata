using HeavyMetalBakery.Domain;
using HeavyMetalBakery.Infraestructure.Repository;
using HeavyMetalBakery.MVC.Models;
using HeavyMetalBakery.MVC.ViewModels;
using HeavyMetalBakery.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HeavyMetalBakery.MVC.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShoppingCartView()
        {
            IShoppingCartService shoppingCartStockService = new ShoppingCartStockService();
            var items = shoppingCartStockService.GetCart();
            var viewModel = new OrderViewModel();
            Order order = new Order();
            order.setOrderItems(items);
            viewModel.Order = order;
            return View(viewModel);
        }
    }
}