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
        private INameService _nameService = new NameService();
        private IPriceService _priceService = new PriceService();
        private IStockService _stockService = new StockService();

        public List<Item> GetAllItems()
        {
            List<Item> ListOfItems = new List<Item>();
            var itemNames = _nameService.GetAllNames();
            var itemPrices = _priceService.GetAllPrices();
            var itemStocks = _stockService.GetAllStock();

            foreach (var item in itemNames)
            {
                var price = itemPrices.FirstOrDefault(i => i.ItemId == item.ItemId);
                var stock = itemStocks.FirstOrDefault(i => i.ItemId == item.ItemId);
                var newItem = new Item { ItemId = item.ItemId, Name = item.Name, Price = price.Price, Stock = stock.Stock };
                ListOfItems.Add(newItem);
            }

            return ListOfItems;
        }
    }
}