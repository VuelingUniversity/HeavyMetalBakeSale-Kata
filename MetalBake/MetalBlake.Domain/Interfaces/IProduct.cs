using MetalBlake.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBlake.Domain.Interfaces
{
    public interface IProduct
    {
        public void RemoveStock(IProduct product);
        public void AddStock(IProduct product);
        public void ShowProduct();
        public string GetName();
        public double GetPrice();
        

    }
}
