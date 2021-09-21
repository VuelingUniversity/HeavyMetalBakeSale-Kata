using System;
using System.Collections.Generic;
using Xunit;
using MetalBake.Interfaces;
using MetalBake.Models;
using MetalBake.Servicios;
using BakeryStockLibrary;

namespace MetalBake.Tests {
    public class PayServiceShould {
        List<Item> VendingItems = WriterReaderService.FillItemsList();
        WriterReaderService ReaderService = new WriterReaderService();
        PayService payService = new PayService();
        [Fact]
        public void ClientPayToMetalBakeShould() {
            Client client = new Client("1", 100.00);
            MetalBakeAccount metalBakeAccount = new MetalBakeAccount(100, "ES2820958297603648596978");
            Order order = new Order(1, VendingItems);
            payService.ClientPayToMetalBake(1, metalBakeAccount, client, order);
        }
        [Fact]
        public void MetalBakeRefundToClient() {
            Client client = new Client("1", 100.00);
            MetalBakeAccount metalBakeAccount = new MetalBakeAccount(100, "ES2820958297603648596978");
            Order order = new Order(1, VendingItems);
            payService.MetalBakeRefundToClient(1, metalBakeAccount, client, order);
        }
    }
}