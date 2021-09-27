using HeavyMetalBakery.Infraestructure.Inventory.WCF;
using HeavyMetalBakery.Services;
using System;

namespace HeavyMetalBakery.Infraestructure.Repository.HTTP
{
    public class SoapStockService : IStockService
    {
        public void AddStock(string itemId, int amount)
        {
            IService wcfService = new ServiceClient();
            wcfService.AddStock(itemId, amount);
        }

        public bool CheckStock(string itemId)
        {
            IService wcfService = new ServiceClient();
            return (wcfService.CheckStock(itemId) > 0);
        }

        public void ReduceStock(string itemId)
        {
            IService wcfService = new ServiceClient();
            wcfService.ReduceStock(itemId);
        }
    }
}