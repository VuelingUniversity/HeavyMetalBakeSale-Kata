using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PricesServiceAPI.Repositories
{
    public class PriceRespository:IPriceRespository
    {
        private static Dictionary<string, decimal> _prices;
        static PriceRespository()
        { 
            _prices = new Dictionary<string, decimal>() 
            { 
                { "B", 0.65m }, 
                { "M", 1.00m }, 
                { "C", 1.35m }, 
                { "W", 1.50m } 
            };
        }
    }
}
