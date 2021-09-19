using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Cake_Pop : IProductable
    {
        public char ShortName { get; set; }
        public string Name { get; set; }

        public Cake_Pop()
        {
            ShortName = 'C';
            Name = "Cake_Pop";
        }
    }
}