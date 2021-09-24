using MetalBake.ApiNames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBake.ApiNames.Repositories
{
    public class NameRepository : INameRepository
    {
        public bool ChangeItemName(ItemName item)
        {
            throw new NotImplementedException();
        }

        public List<ItemName> GetAllNames()
        {
            throw new NotImplementedException();
        }

        public ItemName GetItemName(string itemId)
        {
            throw new NotImplementedException();
        }
    }
}