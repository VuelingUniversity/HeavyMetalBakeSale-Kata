using HeavyMetalBakery.Services;
using System.Collections.Generic;

namespace eavyMetalBakery.Infraestructure.Repository
{
	public class InMemoryStockService : IStockService
	{
		private Dictionary<string, int> _stock;

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
	}
}