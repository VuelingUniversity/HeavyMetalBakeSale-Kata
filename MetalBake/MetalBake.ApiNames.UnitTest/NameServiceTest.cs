using MetalBake.ApiNames.Models;
using MetalBake.ApiNames.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MetalBake.ApiNames.UnitTest
{
    [TestClass]
    public class NameServiceTest
    {
        public string ReadFile()
        {
            string _filePath = @"C:\Users\nettrim\Desktop\Proyectos\Files\names.json";
            return File.ReadAllText(_filePath);
        }

        public INameService GetSut()
        {
            return new NameService();
        }

        [TestMethod]
        public void Test_Get_All_Names()
        {
            INameService service = GetSut();
            List<ItemName> serviceNames = service.GetAllNames();
            string json = JsonConvert.SerializeObject(serviceNames);
            Assert.AreEqual(json, ReadFile());
        }

        [TestMethod]
        public void Test_Get_Item_Name()
        {
            ItemName itemName = GetSut().GetItemName("B");
            List<ItemName> jsonPrices = JsonConvert.DeserializeObject<List<ItemName>>(ReadFile());
            string name = jsonPrices.Where(item => item.ItemId == "B").Select(item => item.Name).First();
            Assert.AreEqual(name, itemName.Name);
        }

        [TestMethod]
        public void Test_Change_Item_Name()
        {
            INameService nameService = GetSut();
            ItemName itemName = new ItemName();
            itemName.ItemId = "B";
            itemName.Name = "Biscuits";
            nameService.ChangeItemName(itemName);
            ItemName newName = nameService.GetItemName("B");
            Assert.AreEqual("Biscuits", newName.Name);
        }
    }
}