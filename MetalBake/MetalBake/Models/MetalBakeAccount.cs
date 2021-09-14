using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models {
    class MetalBakeAccount {
        #region Variables
        private double _metalBakeBalance;
        private string _iban;
        #endregion
        #region Getters y Setters
        public double MetalBakeBalance { get => _metalBakeBalance; set => _metalBakeBalance = value; }
        public string Iban { get => _iban; set => _iban = value; }
        #endregion
        #region Constructor
        public MetalBakeAccount(double metalBakeBalance, string iban) {
            _metalBakeBalance = metalBakeBalance;
            _iban = iban;
        }
        #endregion
        #region Metodos
        public void Collect(double cost) {
            Console.WriteLine($"The Bank collected {cost} euros");
            this._metalBakeBalance += cost;
        }
        public void Refund(double cost) {
            Console.WriteLine($"The client refunded {cost} euros");
            this.MetalBakeBalance -= cost;
        }
        #endregion
    }
}
