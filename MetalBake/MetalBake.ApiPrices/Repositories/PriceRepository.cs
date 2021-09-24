using MetalBake.ApiPrices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBake.ApiPrices.Repositories
{
    public class PriceRepository : IPriceRepository
    {
        public List<ItemPrice> GetAllPrices()
        {
            throw new NotImplementedException();
        }

        public ItemPrice GetItemPrice(string itemId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateItemPrice(ItemPrice item)
        {
            throw new NotImplementedException();
        }
    }
}