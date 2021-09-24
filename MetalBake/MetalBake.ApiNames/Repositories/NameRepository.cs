using MetalBake.ApiNames.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBake.ApiNames.Repositories
{
    public class NameRepository : INameRepository
    {
        private static string _filePath = @"../../Files/names.json";

        private List<ItemName> ReadJsonFile()
        {
            string text = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<ItemName>>(text);
        }

        public List<ItemName> GetAllNames()
        {
            return ReadJsonFile();
        }

        public ItemName GetItemName(string itemId)
        {
            List<ItemName> listOfItemNames = ReadJsonFile();
            return listOfItemNames.FirstOrDefault(item => item.ItemId == itemId);
        }

        public void ChangeItemName(ItemName item)
        {
            List<ItemName> listOfItemNames = ReadJsonFile();
            int itemIndex = listOfItemNames.FindIndex(i => i.ItemId == item.ItemId);
            listOfItemNames[itemIndex] = item;
            WriteInFile(listOfItemNames);
        }

        private void WriteInFile(List<ItemName> listOfItemNames)
        {
            var namesJson = JsonConvert.SerializeObject(listOfItemNames);
            File.WriteAllText(_filePath, namesJson);
        }
    }
}