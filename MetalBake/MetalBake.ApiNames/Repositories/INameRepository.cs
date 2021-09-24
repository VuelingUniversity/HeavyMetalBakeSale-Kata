using MetalBake.ApiNames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBake.ApiNames.Repositories
{
    public interface INameRepository
    {
        ItemName GetItemName(string itemId);

        List<ItemName> GetAllNames();

        void ChangeItemName(ItemName item);
    }
}