using MetalBlake.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBlake.Domain.Interfaces
{
    public interface IMachine
    {
        public void BuyProduct(Order order,Machine machine, double amountPaid);
        

        
    }
}
