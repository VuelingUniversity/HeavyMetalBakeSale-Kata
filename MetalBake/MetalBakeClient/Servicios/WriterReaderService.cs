using MetalBake.DataControl;
using MetalBake.Interfaces;
using MetalBake.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace MetalBake.Servicios {
    public class WriterReaderService : IReader{
        public void DisplayProducts(List<Item> vendingItems) {
            Console.WriteLine(@"ID     Name     Price     Quantity");
            foreach (var v in vendingItems) {
                Console.WriteLine($"{v.ItemId}     {v.Name}     {v.Price}     {v.Quantity}");
            }
        }
        public void DisplayJsonProducts() {
            var directory = Directory.GetFiles(@"C:");
            foreach(var jsonTxt in directory) {
                Console.WriteLine(jsonTxt);
            }
        }
        public static void WriteOrder(Client client, Order order) {
            OrderData orderData = new OrderData(DateTime.Now, client, order);
            string ToJson = JsonConvert.SerializeObject(orderData);
            File.WriteAllText($"C:\\order{DateTime.Now.Day}-{DateTime.Now.Hour}-{DateTime.Now.Minute}.json", ToJson);
        }
    }
}