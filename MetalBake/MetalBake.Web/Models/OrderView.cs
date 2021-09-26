using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetalBake.Web.Models
{
    public class OrderView
    {
        public List<string> Summary { get; set; }
        public List<string> Errors { get; set; }
        public decimal TotalPrice { get; set; }
    }
}