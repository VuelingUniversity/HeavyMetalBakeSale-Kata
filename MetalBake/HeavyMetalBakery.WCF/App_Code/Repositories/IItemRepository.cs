using System.Collections.Generic;

namespace HeavyMetalBakery.WCF
{
    public interface IItemRepository
    {
        Item GetItem(string itemId);

        bool Save(Item item);

        bool Exists(string itemId);

        Dictionary<string, int> GetStock();
    }
}