using MetalBake.DataControl;
using MetalBake.Interfaces;
using MetalBake.Models;
using Newtonsoft.Json;
using System;
using System.IO;

namespace MetalBake.Servicios {
    public class PayService : IPay {
        public void ClientPayToMetalBake(double cost, MetalBakeAccount metalBakeAccount, Client client, Order order) {
            client.Pay(cost);
            metalBakeAccount.Collect(cost);
            WriterReaderService.WriteOrder(client, order);
        }
        public void MetalBakeRefundToClient(double cost, MetalBakeAccount metalBakeAccount, Client client, Order order) {
            client.Collect(cost);
            metalBakeAccount.Refund(cost);
            WriterReaderService.WriteOrder(client, order);
        }
    }
}
