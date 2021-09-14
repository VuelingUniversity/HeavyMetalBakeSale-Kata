using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    class Brownie : IStockable
    {
        public string GetName()
        {
            return "Brownie";
        }

        public decimal GetPrice()
        {
            return 1.00M;
        }
        public int GetAmount()
        {
            return 36;
        }
    }
}
