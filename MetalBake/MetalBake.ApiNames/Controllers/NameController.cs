using MetalBake.ApiNames.Models;
using MetalBake.ApiNames.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBake.ApiNames.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        private INameService _nameService = new NameService();

        [HttpGet]
        public List<ItemName> GetAllNames()
        {
            return _nameService.GetAllNames();
        }

        [HttpGet("{itemId}")]
        public ItemName GetItemName(string itemId)
        {
            return _nameService.GetItemName(itemId);
        }

        [Route("updatePrice")]
        [HttpPost]
        public bool ChangeItemName(ItemName item)
        {
            return _nameService.ChangeItemName(item);
        }
    }
}