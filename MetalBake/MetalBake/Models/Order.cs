using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models {
    class Order {
        #region Variables
        private int _orderId;
        private string[] _itemList;
        #endregion
        #region Getters y Setters
        public int OrderId { get => _orderId; set => _orderId = value; }
        public string[] ItemList { get => _itemList; set => _itemList = value; }
        #endregion
        #region Constructor
        public Order(int orderId, string[] stringArray) {
            _orderId = orderId;
            _itemList = stringArray;
        }
        #endregion
    }
}
