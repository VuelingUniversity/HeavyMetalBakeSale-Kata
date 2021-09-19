using MetalBake.Interfaces;
using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class InvetoryService
    {
        private Dictionary<Type, int> stockList = SetItem();
        private Brownie _brownie = new Brownie();
        private Cake_Pop _cake_Pop = new Cake_Pop();
        private Muffin _muffin = new Muffin();
        private Water _water = new Water();

        private static Dictionary<Type, int> SetItem()
        {
            Dictionary<Type, int> list = new Dictionary<Type, int>();
            list.Add(typeof(Brownie), 25);
            list.Add(typeof(Cake_Pop), 30);
            list.Add(typeof(Muffin), 25);
            list.Add(typeof(Water), 50);

            return list;
        }

        public string InventoryFilter(string selectedItems)
        {
            char[] totalItems = selectedItems.Replace(",", string.Empty).ToCharArray();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in totalItems)
            {
                if (item.Equals(_cake_Pop.ShortName))
                {
                    stringBuilder.Append(CheckStock(_cake_Pop));
                }
                else if (item.Equals(_water.ShortName))
                {
                    stringBuilder.Append(CheckStock(_water));
                }
                else if (item.Equals(_muffin.ShortName))
                {
                    stringBuilder.Append(CheckStock(_muffin));
                }
                else if (item.Equals(_brownie.ShortName))
                {
                    stringBuilder.Append(CheckStock(_brownie));
                }
                else
                {
                    Console.WriteLine($"El item {item} no existe");
                }
            }
            string availableItems = stringBuilder.ToString();
            availableItems = availableItems.Remove(availableItems.Length - 1);
            return availableItems;
        }

        private string CheckStock(IProductable product)
        {
            if (stockList[product.GetType()] > 0)
            {
                stockList[product.GetType()]--;
                return $"{product.ShortName},";
            }
            else
            {
                Console.WriteLine("No stock");
                //se usa cuando no hay stock
                return string.Empty;
            }
        }
    }
}