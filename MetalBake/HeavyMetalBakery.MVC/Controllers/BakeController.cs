using HeavyMetalBakery.MVC.Models;
using HeavyMetalBakery.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HeavyMetalBakery.MVC.Controllers
{
    public class BakeController : Controller
    {
        private readonly List<Bake> _bakes = new List<Bake>();

        public ActionResult Index()
        {
            return View(_bakes);
        }

        public ActionResult BakeView()
        {
            var bakes = new List<Bake>
            {
                new Bake{Sort = "B", Name = "Brownie", Price = 0.65M, Quantity = 40},
                new Bake{Sort = "M", Name = "Muffin", Price = 1.0M, Quantity = 36},
                new Bake{Sort = "C", Name = "Cake Pop", Price = 1.35M, Quantity = 24},
                new Bake{Sort = "W", Name = "Water", Price = 1.50M, Quantity = 30}
            };
            var viewModel = new BakeViewModel
            {
                Bakes = bakes
            };
            return View(viewModel);
        }

        public ActionResult EditView(Bake bake)
        {
            var viewModel = new BakeViewModel();
            viewModel.Bake = bake;

            return View(viewModel);
        }
    }
}