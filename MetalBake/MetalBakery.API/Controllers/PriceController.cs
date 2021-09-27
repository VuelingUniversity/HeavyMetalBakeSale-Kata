using MetalBakery.API.Dto;
using MetalBakery.API.IRepository;
using MetalBakery.API.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBakery.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PriceController
    {
        private readonly ILogger<PriceController> _logger;

        public PriceController(ILogger<PriceController> logger)
        {
            _logger = logger;
        }
		[HttpGet]
		public IEnumerable<ItemPriceDto> Get()
		{
			IItemPriceRepository repository = new ItemPriceRepository();
			var p = repository.GetAll();
			return p;
		}

		[HttpGet("{itemId}")]
		public ItemPriceDto Get(string itemId)
		{
			IItemPriceRepository repository = new ItemPriceRepository();
			var itemPrice = repository.Get(itemId);
			return itemPrice;
		}

	}
}
