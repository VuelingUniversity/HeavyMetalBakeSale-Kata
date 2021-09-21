using System.Collections.Generic;
using System.Linq;

namespace HeavyMetalBakery.Domain
{
    internal class Order
    {
        private List<OrderItem> _listOfItems;

        public Order()
        {
            _listOfItems = new List<OrderItem>();
        }

        public decimal AmountToPay { get { return _listOfItems.Sum(i => i.TotalPrice); } }
        public IEnumerable<OrderItem> OrderItems { get { return _listOfItems; } }

        public void AddItems(string[] itemIds)
        {
            foreach (var itemId in itemIds)
            {
                var item = _listOfItems.FirstOrDefault(i => i.ItemId == itemId);
                if (item == null)
                    _listOfItems.Add(item);
                else
                    item.IncreaseAmount();
            }
        }

        public bool CanBePurchased()
        {
            return _listOfItems.Count > 0;
        }

        public void SetPrice(string itemId, decimal newPrice)
        {
            var item = _listOfItems.FirstOrDefault(i => i.ItemId == itemId);
            item.BasePrice = newPrice;
        }
    }
}