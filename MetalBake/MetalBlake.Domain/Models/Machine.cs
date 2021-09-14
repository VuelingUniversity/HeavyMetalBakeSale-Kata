using MetalBlake.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBlake.Domain.Models

{
    public class Machine : IMachine
    {
        public List<IProduct> ProductList { get; set; }

        public Machine()
        {
           
        }

        public double BuyProduct(char[] list, double amountPaid)
        {
            throw new NotImplementedException();

        }
    }
}
