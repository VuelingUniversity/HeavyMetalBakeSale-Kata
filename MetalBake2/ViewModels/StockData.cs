using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBakeMVC.ViewModels
{
    public class StockData
    {
        public string Name { get; set; }
        public int Total { get; set; }

        public StockData(string name, int total)
        {
            Name = name;
            Total = total;
        }
    }
}