using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    class Muffin :IStockable
    {
        public string GetName()
        {
            return "Brownie";
        }

        public decimal GetPrice()
        {
            return 0.65M;
        }
        public int GetAmount()
        {
            return 40;
        }
    }
}
