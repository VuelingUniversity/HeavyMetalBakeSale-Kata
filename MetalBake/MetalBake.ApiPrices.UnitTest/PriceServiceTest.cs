using MetalBake.ApiPrices.Models;
using MetalBake.ApiPrices.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MetalBake.ApiPrices.UnitTest
{
    [TestClass]
    public class PriceServiceTest
    {
        public string ReadFile()
        {
            string _filePath = @"C:\Users\nettrim\Desktop\Proyectos\Files\prices.json";
            return File.ReadAllText(_filePath);
        }

        public IPriceService GetSut()
        {
            return new PriceService();
        }

        [TestMethod]
        public void Test_Get_All_Prices()
        {
            IPriceService service = GetSut();
            List<ItemPrice> servicePrices = service.GetAllPrices();
            string json = JsonConvert.SerializeObject(servicePrices);
            Assert.AreEqual(json, ReadFile());
        }

        [TestMethod]
        public void Test_Get_Item_Price()
        {
            ItemPrice itemPrice = GetSut().GetItemPrice("M");
            List<ItemPrice> jsonPrices = JsonConvert.DeserializeObject<List<ItemPrice>>(ReadFile());
            decimal price = jsonPrices.Where(item => item.ItemId == "M").Select(item => item.Price).First();
            Assert.AreEqual(price, itemPrice.Price);
        }

        [TestMethod]
        public void Test_Change_Item_Price()
        {
            IPriceService nameService = GetSut();
            ItemPrice itemPrice = new ItemPrice();
            itemPrice.ItemId = "B";
            itemPrice.Price = 2;
            nameService.UpdateItemPrice(itemPrice);
            ItemPrice newPrice = nameService.GetItemPrice("B");
            Assert.AreEqual(2, newPrice.Price);
        }
    }
}