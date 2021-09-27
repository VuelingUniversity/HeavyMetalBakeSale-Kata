using MetalBakeMVC.Models;
using MetalBakeMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBakeMVC.Interfaces
{
    public interface IStock
    {
        public List<StockData> GetProducts();

        public StockData GetProductByName(string id);

        public IActionResult AddProduct(string name, int num);
    }
}