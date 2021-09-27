using HeavyMetalBakery.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeavyMetalBakery.MVC.ViewModels
{
    public class OrderViewModel
    {
        public Order Order { get; internal set; }
        public OrderItem Item { get; set; }
    }
}