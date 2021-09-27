using HeavyMetalBakery.Domain;
using HeavyMetalBakery.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HeavyMetalBakery.Infraestructure.Repository
{
    public class ShoppingCartStockService : IShoppingCartService
    {
        private readonly string _url = @"C:\Users\pginer\Source\Repos\HeavyMetalBake\MetalBake\HeavyMetalBakery.Infraestructure\Files\ShoppingCart.txt";
        private readonly IPriceService _priceService = new InMemoryPriceService();

        public void AddStock(string itemId, int amount)
        {
            var jsonData = System.IO.File.ReadAllText(_url);
            var itemsToCart = JsonConvert.DeserializeObject<List<OrderItem>>(jsonData)
                              ?? new List<OrderItem>();

            if (amount > 0)
            {
                itemsToCart.Add(new OrderItem(itemId)
                {
                    Amount = 1,
                    BasePrice = _priceService.GetPrice(itemId),
                });
            }
            else return;

            jsonData = JsonConvert.SerializeObject(itemsToCart, Formatting.Indented);
            File.WriteAllText(_url, jsonData);
        }

        public bool CheckStock(string itemId)
        {
            throw new NotImplementedException();
        }

        public void ReduceStock(string itemId)
        {
            throw new NotImplementedException();
        }

        public List<OrderItem> GetCart()
        {
            string itemsJson = File.ReadAllText(_url);
            var tempItems = JsonConvert.DeserializeObject<List<OrderItem>>(itemsJson);
            List<OrderItem> finalItems = new List<OrderItem>();
            foreach (var item in tempItems)
            {
                var ol = finalItems.FirstOrDefault(l => l.ItemId == item.ItemId);
                if (ol == null)
                    finalItems.Add(item);
                else
                    ol.IncreaseAmount();
            }
            return finalItems;
        }
    }
}