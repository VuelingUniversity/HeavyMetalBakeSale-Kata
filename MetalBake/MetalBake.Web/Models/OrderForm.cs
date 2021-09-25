using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetalBake.Web.Models
{
    public class OrderForm
    {
        public int Quantity_B { get; set; }
        public int Quantity_C { get; set; }
        public int Quantity_M { get; set; }
        public int Quantity_W { get; set; }
    }
}