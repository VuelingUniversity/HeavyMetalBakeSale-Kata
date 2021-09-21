namespace HeavyMetalBakery.Services
{
    interface IStockService
    {
        bool CheckStock(string itemId);
        void ReduceStock(string itemId);
        void AddStock(string itemId, int amount);
    }
}
