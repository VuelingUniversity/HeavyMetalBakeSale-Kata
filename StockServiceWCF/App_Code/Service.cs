using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public Dictionary<string, int> productsStock = new Dictionary<string, int>()
        {
            {"B",40 },
            {"M",36 },
            {"C",24 },
            {"W",3 }

        };
    Products products = new Products();
    public void CheckStock(string[] itemId)
    {
        foreach (var item in itemId)
        {
            if (productsStock[item]<0)
            {
                /*Console.WriteLine($"Not enough stock of {products.productsNames[item]}");*/
                Console.WriteLine("Not stock of "+ products.productsNames[item]);
            }
            else
            {
                ReducedStock(itemId);
            }
        }
    }
    public void ShowStock(string[] itemId)
    {
        foreach (var item in itemId)
        {
            Console.WriteLine(products.productsNames[item] + " ||" +  productsStock[item]);
        }
    }
    public void AddStock(string[] itemId)
    {
        foreach (var item in itemId)
        {
            productsStock[item]++;
        }
    }
    public void ReducedStock(string[] itemId)
    {
        foreach (var item in itemId)
        {
            productsStock[item]--;
        }
    }
}
