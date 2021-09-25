using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.core.Models
{
    public class Order
    {
        public List<OrderLine> itemsToBuy;

        public decimal CalculateOrderPrice()
        {
            decimal totalPrice = 0;
            foreach (var item in itemsToBuy)
            {
                totalPrice += (item.Cuantity * item.Price);
            }
            return totalPrice;
        }
    }
}