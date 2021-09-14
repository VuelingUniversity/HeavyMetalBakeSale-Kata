using MetalBlake.Domain.Enums;
using MetalBlake.Domain.Models;
using System;

namespace MetalBake
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = ProductFactory.GetInstance();

            Machine myMachine = new Machine();
            myMachine.ProductList.Add(factory.Build(ProductOptions.Brownie, 40));
            myMachine.ProductList.Add(factory.Build(ProductOptions.Muffin, 36));
            myMachine.ProductList.Add(factory.Build(ProductOptions.CakePop, 24));
            myMachine.ProductList.Add(factory.Build(ProductOptions.Water, 30));

            while (true)
            {
                Console.WriteLine("Items to Purchase?");
                string[] shorts = Console.ReadLine().Split(",");
                

            }


        }
    }
}
