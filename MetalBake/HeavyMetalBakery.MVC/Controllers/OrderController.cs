using HeavyMetalBakery.Domain;
using HeavyMetalBakery.Infraestructure.Repository;
using HeavyMetalBakery.Infraestructure.Repository.HTTP;
using HeavyMetalBakery.MVC.Models;
using HeavyMetalBakery.MVC.ViewModels;
using HeavyMetalBakery.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HeavyMetalBakery.MVC.Controllers
{
    public class OrderController : Controller
    {
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

        public ActionResult Buy(Order order)
        {
            IStockService wcfStockService = new SoapStockService();
            foreach (var item in order.OrderItems)
            {
                wcfStockService.ReduceStock(item.ItemId);
            }            
            return Redirect(@"..\Bake\BakeView");
        }
    }
}