using System.Collections.Generic;
using System.Linq;

namespace HeavyMetalBakery.Domain
{
    public class Order
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
                var ol = _listOfItems.FirstOrDefault(l => l.ItemId == itemId);
                if (ol == null)
                    _listOfItems.Add(new OrderItem(itemId));
                else
                    ol.IncreaseAmount();
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