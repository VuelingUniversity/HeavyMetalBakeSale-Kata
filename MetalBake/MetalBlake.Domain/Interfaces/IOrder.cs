using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBlake.Domain.Interfaces
{
    public interface IOrder
    {
        public void AddProduct(IProduct product);
    }
}
