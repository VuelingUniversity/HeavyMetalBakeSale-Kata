using MetalBakeMVC.Interfaces;
using MetalBakeMVC.Models;
using MetalBakeMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBakeMVC.Controllers
{
    public class StockController : Controller, IStock
    {
        public IActionResult Index()
        {
            return View(GetProducts());
        }

        public List<StockData> GetProducts()
        {
            try
            {
                using (StreamReader r = new StreamReader(@"./AppData/stock.json"))
                {
                    string json = r.ReadToEnd();
                    List<StockData> items = JsonConvert.DeserializeObject<List<StockData>>(json);
                    return items;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public StockData GetProductByName(string name)
        {
            try
            {
                using (StreamReader r = new StreamReader("./AppData/stock.json"))
                {
                    string json = r.ReadToEnd();
                    List<StockData> items = JsonConvert.DeserializeObject<List<StockData>>(json);
                    var item = items.FirstOrDefault(item => item.Name == name);
                    r.Close();
                    return item;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IActionResult AddProduct(string name, int num = 1)
        {
            try
            {
                using (StreamReader r = new StreamReader("./AppData/stock.json"))
                {
                    string json = r.ReadToEnd();
                    List<StockData> items = JsonConvert.DeserializeObject<List<StockData>>(json);
                    items.ForEach(item =>
                    {
                        if (item.Name == name)
                            item.Total += num;
                    });
                    r.Close();
                    var jsonString = JsonConvert.SerializeObject(items);
                    using (StreamWriter w = new StreamWriter("./AppData/stock.json"))
                    {
                        w.WriteLine(jsonString);
                        w.Close();
                    }
                   
                }
            }
            catch (Exception)
            {
            }
            return Redirect("Index");
        }
        public IActionResult ReduceProduct(string name, int num = 1)
        {
            try
            {
                using (StreamReader r = new StreamReader("./AppData/stock.json"))
                {
                    string json = r.ReadToEnd();
                    List<StockData> items = JsonConvert.DeserializeObject<List<StockData>>(json);
                    items.ForEach(item =>
                    {
                        if (item.Name == name)
                            item.Total -= num;
                    });
                    r.Close();
                    var jsonString = JsonConvert.SerializeObject(items);
                    using (StreamWriter w = new StreamWriter("./AppData/stock.json"))
                    {
                        w.WriteLine(jsonString);
                        w.Close();
                    }

                }
            }
            catch (Exception)
            {
            }
            return Redirect("Index");
        }
    }
}