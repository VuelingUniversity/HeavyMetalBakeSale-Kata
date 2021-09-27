using HeavyMetalBakery.Services;
using System.Collections.Generic;

namespace HeavyMetalBakery.Infraestructure.Repository
{
    public class InMemoryStockService : IStockService
    {
        private readonly Dictionary<string, int> _stock;

        public InMemoryStockService()
        {
            _stock = new Dictionary<string, int>() { { "B", 30 }, { "M", 36 }, { "C", 24 }, { "W", 0 } };
        }

        public void AddStock(string itemId, int amount)
        {
            if (Exists(itemId))
                _stock[itemId] += amount;
        }

        public bool CheckStock(string itemId)
        {
            if (!Exists(itemId))
                return false;
            return _stock[itemId] > 0;
        }

        public void ReduceStock(string itemId)
        {
            if (Exists(itemId))
                _stock[itemId]--;
        }

        private bool Exists(string itemId)
        {
            return _stock.ContainsKey(itemId);
        }

        public int[] GetStocks()
        {
            int[] stocks = new int[_stock.Count];
            int cont = 0;
            foreach (var i in _stock)
            {
                stocks[cont] = i.Value;
                cont++;
            }
            return stocks;
        }

        public string[] GetShorts()
        {
            string[] shorts = new string[_stock.Count];
            int cont = 0;
            foreach (var i in _stock)
            {
                shorts[cont] = i.Key.ToString();
                cont++;
            }
            return shorts;
        }
    }
}