using MetalBakery.API.Dto;
using MetalBakery.API.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBakery.API.Repository
{
    public class ItemPriceRepository : IItemPriceRepository
    {
		private static Dictionary<string, decimal> _prices;
		/// <summary>
		/// Se asocia precios al dicionario;
		/// un diccionario tiene Clave y valor _> Key=Id as string y valor decimal 
		/// </summary>
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
		/// <summary>
		/// Por cada uno de los elementos del diccionario
		/// /// los recorre y los convierte a una lsita de clave valor
		/// </summary>
		/// <returns>List<ItemPriceDto></returns>
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
