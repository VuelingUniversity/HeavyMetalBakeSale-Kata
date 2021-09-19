﻿using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    internal class Brownie : IProductable
    {
        public char ShortName { get; set; }
        public string Name { get; set; }

        public Brownie()
        {
            ShortName = 'B';
            Name = "Brownie";
        }
    }
}