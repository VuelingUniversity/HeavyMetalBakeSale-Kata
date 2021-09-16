using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    public interface IOrderable
    {
        public bool CheckOrder();
        public int OrderItems();

    }
}
