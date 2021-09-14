﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
     public interface IStockable
    {
        int GetItemStock(char key);
        void ReduceItemStock(char key, int value);
    }
}
