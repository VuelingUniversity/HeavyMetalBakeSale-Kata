using HeavyMetalBakery.Console.Service;
using HeavyMetalBakery.Domain;
using HeavyMetalBakery.Services;
using System;

namespace HeavyMetalBakery.Console
{
    internal class Application
    {
        private IPriceService _priceService;
        private IStockService _stockService;

        public Application(IStockService stockService, IPriceService priceService)
        {
            _stockService = stockService;
            _priceService = priceService;
        }

        public void Run()
        {
            var order = new Order();
            order.AddItems(UserIsAskedWhatHeWants());
            ShowPurchasingItems(order);
            if (order.CanBePurchased())
            {
                var paid = AskUserForMoney();
                CalculateChange(order.AmountToPay, paid);
            }
        }

        private void CalculateChange(decimal amountToPay, decimal paid)
        {
            if (!ChangeService.CanBeChanged(paid, amountToPay))
            {
                System.Console.WriteLine($"You need to put more money");
                return;
            }
            var difference = ChangeService.CalculateChange(paid, amountToPay);
            System.Console.WriteLine($"your change is: {difference}");
        }

        private decimal AskUserForMoney()
        {
            System.Console.WriteLine("Amount Paid");
            var amountPaid = System.Console.ReadLine();
            return Convert.ToDecimal(amountPaid);
        }

        private void ShowPurchasingItems(Order order)
        {
            foreach (var orderLine in order.OrderItems)
            {
                if (!_stockService.CheckStock(orderLine.ItemId))
                {
                    System.Console.WriteLine("Not enough stock " + orderLine.ItemId);

                    return;
                }
                var itemPrice = _priceService.GetPrice(orderLine.ItemId);
                order.SetPrice(orderLine.ItemId, itemPrice);
                _stockService.ReduceStock(orderLine.ItemId);
            }
            System.Console.WriteLine("Total: " + order.AmountToPay);
        }

        private string[] UserIsAskedWhatHeWants()
        {
            System.Console.WriteLine("Items to Purchase?");
            var items = System.Console.ReadLine().Split(',');
            return items;
        }
    }
}