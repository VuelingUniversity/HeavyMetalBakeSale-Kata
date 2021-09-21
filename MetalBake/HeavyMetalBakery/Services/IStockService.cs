namespace HeavyMetalBakery.Services
{
    internal interface IStockService
    {
        bool CheckStock(string itemId);

        void ReduceStock(string itemId);

        void AddStock(string itemId, int amount);
    }
}