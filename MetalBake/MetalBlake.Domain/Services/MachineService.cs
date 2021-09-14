using MetalBlake.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBlake.Domain.Services
{
    public class MachineService : IMachine
    {
        private static MachineService _service;

        private MachineService()
        {
            
        }

        public static MachineService GetInstance()
        {
            if (_service == null)
            {
                return new MachineService();
            }
            return _service;
        }

        public double BuyProduct(char[] list, double amountPaid)
        {
            throw new NotImplementedException();
        }
    }
}
