using MetalBake.ApiPrices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBake.ApiPrices.Repositories
{
    public interface IPriceRepository
    {
        ItemPrice GetItemPrice(string itemId);

        List<ItemPrice> GetAllPrices();

        void UpdateItemPrice(ItemPrice item);
    }
}