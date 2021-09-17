
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Stock
    {
        //En el constructor los parametros son los requeridos, no tiene sentido ponerlos public 
        //En este caso el stock depende de un servicio ext--> pq solamente tiene una cantidad y necesitaria alguien q le diese la orden
        #region Propierties
        public int Id { get; set; }
        public int Ammount { get; set; }
        #endregion
        
       

      
    }
}
