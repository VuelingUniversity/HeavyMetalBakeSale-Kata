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
    private IStockRepository _stockRepository = new StockRepository();

    public bool ExistsItem(string itemId)
    {
        throw new NotImplementedException();
    }

    public List<ItemStock> GetAllStock()
    {
        throw new NotImplementedException();
    }

    public int GetItemStock(string itemId)
    {
        throw new NotImplementedException();
    }

    public bool ReduceItemStock(string itemId)
    {
        throw new NotImplementedException();
    }

    public string SetItemStock(string itemId, int cuantity)
    {
        throw new NotImplementedException();
    }
}