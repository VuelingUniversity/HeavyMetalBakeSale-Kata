namespace MetalBake
{
    public interface IStockService
    {
        void CheckStock(string[] itemId);
        void ShowStock(string[] itemId);
    }
}