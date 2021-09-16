using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
   public class Account
    {
        public Account(int id, string iban, int ammountAccount)
        {
            Id = id;
            Iban = iban;    
            AmmountAccount = ammountAccount;
        }
        #region Propieties
        public int Id { get; set; }
        public string Iban { get; set; }
        public int idSales { get; set; }     
        public int AmmountAccount { get; set; }
        #endregion
        #region Methods
        public decimal decreaseAmountAccount()
        {
            throw new NotImplementedException();
        }
        public decimal IncreaseAccount()
        {
            throw new NotImplementedException();
        }
        public decimal TotalAmountAccount()
        {
            throw new NotImplementedException();
        }

        #endregion




    }
}
