using MetalBake.DataControl;
using MetalBake.Interfaces;
using MetalBake.Models;
using Newtonsoft.Json;
using System;
using System.IO;

namespace MetalBake.Servicios {
    class PayService : IPay {
        public void ClientPayToMetalBake(double cost, MetalBakeAccount metalBakeAccount, Client client, Order order) {
            client.Pay(cost);
            metalBakeAccount.Collect(cost);
            OrderData orderData = new OrderData(DateTime.Now, client, order);
            string ToJson = JsonConvert.SerializeObject(orderData);
            File.WriteAllText(@"C:\order.json", ToJson);
        }
        public void MetalBakeRefundToClient(double cost, MetalBakeAccount metalBakeAccount, Client client, Order order) {
            client.Collect(cost);
            metalBakeAccount.Refund(cost);
            OrderData orderData = new OrderData(DateTime.Now, client, order);
            string ToJson = JsonConvert.SerializeObject(orderData);
            File.WriteAllText(@"C:\order.json", ToJson);
        }
    }
}
