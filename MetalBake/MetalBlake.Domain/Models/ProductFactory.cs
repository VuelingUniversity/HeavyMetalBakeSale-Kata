using MetalBlake.Domain.Enums;
using MetalBlake.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBlake.Domain.Models
{
    public class ProductFactory
    {
        private static  ProductFactory _factory;

        private ProductFactory()
        {
        }

        public static ProductFactory GetInstance()
        {
            if(_factory == null)
            {
                return new ProductFactory();
            }
            return _factory;
        }

        public IProduct Build(ProductOptions option, int amount)
        {
            IProduct product;
            if(option == ProductOptions.Brownie)
            {
                product = new Brownie(amount);
            }
            else if (option == ProductOptions.Muffin)
            {
                product = new Muffin(amount);
            }
            else if (option == ProductOptions.CakePop)
            {
                product = new CakePop(amount);
            }
            else 
            {
                product = new Water(amount);
            }
            return product;
        }
    }
}
