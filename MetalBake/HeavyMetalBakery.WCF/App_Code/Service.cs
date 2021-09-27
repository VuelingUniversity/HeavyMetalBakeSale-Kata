namespace HeavyMetalBakery.WCF
{
    public class Service : IService
    {
        private readonly IItemRepository _svc;

        public Service()
        {
            _svc = new InventoryRepository();
        }

        public bool AddStock(string itemId, int amount)
        {
            if (!InventoryRepository.Stock.ContainsKey(itemId))
                return false;

            if (amount <= 0)
                return false;

            InventoryRepository.Stock[itemId] = amount;
            return true;
        }

        public int CheckStock(string itemId)
        {
            var item = _svc.GetItem(itemId);
            if (item == null)
                return 0;
            return item.Quantity;
        }

        public bool ReduceStock(string itemId)
        {
            var item = _svc.GetItem(itemId);
            if (item.Quantity > 0)
            {
                item.Quantity--;
                _svc.Save(item);
                return true;
            }
            return false;
        }

        public int[] GetStocks()
        {
            int[] stocks = new int[InventoryRepository.Stock.Count];
            int cont = 0;
            foreach (var i in InventoryRepository.Stock)
            {
                stocks[cont] = i.Value;
                cont++;
            }
            return stocks;
        }

        public string[] GetShorts()
        {
            string[] shorts = new string[InventoryRepository.Stock.Count];
            int cont = 0;
            foreach (var i in InventoryRepository.Stock)
            {
                shorts[cont] = i.Key.ToString();
                cont++;
            }
            return shorts;
        }
    }
}