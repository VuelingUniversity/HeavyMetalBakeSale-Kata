using MetalBake.core.Models;
using MetalBake.core.Services;
using MetalBake.infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.ApplicationServices
{
    public class OrderService : IOrderService
    {
        private IPriceService _priceService = new PriceService();
        private IStockService _stockService = new StockService();

        public Order CreateOrder(List<Tuple<string, int>> itemsQuantity)
        {
            Order order = new Order();

            foreach (var item in itemsQuantity)
            {
                if (order.itemsToBuy.Exists(i => i.Id == item.Item1))
                {
                    OrderLine orderLine = order.itemsToBuy.FirstOrDefault(i => i.Id == item.Item1);
                    orderLine.Cuantity += item.Item2;
                }
                else
                {
                    OrderLine orderLine = new OrderLine { Id = item.Item1, Cuantity = item.Item2, Price = _priceService.GetItemPrice(item.Item1) };
                    order.AddOrderLine(orderLine);
                }
            }
            return order;
        }

        public List<string> ProcessOrder(Order order)
        {
            List<string> stockErrors = CheckStockErrors(order.itemsToBuy);
            if (stockErrors.Count() > 0)
            {
                return stockErrors;
            }
            ReduceItemsStock(order.itemsToBuy);
            return null;
        }

        private List<string> CheckStockErrors(List<OrderLine> items)
        {
            List<string> errors = new List<string>();
            foreach (var orderLine in items)
            {
                int itemStock = _stockService.GetItemStock(orderLine.Id);
                if (itemStock < orderLine.Cuantity)
                {
                    errors.Add($"Not enough stock of {orderLine.Id}  Order: {orderLine.Cuantity} Stock: {itemStock}");
                }
            }
            return errors;
        }

        private void ReduceItemsStock(List<OrderLine> items)
        {
            foreach (var orderLine in items)
            {
                _stockService.ReduceItemStock(orderLine.Id, orderLine.Cuantity);
            }
        }
    }
}