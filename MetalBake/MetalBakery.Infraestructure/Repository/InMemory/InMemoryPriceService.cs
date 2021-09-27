using MetalBakery.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBakery.Infraestructure.Repository.InMemory
{
   public class InMemoryPriceService: ICalculatorPriceServices
    {
        private static Dictionary<string, decimal> _prices;

        public InMemoryPriceService()
        {
            _prices = new Dictionary<string, decimal>() { { "B", 0.65m }, { "M", 1.00m }, { "C", 1.35m }, { "W", 1.50m } };
        }

        public decimal GetPrice(string itemId)
        {
            if (!Exists(itemId))
                return 0m;
            return _prices[itemId];
        }

        public Dictionary<string, decimal> GetPrices()
        {
            return _prices;
        }

        private bool Exists(string itemId)
        {
            return _prices.ContainsKey(itemId);
        }
    }
}

