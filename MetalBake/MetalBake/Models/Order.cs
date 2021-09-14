using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models {
    class Order {
        #region Variables
        private int _orderId;
        private List<Item> _itemList;
        #endregion
        #region Getters y Setters
        public int OrderId { get => _orderId; set => _orderId = value; }       
        #endregion
        #region Constructor
        public Order(int orderId, List<Item>itemList) {
            _orderId = orderId;
            _itemList = itemList;
        }
        #endregion
    }
}
