﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    public interface IChangeable
    {
        public bool CheckChange();
        public decimal ReturnChange();
    }
}
