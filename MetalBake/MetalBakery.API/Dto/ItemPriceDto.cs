using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBakery.API.Dto
{
    public class ItemPriceDto
    {
        [Key]
        public string ItemId { get; set; }
        public decimal Price { get; set; }
    }
}
