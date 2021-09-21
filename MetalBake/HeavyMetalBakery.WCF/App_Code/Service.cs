using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
    public void AddStock(string itemId, int amount)
    {
        throw new NotImplementedException();
    }

    public int CheckStock(string itemId)
    {
        throw new NotImplementedException();
    }

    public void ReduceStock(string itemId)
    {
        throw new NotImplementedException();
    }
}
