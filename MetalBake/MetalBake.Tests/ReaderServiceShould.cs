using System;
using System.Collections.Generic;
using Xunit;
using MetalBake.Interfaces;
using MetalBake.Models;
using MetalBake.Servicios;

namespace MetalBake.Tests {
    public class ReaderServiceShould {
        List<Item> VendingItems = WriterReaderService.FillItemsList();
        WriterReaderService ReaderService = new WriterReaderService();
        MetalBakeAccount MetalBakeAccount1 = new MetalBakeAccount(0.0, "ES2820958297603648596978");
        MetalBakeAccount MetalBakeAccount2 = new MetalBakeAccount(10.0, "GB20BARC20031882973364");
        Client client1 = new Client("1", 100);
        Client client2 = new Client("2", 0);
        [Fact]
        public void TestDisplayProducts() {

            ReaderService.DisplayProducts(VendingItems);
        }
        [Fact]
        public void TestFillItemList() {
            VendingItems = WriterReaderService.FillItemsList();
        }
        [Fact]
        public void DisplayJsonProducts() {
            ReaderService.DisplayJsonProducts();
        }
        [Theory]
        [InlineData(1.00, MetalBakeAccount1, client1, 1)]
        [InlineData(1.60, MetalBakeAccount2, client2, 1)]
        public void TestWriteOrder(double cost, MetalBakeAccount metalBakeAccount, Client client, Order order) {
            WriterReaderService.WriteOrder(cost, metalBakeAccount, client, order);
        }
    }
}
