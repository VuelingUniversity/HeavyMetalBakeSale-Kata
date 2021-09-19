using MetalBake.Services;
using System;
using System.Text;

namespace MetalBake
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            InvetoryService ser = new InvetoryService();
            PurchaseService ps = PurchaseService.GetInstance();
            Console.WriteLine("Which products do you want? ");
            string items = Console.ReadLine();
            StringBuilder receipt = new StringBuilder();
            string orderItems = ser.InventoryFilter(items);
            decimal totalPrice = ps.OrderPrice(orderItems);
            Console.WriteLine($"Total price: ${totalPrice}");
            receipt.Append($"Buy: > {orderItems}, Total > ${totalPrice}");
            Console.WriteLine("Money:");
            decimal payed = 0;
            Decimal.TryParse(Console.ReadLine(), out payed);
            receipt.Append($", Payed > ${payed}");
            if (payed >= totalPrice)
            {
                decimal exchange = ps.Purchase(totalPrice, payed);
                if (exchange != 0)
                {
                    receipt.Append($", Cambio > ${exchange}");
                }
                receipt.Append(", Completed.");
            }
            else
            {
                receipt.Append(", It's not enough");
            }
            Console.WriteLine(receipt.ToString());
        }
    }
}