using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Orders
    {
        public Orders(int id, DateTime orderDate, string orderDetails, int idCustomer, Customers customers)
        {
            Id = id;
            OrderDate = orderDate;
            OrderDetails = orderDetails;
            IdCustomer = idCustomer;
            Customers = customers;
        }
        #region Propieties
        public int Id { get; set; }
        public DateTime OrderDate {get;set;}
        public string OrderDetails { get; set; }
        public int IdCustomer { get; set; }
        public Customers Customers { get; set; }
        #endregion
        #region Methods
        public bool CheckOrder()
        {
            throw new NotImplementedException();
        }
        public int OrderItems()
        {
            throw new NotImplementedException();
        }

        //Le podemos añadir items y tb los precios
        public void AddItems(Items items)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
