using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetalBake.Web.Models
{
    public class OrderForm
    {
        public string ItemId { get; set; }
        public int Quantity { get; set; }
    }
}