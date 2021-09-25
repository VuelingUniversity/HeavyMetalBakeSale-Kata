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
            ItemPrice result = _priceRepository.GetItemPrice(itemId);
            return itemId == result.ItemId;
        }

        public List<ItemPrice> GetAllPrices()
        {
            return _priceRepository.GetAllPrices();
        }

        public ItemPrice GetItemPrice(string itemId)
        {
            if (!ExistsItem(itemId))
            {
                return null;
            }
            return _priceRepository.GetItemPrice(itemId);
        }

        public bool UpdateItemPrice(ItemPrice item)
        {
            if (!ExistsItem(item.ItemId))
            {
                return false;
            }
            _priceRepository.UpdateItemPrice(item);
            return true;
        }
    }
}