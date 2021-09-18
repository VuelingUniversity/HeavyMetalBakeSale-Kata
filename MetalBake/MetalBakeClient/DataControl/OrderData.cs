using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.DataControl {
    class OrderData {
        #region Variables
        private DateTime _orderDate;
        private Client _client;
        private Order _order;
        #endregion
        #region Getters Y Setters
        public DateTime OrderDate { get => _orderDate; set => _orderDate = value; }
        internal Client Client { get => _client; set => _client = value; }
        internal Order Order { get => _order; set => _order = value; }
        #endregion
        #region Constructor
        public OrderData(DateTime orderDate, Client client, Order order) {
            _orderDate = orderDate;
            _client = client;
            _order = order;
        }
        #endregion
    }
}
