using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Cake_Pop : IStockable
    {
        public string GetName()
        {
            return "Cake_Pop";
        }

        public decimal GetPrice()
        {
            return 1.35M;
        }
        public int GetAmount()
        {
            return 24;
        }
    }
}
