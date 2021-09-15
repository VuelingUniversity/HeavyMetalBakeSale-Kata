using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Sales
    {
        public Sales(int id, Items item)
        {
            Id = id;
            Item = item;
         
        }

        public int Id { get; set; }
        public int IdItems { get; set; }
        public Items Item { get; set; }
        public int IdCustomers { get; set; }
        public Customers Customers { get; set; }
        

       
   }
}
