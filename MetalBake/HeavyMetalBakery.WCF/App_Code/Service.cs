public class Service : IService
{
    private IItemRepository _svc;

    public Service()
    {
        _svc = new InventoryRepository();
    }

    public void AddStock(string itemId, int amount)
    {
        var item = _svc.GetItem(itemId);
        if (item.Quantity > 0)
        {
            item.Quantity++;
            _svc.Save(item);
        }
    }

    public int CheckStock(string itemId)
    {
        var item = _svc.GetItem(itemId);
        if (item == null)
            return 0;
        return item.Quantity;
    }

    public void ReduceStock(string itemId)
    {
        var item = _svc.GetItem(itemId);
        if (item.Quantity > 0)
        {
            item.Quantity--;
            _svc.Save(item);
        }
    }
}