using MetalBake.ApiNames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBake.ApiNames.Services
{
    public interface INameService
    {
        ItemName GetItemName(string itemId);

        List<ItemName> GetAllNames();

        bool ChangeItemName(ItemName item);

        bool ExistsItem(string itemId);
    }
}