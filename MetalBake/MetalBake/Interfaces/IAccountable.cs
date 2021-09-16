using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    public interface IAccountable
    {
        public bool CheckAmountAccount();
        public decimal TotalAmountAccount();

    }
}
