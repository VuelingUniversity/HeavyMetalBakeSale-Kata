using HeavyMetalBakery.Services;
using System;

namespace HeavyMetalBakery.Infraestructure.Repository.HTTP
{
    public class SoapStockService : IStockService
    {
        public void AddStock(string itemId, int amount)
        {
            Inventory.WCF.IService wcfService = new Inventory.WCF.ServiceClient();
            wcfService.AddStock(itemId, amount);
        }

        public bool CheckStock(string itemId)
        {
            throw new NotImplementedException();
        }

        public void ReduceStock(string itemId)
        {
            throw new NotImplementedException();
        }
    }
}