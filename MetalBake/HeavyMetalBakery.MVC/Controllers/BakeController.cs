using HeavyMetalBakery.MVC.Models;
using HeavyMetalBakery.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HeavyMetalBakery.MVC.Controllers
{
    public class BakeController : Controller
    {
        private readonly List<Bake> _bakes = new List<Bake>
        {
            new Bake{Sort = "B", Name = "Brownie", Price = 0.65M, Quantity = 40},
            new Bake{Sort = "M", Name = "Muffin", Price = 1.0M, Quantity = 36},
            new Bake{Sort = "C", Name = "Cake Pop", Price = 1.35M, Quantity = 24},
            new Bake{Sort = "W", Name = "Water", Price = 1.50M, Quantity = 30}
        };

        public ActionResult Index()
        {
            return View(_bakes);
        }

        public ActionResult BakeView(List<Bake> updatedBakes)
        {
            var priceService = new HeavyMetalBakery. IPriceService();
        /*
        if(updatedBakes != null)
        {
            var viewModel = new BakeViewModel
            {
                Bakes = updatedBakes
            };
            return View(viewModel);
        }
        else
        {
            var bakes = _bakes;

            var viewModel = new BakeViewModel
            {
                Bakes = bakes
            };
            return View(viewModel);
        }
        */
    }

        public ActionResult EditView(Bake bake)
        {
            var viewModel = new BakeViewModel();
            viewModel.Bake = bake;

            return View(bake);
        }

        public ActionResult SaveBake(Bake bake)
        {
            var bakes = _bakes;
            for (int i = 0; i < bakes.Count; i++)
            {
                if (bakes[i].Sort.Equals(bake.Sort))
                {
                    bakes[i].Name = bake.Name;
                    bakes[i].Price = bake.Price;
                    bakes[i].Quantity =bake.Quantity;
                }
            }
            return RedirectToAction("BakeView", bakes);
        }
    }
}