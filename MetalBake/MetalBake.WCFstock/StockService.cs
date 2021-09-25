using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.infra
{
    public class StockService
    {
        private stockService.IService _stockService;

        public StockService()
        {
            _stockService = new stockService.ServiceClient();
        }
    }
}