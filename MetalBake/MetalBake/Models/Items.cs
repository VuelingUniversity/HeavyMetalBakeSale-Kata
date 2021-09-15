using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
   public class Items
    {
        public Items(int id, string name, decimal unitPrice)
        {
            Id = id;
            Name = name;
            UnitPrice = unitPrice;
           
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int IdStock { get; set; }
        public Stock Stock { get; set; }
       

    }
}
