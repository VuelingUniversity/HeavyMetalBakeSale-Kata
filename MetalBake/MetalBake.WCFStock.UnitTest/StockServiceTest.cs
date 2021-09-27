using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MetalBake.WCFStock.UnitTest
{
    [TestClass]
    public class StockServiceTest
    {
        public string ReadFile()
        {
            string _filePath = @"C:\Users\nettrim\Desktop\Proyectos\Files\stock.json";
            return File.ReadAllText(_filePath);
        }

        public StockService.IService GetSut()
        {
            return new StockService.ServiceClient();
        }

        [TestMethod]
        public void Test_Get_All_Stock()
        {
            StockService.ItemStock[] stock = GetSut().GetAllStock();
            string jsonService = JsonConvert.SerializeObject(stock);
            Assert.AreEqual(ReadFile(), jsonService);
        }

        [TestMethod]
        public void Test_Get_Item_Stock()
        {
            StockService.ItemStock itemStock = GetSut().GetItemStock("B");
            List<StockService.ItemStock> jsonFile = JsonConvert.DeserializeObject<List<StockService.ItemStock>>(ReadFile());
            int jsonStock = jsonFile.Where(item => item.ItemId == "B").Select(item => item.Stock).First();
            Assert.AreEqual(itemStock.Stock, jsonStock);
        }

        [TestMethod]
        public void Test_Set_Item_Stock()
        {
            StockService.IService stockService = GetSut();

            stockService.ChangeItemStock("B", 15);
            int stock = stockService.GetItemStock("B").Stock;
            Assert.AreEqual(15, stock);
        }

        [TestMethod]
        public void Test_Reduce_Item_Stock()
        {
            StockService.IService stockService = GetSut();
            stockService.ChangeItemStock("B", 15);
            stockService.ReduceItemStock("B", 2);
            Assert.AreEqual(13, stockService.GetItemStock("B").Stock);
        }
    }
}