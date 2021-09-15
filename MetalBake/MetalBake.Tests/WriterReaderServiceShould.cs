using System;
using System.Collections.Generic;
using Xunit;
using MetalBake.Interfaces;
using MetalBake.Models;
using MetalBake.Servicios;

namespace MetalBake.Tests {
    public class WriterReaderServiceShould {
        List<Item> VendingItems = WriterReaderService.FillItemsList();
        WriterReaderService ReaderService = new WriterReaderService();

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
        [Fact]
        public void TestWriteOrder() {
            Order order1 = new Order(1, VendingItems);
            WriterReaderService.WriteOrder(client1, order1);
        }
    }
}
