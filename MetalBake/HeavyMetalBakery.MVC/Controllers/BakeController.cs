using HeavyMetalBakery.Infraestructure.Repository;
using HeavyMetalBakery.Infraestructure.Repository.HTTP;
using HeavyMetalBakery.MVC.Models;
using HeavyMetalBakery.MVC.ViewModels;
using HeavyMetalBakery.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HeavyMetalBakery.MVC.Controllers
{
    public class BakeController : Controller
    {
        private readonly List<Bake> _bakes = new List<Bake>();
        private readonly IPriceService _priceService = new InMemoryPriceService();

        public ActionResult Index()
        {
            return View(_bakes);
        }

        public ActionResult BakeView()
        {
            Inventory.WCF.IService wcfStockService = new Inventory.WCF.ServiceClient();
            int[] stocks = wcfStockService.GetStocks();
            string[] shorts = wcfStockService.GetShorts();
            string[] names = new string[shorts.Length];
            for (int i = 0; i < shorts.Length; i++)
            {
                if (shorts[i] == "B")
                    names[i] = "Brownie";
                else if (shorts[i] == "C")
                    names[i] = "Cake";
                else if (shorts[i] == "M")
                    names[i] = "Muffin";
                else if (shorts[i] == "W")
                    names[i] = "Water";
            }

            var viewModel = new BakeViewModel { Bakes = new List<Bake>() };
            for (int i = 0; i < names.Length; i++)
            {
                viewModel.Bakes.Add(new Bake { Sort = shorts[i], Name = names[i], Price = _priceService.GetPrice(shorts[i]), Quantity = stocks[i] });
            }

            return View(viewModel);
        }

        public ActionResult EditView(Bake bake)
        {
            var viewModel = new BakeViewModel();
            viewModel.Bake = bake;

            return View(bake);
        }

        public ActionResult SaveBake(Bake bake)
        {
            IStockService _WCFstockService = new SoapStockService();
            _WCFstockService.AddStock(bake.Sort, bake.Quantity);

            return Redirect("BakeView");
        }

        public ActionResult AddToCart(Bake bake)
        {
            IShoppingCartService cartStockService = new ShoppingCartStockService();
            cartStockService.AddStock(bake.Sort, bake.Quantity);
            return Redirect("BakeView");
        }

    }
}