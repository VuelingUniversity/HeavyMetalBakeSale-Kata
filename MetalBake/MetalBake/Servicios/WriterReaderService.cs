using MetalBake.DataControl;
using MetalBake.Interfaces;
using MetalBake.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
        public static List<Item> FillItemsList() {
            List<Item> ret = new List<Item>();
            Item Brownie = new Item("B", "Brownie ", 0.65, 40);
            Item Muffin = new Item("M", "Muffin  ", 1.00, 36);
            Item CakePop = new Item("C", "Cake Pop", 1.35, 24);
            Item Water = new Item("W", "Water   ", 1.50, 30);
            ret.Add(Brownie);
            ret.Add(Muffin);
            ret.Add(CakePop);
            ret.Add(Water);
            return ret;
        }
        public static void WriteOrder(double cost, MetalBakeAccount metalBakeAccount, Client client, Order order) {
            OrderData orderData = new OrderData(DateTime.Now, client, order);
            string ToJson = JsonConvert.SerializeObject(orderData);
            File.WriteAllText($"C:\\order{DateTime.Now.Day}/{DateTime.Now.Hour}:{DateTime.Now.Second}.json", ToJson);
        }
    }
}
