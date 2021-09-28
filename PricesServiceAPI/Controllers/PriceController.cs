using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PricesServiceAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace PricesServiceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PriceController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<PriceController> _logger;

        public PriceController(ILogger<PriceController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ItemPrice>Get()
        {
            IItemPriceRepository repository = new ItemPriceRepository();
        }
    }
}
