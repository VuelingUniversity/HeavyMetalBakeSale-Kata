using MetalBake.core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MetalBake.core.UnitTest
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void Test_Calculate_Order_Price()
        {
            Order order = new Order();
            order.AddOrderLine(new OrderLine { Id = "M", Cuantity = 5, Price = 1 });
            Assert.AreEqual(5, order.CalculateOrderPrice());
        }
    }
}