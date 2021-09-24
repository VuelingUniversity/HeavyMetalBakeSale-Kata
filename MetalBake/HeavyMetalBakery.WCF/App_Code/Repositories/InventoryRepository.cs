using System.Collections.Generic;

namespace HeavyMetalBakery.WCF
{
    public class InventoryRepository : IItemRepository
    {
        private static readonly Dictionary<string, int> stock = Setup();

        public static Dictionary<string, int> Stock { get { return stock; } }

        private static Dictionary<string, int> Setup()
        {
            var stockDatabase = new Dictionary<string, int>();
            stockDatabase.Add("B", 30);
            stockDatabase.Add("M", 30);
            stockDatabase.Add("C", 30);
            stockDatabase.Add("W", 30);
            return stockDatabase;
        }

        public Dictionary<string, int> GetStock()
        {
            return Stock;
        }

        public Item GetItem(string itemId)
        {
            if (!Exists(itemId))
                return null;
            return new Item
            {
                ItemId = itemId,
                Quantity = Stock[itemId]
            };
        }

        public bool Save(Item item)
        {
            if (!Exists(item.ItemId))
                return false;
            Stock[item.ItemId] = item.Quantity;
            return true;
        }

        public bool Exists(string itemId)
        {
            return Stock.ContainsKey(itemId);
        }
    }
}