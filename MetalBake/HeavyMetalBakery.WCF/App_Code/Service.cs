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
            var item = _svc.GetItem(itemId);
            if (item.Quantity > 0)
            {
                item.Quantity += amount;
                _svc.Save(item);
                return true;
            }
            return false;
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
    }
}