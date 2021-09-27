using MetalBakeMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBakeMVC.Models
{
    public class Order
    {
        public List<StockData> productStock { get; set; }
        public double Total { get; set; }

        public Order(List<StockData> productList, double total)
        {
            this.productStock = productList;
            Total = total;
        }

        public void AddProduct(StockData item)
        {
            if (productStock.Contains(item))
            {
                productStock.FirstOrDefault(product => product.Name == item.Name).Total += 1;
                return;
            }
            productStock.Add(item);
        }

        public void ReduceProduct(StockData item)
        {
            if (productStock.Contains(item))
            {
                var product = productStock.FirstOrDefault(product => product.Name == item.Name);
                if (product.Total > 1)
                {
                    product.Total -= 1;
                    return;
                }
                productStock.Remove(item);
            }
        }
    }
}