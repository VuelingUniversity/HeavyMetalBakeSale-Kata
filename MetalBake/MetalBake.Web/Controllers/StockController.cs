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
    public class StockController : Controller
    {
        private IStockService _stockService;

        public StockController()
        {
            _stockService = new StockService();
        }

        // GET: Stock
        public ActionResult Index()
        {
            List<ItemStock> stock = _stockService.GetAllStock().Select(item => new ItemStock { ItemId = item.ItemId, Stock = item.Stock }).ToList();
            return View(stock);
        }

        public ActionResult Edit(string itemId)
        {
            ItemStock item = new ItemStock { ItemId = itemId, Stock = _stockService.GetItemStock(itemId) };
            return View(item);
        }

        public ActionResult SetNewStock(ItemStock item)
        {
            _stockService.SetItemStock(item.ItemId, item.Stock);
            return Redirect("Index");
        }
    }
}