namespace MetalBake
{
    public interface IStockService
    {
        void CheckStock(string[] itemId);
        void ShowStock(string[] itemId);
        void ReducedStock(string[] itemId);
        void AddStock(string[] itemId);
    }
}