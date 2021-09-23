﻿using HeavyMetalBakery.Services;
using System.Collections.Generic;

namespace HeavyMetalBakery.Infraestructure.Repository
{
    public class InMemoryPriceService : IPriceService
    {
        private readonly Dictionary<string, decimal> _prices;

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

        private bool Exists(string itemId)
        {
            return _prices.ContainsKey(itemId);
        }
    }
}