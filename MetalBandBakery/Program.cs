using MetalBake;
using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MetalBandBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keys = ItemsToPurchase();
            StockService stockService = new StockService();
            stockService.ShowStock(keys);
            stockService.CheckStock(keys);
            PriceService priceService = new PriceService();
            decimal totalToPay = priceService.TotalToPay(keys);
            CalculateChange change = new CalculateChange();
            decimal amountToPay = change.AmountToPaid();
            change.CalculateChangeToReturn(amountToPay, totalToPay);
            //AddStock();
        }

        public static string[] ItemsToPurchase()
        {
            Console.WriteLine($@"Choose a product:
                            B  |  Brownie  |  0.65$
                            M  |  Mufflin  |  1.00$
                            C  | Cacke Pop |  1.35$
                            W  |   Water   |  1.50$");
            string[] keysPickUp = Console.ReadLine().ToUpper().Split(',');
            return keysPickUp;
        }
    }
}
