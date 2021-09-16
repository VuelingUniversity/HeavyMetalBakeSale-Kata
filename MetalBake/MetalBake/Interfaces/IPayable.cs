using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    public interface IPayable
    {
        public bool CheckPaid();
        public decimal CalculateBill();
        
    }
}
