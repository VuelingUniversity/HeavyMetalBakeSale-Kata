using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de StockRepository
/// </summary>
public class StockRepository : IStockRepository
{
    private static string _filePath = @"../../Files/stock.json";

    private List<ItemStock> ReadJsonFile()
    {
        string text = File.ReadAllText(_filePath);
        return JsonConvert.DeserializeObject<List<ItemStock>>(text);
    }

    public List<ItemStock> GetAllStock()
    {
        return ReadJsonFile();
    }

    public ItemStock GetItemStock(string itemId)
    {
        List<ItemStock> listOfItemStock = ReadJsonFile();
        return listOfItemStock.FirstOrDefault(item => item.ItemId == itemId);
    }

    public void SetItemStock(ItemStock item)
    {
        List<ItemStock> listOfItemStock = ReadJsonFile();
        int itemIndex = listOfItemStock.FindIndex(i => i.ItemId == item.ItemId);
        listOfItemStock[itemIndex] = item;
        WriteInFile(listOfItemStock);
    }

    private void WriteInFile(List<ItemStock> listOfItemStock)
    {
        var stockJson = JsonConvert.SerializeObject(listOfItemStock);
        File.WriteAllText(_filePath, stockJson);
    }
}