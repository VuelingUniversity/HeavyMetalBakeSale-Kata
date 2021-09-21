using eavyMetalBakery.Infraestructure.Repository;
using HeavyMetalBakery.Infraestructure.Repository;
using HeavyMetalBakery.Services;

namespace HeavyMetalBakery.Console
{
    internal class Program
    {
        private static IStockService _stockService = new InMemoryStockService();
        private static IPriceService _priceService = new InMemoryPriceService();

        private static void Main(string[] args)
        {
            var application = new Application(_stockService, _priceService);
            application.Run();
        }
    }
}