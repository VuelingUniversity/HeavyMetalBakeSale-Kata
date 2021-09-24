using MetalBake.ApiPrices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBake.ApiPrices.Services
{
    public interface IPriceService
    {
        ItemPrice GetItemPrice(string itemId);

        List<ItemPrice> GetAllPrices();

        bool UpdateItemPrice(ItemPrice item);

        bool ExistsItem(string itemId);
    }
}