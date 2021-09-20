
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
        //public int idSales { get; set; }     
        public double AmmountAccount { get; set; }
        #endregion
        #region Methods
        public double decreaseAmountAccount()
        {
            throw new NotImplementedException();
        }
        public double IncreaseAccount()
        {
            throw new NotImplementedException();
        }
        public double TotalAmountAccount()
        {
            throw new NotImplementedException();
        }

        #endregion




    }
}
