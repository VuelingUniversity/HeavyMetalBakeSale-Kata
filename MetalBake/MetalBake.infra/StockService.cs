using MetalBake.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.infra
{
    public class StockService
    {
        private stockService.IService _stockService;

        public StockService()
        {
            _stockService = new stockService.ServiceClient();
        }

        public List<ItemStock> GetAllStock()
        {
            return _stockService.GetAllStock().Select(item => new ItemStock { ItemId = item.ItemId, Stock = item.Stock }).ToList();
        }

        public ItemStock GetItemStock(string itemId)
        {
            var item = _stockService.GetItemStock(itemId);
            return new ItemStock { ItemId = item.ItemId, Stock = item.Stock };
        }

        public void ReduceItemStock(string itemId, int cuantity)
        {
            _stockService.ReduceItemStock(itemId, cuantity);
        }

        public bool SetItemStock(string itemId, int cuantity)
        {
            return _stockService.ChangeItemStock(itemId, cuantity);
        }
    }
}