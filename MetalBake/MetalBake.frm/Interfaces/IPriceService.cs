﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.frm.Interfaces
{
    public interface IPriceService
    {
        decimal GetItemPrice(string itemId);
    }
}