using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeavyMetalBakery.MVC.Models
{
    public class Bake
    {
        public string Sort { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}