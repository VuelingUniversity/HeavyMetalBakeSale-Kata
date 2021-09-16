using MetalBlake.Domain.Enums;
using MetalBlake.Domain.Models;
using MetalBlake.Domain.Services;
using System;

namespace MetalBake
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = ProductFactory.GetInstance();
            var service = MachineService.GetInstance();
            Machine myMachine = new Machine();
            Order order = new Order();
            myMachine.ProductList.Add(factory.Build(ProductOptions.Brownie, 40));
            myMachine.ProductList.Add(factory.Build(ProductOptions.Muffin, 36));
            myMachine.ProductList.Add(factory.Build(ProductOptions.CakePop, 24));
            myMachine.ProductList.Add(factory.Build(ProductOptions.Water, 30));

            while (true)
            {
                Console.WriteLine("Items to Purchase?");
                string msg = Console.ReadLine();
                order.ListOrders = service.ParseOrders(msg);
                service.BuyProduct(order, myMachine, 5);
                myMachine.ShowProducts();

            }


        }
    }
}
