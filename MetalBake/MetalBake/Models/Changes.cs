using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
   public class Changes
    {
        public Changes(int id, Sales sales, decimal returnMoney)
        {
            Id = id;
            Sales = sales;
            ReturnMoney = returnMoney;
        }

        public int Id { get; set; }
        public Sales Sales { get; set; }
        public decimal ReturnMoney { get; set; }
    }
}
