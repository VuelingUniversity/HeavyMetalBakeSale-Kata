using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    internal interface IProductable
    {
        char ShortName { get; set; }
        string Name { get; set; }
    }
}