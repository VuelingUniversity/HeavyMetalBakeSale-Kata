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

        public Order()
        {
            itemsToBuy = new List<OrderLine>();
        }

        public decimal CalculateOrderPrice()
        {
            decimal totalPrice = 0;
            foreach (var item in itemsToBuy)
            {
                totalPrice += (item.Cuantity * item.Price);
            }
            return totalPrice;
        }

        public void AddOrderLine(OrderLine orderLine)
        {
            itemsToBuy.Add(orderLine);
        }

        public List<string> GetSummary()
        {
            List<string> summary = new List<string>();
            foreach (var item in itemsToBuy)
            {
                summary.Add($"{item.Id} {item.Cuantity} unidades x {item.Price}€: {item.Cuantity * item.Price}€");
            }
            summary.Add($"Total de la compra: {CalculateOrderPrice()}€");
            return summary;
        }
    }
}