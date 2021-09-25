using MetalBake.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.core.Services
{
    public interface IPriceService
    {
        List<ItemPrice> GetAllPrices();

        decimal GetItemPrice(string itemId);

        bool UpdateItemPrice(ItemPrice item);
    }
}