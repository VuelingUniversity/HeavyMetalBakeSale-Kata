using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
   public class Customers
    {
        public Customers(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
