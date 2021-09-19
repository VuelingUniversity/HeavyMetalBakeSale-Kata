using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    internal class Muffin : IProductable
    {
        public char ShortName { get; set; }
        public string Name { get; set; }

        public Muffin()
        {
            ShortName = 'M';
            Name = "Muffin";
        }
    }
}