using HeavyMetalBakery.Domain;
using HeavyMetalBakery.Infraestructure.Inventory.WCF;
using HeavyMetalBakery.Infraestructure.Repository;
using HeavyMetalBakery.MVC.Models;
using HeavyMetalBakery.MVC.ViewModels;
using HeavyMetalBakery.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            List<Bake> bakes = new List<Bake>();
            
            for (int i = 0; i < items.Count; i++)
            {
                Bake bake = new Bake();
                bake.Price = items[i].BasePrice;
                bake.Sort = items[i].ItemId;
                bake.Quantity = items[i].Amount;
                if (items[i].ItemId == "B")
                {
                    bake.Name = "Brownie";
                    bakes.Add(bake);
                }
                else if (items[i].ItemId == "C")
                {
                    bake.Name = "Cake Pop";
                    bakes.Add(bake);
                }
                else if (items[i].ItemId == "M")
                {
                    bake.Name = "Muffin";
                    bakes.Add(bake);
                }
                else if (items[i].ItemId == "W")
                {
                    bake.Name = "Water";
                    bakes.Add(bake);
                }
            }         
            var viewModel = new BakeViewModel();
            viewModel.Bakes = bakes;
            return View(viewModel);

            
        }
    }
}