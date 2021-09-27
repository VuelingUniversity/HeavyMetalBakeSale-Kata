using MetalBake.core.Services;
using MetalBake.infra;
using MetalBake.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetalBake.Web.Controllers
{
    public class PriceController : Controller
    {
        private IPriceService _priceService;

        public PriceController()
        {
            _priceService = new PriceService();
        }

        // GET: Price
        public ActionResult Index()
        {
            List<ItemPrice> prices = _priceService.GetAllPrices().Select(item => new ItemPrice { ItemId = item.ItemId, Price = item.Price }).ToList(); ;
            return View(prices);
        }

        public ActionResult Edit(string itemId)
        {
            ItemPrice item = new ItemPrice { ItemId = itemId, Price = _priceService.GetItemPrice(itemId) };
            return View(item);
        }

        public ActionResult SetNewPrice(ItemPrice item)
        {
            _priceService.UpdateItemPrice(item.ItemId, item.Price);
            return Redirect("Index");
        }
    }
}