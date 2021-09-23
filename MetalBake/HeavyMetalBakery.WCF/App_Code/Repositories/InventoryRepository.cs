using System.Collections.Generic;

namespace HeavyMetalBakery.WCF
{
    public class InventoryRepository : IItemRepository
    {
        private readonly Dictionary<string, int> _stock;

        public InventoryRepository()
        {
            _stock = new Dictionary<string, int>() { { "B", 30 }, { "M", 36 }, { "C", 24 }, { "W", 1 } };
        }

        public Item GetItem(string itemId)
        {
            if (!Exists(itemId))
                return null;
            return new Item
            {
                ItemId = itemId,
                Quantity = _stock[itemId]
            };
        }

        public bool Save(Item item)
        {
            if (!Exists(item.ItemId))
                return false;
            _stock[item.ItemId] = item.Quantity;
            return true;
        }

        public bool Exists(string itemId)
        {
            return _stock.ContainsKey(itemId);
        }
    }
}