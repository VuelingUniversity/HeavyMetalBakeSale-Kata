using HeavyMetalBakery.MVC.Models;
using System.Collections.Generic;

namespace HeavyMetalBakery.MVC.ViewModels
{
    public class BakeViewModel
    {
        public List<Bake> Bakes { get; internal set; }
        public Bake Bake { get; set; }
    }
}