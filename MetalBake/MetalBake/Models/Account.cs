using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
   public class Account
   {
        public Account(int id, string iban, Sales sales, int ammountAccount)
        {
            Id = id;
            Iban = iban;
            Sales = sales;
            AmmountAccount = ammountAccount;
        }

        public int Id { get; set; }
        public string Iban { get; set; }
        public int idSales { get; set; }
        public Sales Sales { get; set; }
        public int AmmountAccount { get; set; }

    }
}
