using MetalBake.Interfaces;
using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MetalBake.Servicios {
    class ReaderService : IReader{
        public void DisplayProducts(List<Item> vendingItems) {
            Console.WriteLine(@"ID     Name     Price     Quantity");
            foreach (var v in vendingItems) {
                Console.WriteLine($"{v.ItemId}     {v.Name}     {v.Price}     {v.Quantity}");
            }
        }
        public void DisplayProducts() {
            var directory = Directory.GetFiles(@"C:");
            foreach(var jsonTxt in directory) {
                Console.WriteLine(jsonTxt);
            }
        } 
    }
}
