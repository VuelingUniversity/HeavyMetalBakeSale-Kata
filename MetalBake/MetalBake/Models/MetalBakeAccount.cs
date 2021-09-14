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
        #endregion
    }
}
