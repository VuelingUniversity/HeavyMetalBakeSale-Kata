using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    public interface IStockable
    {
        public bool CheckStock();
        public int AddStock(List<Items> items, int quantity);
        public int ReduceStock(List<Items> items, int quantity);
    }
}
