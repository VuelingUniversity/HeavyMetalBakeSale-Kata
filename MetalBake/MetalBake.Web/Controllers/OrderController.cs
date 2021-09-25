using MetalBake.ApplicationServices;
using MetalBake.core.Services;
using MetalBake.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetalBake.Web.Controllers
{
    public class OrderController : Controller
    {
        private IItemService _itemService = new ItemService();

        // GET: Order
        public ActionResult Index()
        {
            ItemsList itemsList = new ItemsList();
            itemsList.ListOfItems = _itemService.GetAllItems();
            return View(itemsList);
        }

        public ActionResult GoToCart(OrderForm order)
        {
            return View();
        }

        public ActionResult MakeAnOrder()
        {
            return View();
        }
    }
}