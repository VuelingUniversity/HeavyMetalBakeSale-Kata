using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de StockRepository
/// </summary>
public class StockRepository : IStockRepository
{
    public List<ItemStock> GetAllStock()
    {
        throw new NotImplementedException();
    }

    public int GetItemStock(string itemId)
    {
        throw new NotImplementedException();
    }

    public bool SetItemStock(string itemId, int cuantity)
    {
        throw new NotImplementedException();
    }
}