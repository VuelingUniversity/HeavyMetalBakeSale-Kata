using MetalBake.ApiPrices.Models;
using MetalBake.ApiPrices.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBake.ApiPrices.Services
{
    public class PriceService : IPriceService
    {
        private IPriceRepository _priceRepository = new PriceRepository();

        public bool ExistsItem(string itemId)
        {
            throw new NotImplementedException();
        }

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