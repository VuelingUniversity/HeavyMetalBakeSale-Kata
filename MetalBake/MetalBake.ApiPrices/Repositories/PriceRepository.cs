using MetalBake.ApiPrices.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBake.ApiPrices.Repositories
{
    public class PriceRepository : IPriceRepository
    {
        private static string _filePath = @"C:\Users\nettrim\Desktop\Proyectos\Files\prices.json";

        private List<ItemPrice> ReadJsonFile()
        {
            string text = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<ItemPrice>>(text);
        }

        public List<ItemPrice> GetAllPrices()
        {
            return ReadJsonFile();
        }

        public ItemPrice GetItemPrice(string itemId)
        {
            List<ItemPrice> listOfItemPrices = ReadJsonFile();
            return listOfItemPrices.FirstOrDefault(item => item.ItemId == itemId);
        }

        public void UpdateItemPrice(ItemPrice item)
        {
            List<ItemPrice> listOfItemPrices = ReadJsonFile();
            int itemIndex = listOfItemPrices.FindIndex(i => i.ItemId == item.ItemId);
            listOfItemPrices[itemIndex] = item;
            WriteInFile(listOfItemPrices);
        }

        private void WriteInFile(List<ItemPrice> listOfItemPrices)
        {
            var pricesJson = JsonConvert.SerializeObject(listOfItemPrices);
            File.WriteAllText(_filePath, pricesJson);
        }
    }
}