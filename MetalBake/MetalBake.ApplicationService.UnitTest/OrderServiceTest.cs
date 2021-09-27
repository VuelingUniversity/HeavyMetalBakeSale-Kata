using MetalBake.ApplicationServices;
using MetalBake.core.Models;
using MetalBake.core.Services;
using MetalBake.infra;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MetalBake.ApplicationService.UnitTest
{
    [TestClass]
    public class OrderServiceTest
    {
        private IPriceService _priceService = new PriceService();

        public IOrderService GetSut()
        {
            return new OrderService();
        }

        [TestMethod]
        public void Test_Create_Order()
        {
            Order orderTest = new Order();
            orderTest.itemsToBuy = new List<OrderLine>();
            orderTest.itemsToBuy.Add(new OrderLine { Id = "B", Cuantity = 1, Price = _priceService.GetItemPrice("B") });
            string orderTestJson = JsonConvert.SerializeObject(orderTest);

            Order order = GetSut().CreateOrder(new List<Tuple<string, int>> { new Tuple<string, int>("B", 1) });
            string orderJson = JsonConvert.SerializeObject(order);

            Assert.AreEqual(orderTestJson, orderJson);
        }
    }
}