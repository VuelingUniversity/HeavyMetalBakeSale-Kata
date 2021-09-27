using MetalBake.core.Models;
using MetalBake.core.Services;
using MetalBake.infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.ApplicationServices
{
    public class ItemService : IItemService
    {
        private INameService _nameService;
        private IPriceService _priceService;
        private IStockService _stockService;

        public ItemService()
        {
            _nameService = new NameService();
            _priceService = new PriceService();
            _stockService = new StockService();
        }

        public List<Item> GetAllItems()
        {
            List<Item> ListOfItems = new List<Item>();
            var itemNames = _nameService.GetAllNames();

            foreach (var item in itemNames)
            {
                var price = _priceService.GetItemPrice(item.ItemId);
                var stock = _stockService.GetItemStock(item.ItemId);
                var newItem = new Item { ItemId = item.ItemId, Name = item.Name, Price = price, Stock = stock };
                ListOfItems.Add(newItem);
            }

            return ListOfItems;
        }
    }
}