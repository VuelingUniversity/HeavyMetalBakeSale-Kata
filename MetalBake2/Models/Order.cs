using MetalBakeMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBakeMVC.Models
{
    public class Order
    {
        public List<StockData> listOrder { get; set; }
        public double Total { get; set; }
    }
}