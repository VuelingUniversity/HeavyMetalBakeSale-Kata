using MetalBake.Models;
using System.Collections.Generic;

namespace MetalBake.Interfaces {
    interface IMenu {
        void Display();
        List<Item> FillItemsList();
    }
}
