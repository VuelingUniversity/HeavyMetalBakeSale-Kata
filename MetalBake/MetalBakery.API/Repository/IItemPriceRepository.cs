using MetalBakery.API.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBakery.API.Repository
{
    public interface IItemPriceRepository
    {
        ItemPriceDto Get(string itemId);
        bool Save(ItemPriceDto item);

        List<ItemPriceDto> GetAll();
    }
}
