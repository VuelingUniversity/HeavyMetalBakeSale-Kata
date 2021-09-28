using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MetalBake;
using MetalBandBakery; 
namespace MetalBandBakery.Test
{
    [TestClass]
    public class StockTests
    {
        string[] items = new string[] { "C", "W", "M" };
        string[] itemsMock = new string[] { "C", "P" };
        StockService show = new StockService();
        [TestMethod]
        public void ShowStockTest()
        {          
            show.ShowStock(items);
        }
        [TestMethod]
        public void ShowStockTestMock()
        {          
            show.ShowStock(itemsMock);
        }
        [TestMethod] 
        public void CheckStockTest()
        {
            show.CheckStock(items);
        }
        [TestMethod]
        public void CheckStockMockTest()
        {
            show.CheckStock(itemsMock);
        }
    }
}
