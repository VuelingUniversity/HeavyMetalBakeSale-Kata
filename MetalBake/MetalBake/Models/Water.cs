using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Water : IProductable
    {
        public char ShortName { get; set; }
        public string Name { get; set; }

        public Water()
        {
            ShortName = 'W';
            Name = "Water";
        }
    }
}