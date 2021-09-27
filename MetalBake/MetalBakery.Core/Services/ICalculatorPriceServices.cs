using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBakery.Core.Services
{
   public interface ICalculatorPriceServices
    {
        /// <summary>
        /// La capa de infraestructura es la que va a implementar estos metodos 
        /// que llamará a la api para devolver los precios
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        decimal GetPrice(string itemId);
        Dictionary<string, decimal> GetPrices();
    }
}
