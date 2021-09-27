using MetalBakery.API.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBakery.API.Repository
{
    public class ItemPriceRepository : IItemPriceRepository
    {
		private static Dictionary<string, decimal> _prices;

		static ItemPriceRepository()
		{
			_prices = new Dictionary<string, decimal>() { { "B", 0.65m }, { "M", 1.00m }, { "C", 1.35m }, { "W", 1.50m } };
		}

		public ItemPriceDto Get(string itemId)
		{
			if (!Exists(itemId))
				return null;
			return new ItemPriceDto
			{
				ItemId = itemId,
				Price = _prices[itemId]
			};
		}

		public List<ItemPriceDto> GetAll()
		{
			return _prices.Select(x => new ItemPriceDto
			{
				ItemId = x.Key,
				Price = x.Value
			}).ToList();
		}

		public bool Save(ItemPriceDto item)
		{
			if (!Exists(item.ItemId))
				return false;
			_prices[item.ItemId] = item.Price;
			return true;
		}

		private bool Exists(string itemId)
		{
			return _prices.ContainsKey(itemId);
		}
	}
}
