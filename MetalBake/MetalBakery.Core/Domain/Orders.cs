using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetalBakery.Core.Domain
{
   public class Orders
    {
		private List<OrderLine> _listOfItems;

		public Orders()
		{
			_listOfItems = new List<OrderLine>();
		}
		/// <summary>
		/// De la lista de elementos busca y calcula el total 
		/// </summary>
		public decimal AmountToPay { get { return _listOfItems.Sum(t => t.TotalPrice); } }
		/// <summary>
		/// Returns a item's list 
		/// </summary>
		public IEnumerable<OrderLine> OrderLines { get { return _listOfItems; } }
		/// <summary>
		/// Add Items to list 
		/// </summary>
		/// <param name="itemIds"></param>
		public void AddItems(string[] itemIds)
		{
			foreach (var itemId in itemIds)
			{
				var ol = _listOfItems.FirstOrDefault(l => l.ItemId == itemId);
				if (ol == null)
					_listOfItems.Add(new OrderLine(itemId));
				else
					ol.IncresaseAmount();
			}
		}
		/// <summary>
		/// Devuelve si se puede comprar o no 
		/// </summary>
		/// <returns></returns>
		public bool CanBePurchase()
		{
			return AmountToPay > 0;
		}
		/// <summary>
		/// Search choosed item by Id and Set the price
		/// </summary>
		/// <param name="itemId"></param>
		/// <param name="itemPrice"></param>
		public void SetPrice(string itemId, decimal itemPrice)
		{
			var item = _listOfItems.FirstOrDefault(li => li.ItemId == itemId);
			item.BasePrice = itemPrice;
		}
	}
}
