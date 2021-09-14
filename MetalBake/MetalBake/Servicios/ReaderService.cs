using MetalBake.Interfaces;
using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Servicios {
    class ReaderService : IReader{
        public void DisplayProducts(List<Item> VendingItems) {
            Console.WriteLine(@"ID     Name     Price     Quantity");
            foreach (var v in VendingItems) {
               
                Console.WriteLine($"{v.ItemId}     {v.Name}     {v.Price}     {v.Quantity}");
            }
        }
    }
}
