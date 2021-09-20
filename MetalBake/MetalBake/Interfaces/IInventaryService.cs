using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    public interface IInventaryService
    {
        public bool CheckIfProductIsInStock(Items item);
        public void ReduceStock(Items item);
        public void AddStock(Items product);
    }
}
