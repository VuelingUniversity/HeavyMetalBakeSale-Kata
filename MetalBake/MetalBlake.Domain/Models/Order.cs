using MetalBlake.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBlake.Domain.Models
{
    public class Order : IOrder
    {
        public double Total;
        public List<IProduct> ListOrders { get; set; }

        public Order()
        {
            
        }

        public void AddProduct(IProduct product)
        {
            ListOrders.Add(product);
            Total += product.GetPrice();
        }
    }
}
