using System;

namespace MetalBake.Models {
    public class Client {
        #region Variables
        private string _clientId;
        private double _clientBalance;
        #endregion
        #region Getters y Setters
        public string ClientId { get => _clientId; set => _clientId = value; }
        public double ClientBalance { get => _clientBalance; set => _clientBalance = value; }
        #endregion
        #region Constructor
        public Client(string clientId, double clientBalance) {
            _clientId = clientId;
            _clientBalance = clientBalance;
        }
        #endregion
        #region Metodos
        public void Pay(double cost) {
            Console.WriteLine($"The client payed {cost} euros");
            this.ClientBalance -= cost;
        }
        public void Collect(double cost) {
            Console.WriteLine($"The client collected {cost} euros");
            this.ClientBalance += cost;
        }
        #endregion
    }
}
