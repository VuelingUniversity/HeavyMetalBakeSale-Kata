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

    private bool ExistsItem(string itemId)
    {
        ItemStock result = _stockRepository.GetItemStock(itemId);
        return itemId == result.ItemId;
    }

    public List<ItemStock> GetAllStock()
    {
        return _stockRepository.GetAllStock();
    }

    public ItemStock GetItemStock(string itemId)
    {
        if (ExistsItem(itemId))
        {
            return null;
        }
        return _stockRepository.GetItemStock(itemId);
    }

    public void ReduceItemStock(string itemId, int cuantity)
    {
        ItemStock previousStock = GetItemStock(itemId);
        ItemStock newStock = new ItemStock() { ItemId = itemId, Stock = previousStock.Stock - cuantity };
        _stockRepository.SetItemStock(newStock);
    }

    public bool ChangeItemStock(ItemStock item)
    {
        if (!ExistsItem(item.ItemId))
        {
            return false;
        }
        _stockRepository.SetItemStock(item);
        return true;
    }
}