using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de IStockRepository
/// </summary>
public interface IStockRepository
{
    List<ItemStock> GetAllStock();

    ItemStock GetItemStock(string itemId);

    void SetItemStock(ItemStock item);
}