using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Water : IStockable
    {
        public string GetName()
        {
            return "Water";
        }

        public decimal GetPrice()
        {
            return 1.50M;
        }
        public int GetAmount()
        {
            return 30;
        }
    }
}
