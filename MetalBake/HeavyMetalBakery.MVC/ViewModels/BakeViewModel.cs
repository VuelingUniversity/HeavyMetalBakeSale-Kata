using HeavyMetalBakery.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeavyMetalBakery.MVC.ViewModels
{
    public class BakeViewModel
    {
        public List<Bake> Bakes { get; internal set; }
    }
}