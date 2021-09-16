using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
   public class Changes
    {
        public Changes(int id, decimal returnMoney)
        {
            Id = id;
            
            ReturnMoney = returnMoney;
        }
        #region Propieties
        public int Id { get; set; }
        
        public decimal ReturnMoney { get; set; }
        #endregion
        #region Methods
        public bool CheckChange()
        {
            throw new NotImplementedException();
        }

        public decimal ReturnChange()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
