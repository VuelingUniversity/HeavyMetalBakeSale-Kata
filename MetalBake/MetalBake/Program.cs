using MetalBake.Models;
using System;
using System.Collections.Generic;

namespace MetalBake
{
    class Program
    {
        static void Main(string[] args)
        {
           Items item = new Items();
           var cake= item.ItemName("C");
           Console.WriteLine(cake);
          
           //Calcular el precio por elemento
           Orders orders = new Orders();
 
           var tuple =orders.CalculatePriceByItem("M",40);
           Console.WriteLine(tuple.Item2.ToString());

            //Calcular el total del la cuenta
            List<Tuple<string, double>> _priceByItems = new List<Tuple<string, double>>();
            _priceByItems.Add(orders.CalculatePriceByItem("M", 40));
            _priceByItems.Add(orders.CalculatePriceByItem("W", 10));
            _priceByItems.Add(orders.CalculatePriceByItem("C", 4));
            double price2 = 0;
            foreach(var i in _priceByItems)
            {
               price2 += i.Item2;
            }
            Console.WriteLine(price2);
                


            /* var product = string.Empty;
             var bakery = new Dictionary<string, string>()
             {
                 { "C", "Brownie" },
                 { "A", "Cake" },
                 { "M", "Muffin"},
             };

             Console.WriteLine("What is your choice?:\n");
             Console.WriteLine(@"Enter your product 
             C = Brownie, ");

             product = Console.ReadLine();

             if (product == "C")
             {
                 Console.WriteLine("Product price is:" + bakery[product]);
             }*/

            //  CalculatePriceByItem(Items items, int quantity)


            /*AskUserWhatSheWants();
            CheckIfWeHaveStock();
            AskHerForMoney();
            ChekPaymenty();
            SayGoodBye();*/

        }

        private static void CalculatePrice(int Short, int quiantity)
        {
          
        }
    }
}
