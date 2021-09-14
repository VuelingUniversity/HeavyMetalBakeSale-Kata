using MetalBake.Interfaces;
using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Servicios {
    class PayService : IPay{
        public void ClientPayToMetalBake(double cost, MetalBakeAccount metalBakeAccount, Client client) {
            client.Pay(cost);
            metalBakeAccount.Collect(cost);
        }
        public void MetalBake(double cost, MetalBakeAccount metalBakeAccount, Client client) {
            client.Collect(cost);
            metalBakeAccount.Refund(cost);
        }
    }
}
