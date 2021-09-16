using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Stock
    {
        public Stock(int id, int ammount, Items items)
        {
            Id = id;
            Ammount = ammount;
            Items = items;
        }
        #region Propierties

        public int Id { get; set; }
        public int Ammount { get; set; }
        public Items Items {get; set; }
        #endregion
        #region Methods      
        public bool CheckStock()
        {
            throw new NotImplementedException();
        }
        public int AddStock(List<Items> items, int quantity)
        {
            throw new NotImplementedException();
        }

        public int ReduceStock(List<Items> items, int quantity)
        {
            throw new NotImplementedException();
        }
        #endregion
       

      
    }
}
