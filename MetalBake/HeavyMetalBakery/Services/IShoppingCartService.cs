using HeavyMetalBakery.Domain;
using System.Collections.Generic;

namespace HeavyMetalBakery.Services
{
    public interface IShoppingCartService
    {
        bool CheckStock(string itemId);

        void ReduceStock(string itemId);

        void AddStock(string itemId, int amount);

        List<OrderItem> GetCart();
    }
}