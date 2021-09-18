using MetalBake.Models;
using System.Collections.Generic;

namespace MetalBake.Interfaces {
    interface IReader {
        void DisplayProducts(List<Item> vendingItems);
        void DisplayJsonProducts();
    }
}
