using MetalBake.ApiPrices.Models;
using MetalBake.ApiPrices.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBake.ApiPrices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PricesController : ControllerBase
    {
        private IPriceService _priceService;

        public PricesController()
        {
            _priceService = new PriceService();
        }

        [HttpGet]
        public List<ItemPrice> GetAllPrices()
        {
            return _priceService.GetAllPrices();
        }

        [HttpGet("{itemId}")]
        public ItemPrice GetItemPrice(string itemId)
        {
            return _priceService.GetItemPrice(itemId);
        }

        [Route("updatePrice")]
        [HttpPost]
        public bool UpdateItemPrice(ItemPrice item)
        {
            return _priceService.UpdateItemPrice(item);
        }
    }
}