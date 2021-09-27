using HeavyMetalBakery.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
