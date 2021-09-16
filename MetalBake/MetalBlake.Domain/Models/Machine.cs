using MetalBlake.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBlake.Domain.Models

{
    public class Machine 
    {
        public List<IProduct> ProductList { get; set; }

        public Machine()
        {
            ProductList = new List<IProduct>();
        }

        public void ShowProducts()
        {
            ProductList.ForEach(product =>
            {
                product.ShowProduct();
            });
        }
        
    }
}
