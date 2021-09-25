using MetalBake.ApiNames.Models;
using MetalBake.ApiNames.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBake.ApiNames.Services
{
    public class NameService : INameService
    {
        private INameRepository _nameRepository = new NameRepository();

        public bool ExistsItem(string itemId)
        {
            ItemName result = _nameRepository.GetItemName(itemId);
            return itemId == result.ItemId;
        }

        public List<ItemName> GetAllNames()
        {
            return _nameRepository.GetAllNames();
        }

        public ItemName GetItemName(string itemId)
        {
            if (ExistsItem(itemId))
            {
                return null;
            }
            return _nameRepository.GetItemName(itemId);
        }

        public bool ChangeItemName(ItemName item)
        {
            if (!ExistsItem(item.ItemId))
            {
                return false;
            }
            _nameRepository.ChangeItemName(item);
            return true;
        }
    }
}