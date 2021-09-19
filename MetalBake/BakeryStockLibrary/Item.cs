using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BakeryStockLibrary {
    [DataContract]
    public class Item {
        #region Variables
        private string _itemId;
        private string _name;
        private double _price;
        private int _quantity;
        #endregion
        #region Getters y Setters
        public string ItemId { get => _itemId; set => _itemId = value; }
        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        #endregion
        #region Constructor
        public Item(string itemId, string name, double price, int quantity) {
            _itemId = itemId;
            _name = name;
            _price = price;
            _quantity = quantity;
        }
        #endregion
    }

}
