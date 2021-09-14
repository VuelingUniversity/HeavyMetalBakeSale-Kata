using System;

namespace MetalBake.Models {
    class Client {
        #region Variables
        private string _clientId;
        private Double _clientBalance;
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
    }
}
