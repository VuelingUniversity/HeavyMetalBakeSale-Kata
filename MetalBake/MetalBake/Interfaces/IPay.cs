using MetalBake.Models;

namespace MetalBake.Interfaces {
    interface IPay {
        void ClientPayToMetalBake(double cost, MetalBakeAccount metalBakeAccount, Client client, Order order);
        void MetalBakeRefundToClient(double cost, MetalBakeAccount metalBakeAccount, Client client, Order order);
    }
}
