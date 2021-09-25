using MetalBake.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.core.Services
{
    public interface INameService
    {
        List<ItemName> GetAllNames();

        string GetItemName(string itemId);

        bool ChangeItemName(ItemName item);
    }
}