using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Stock
    {
        public Stock(int id, Items item, int ammount)
        {
            Id = id;
           
            Ammount = ammount;
        }

        public int Id { get; set; }
        public int Ammount { get; set; }
    }
}
