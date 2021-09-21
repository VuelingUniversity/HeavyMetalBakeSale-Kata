using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI;

namespace WebApi {
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase {
        [HttpGet]
        public IEnumerable<ItemPrice> Get() {
            IItemPriceRepository repository = new ItemPriceRepository();
            var p = repository.GetAll();
            return p;
        }

        [HttpGet("{itemId}")]
        public ItemPrice Get(string itemId) {
            IItemPriceRepository repository = new ItemPriceRepository();
            var itemPrice = repository.Get(itemId);
            return itemPrice;
        }
    }
}
