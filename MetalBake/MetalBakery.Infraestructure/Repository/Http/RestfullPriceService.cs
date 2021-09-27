using MetalBakery.Core.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MetalBakery.Infraestructure.Repository.Http
{
    public class RestfullPriceService:ICalculatorPriceServices
    {
       
        public class ItemPrice
        {
            public string itemId { get; set; }
            public decimal price { get; set; }
        }
        public decimal GetPrice(string itemId)
        {
            using (WebClient client= new WebClient())
            {
                string apiUrl = "https://localhost:44330/prices";
                // "Content-type": dice al cliente que tipo de contenido será retornado
                client.Headers["Content-type"] = "application/json";
                // Se utiliza para codificar las cadenas.
                client.Encoding = Encoding.UTF8;
                // El recurso para descargar se especifica como una String que contiene el URL.             
                string json = client.DownloadString($"{apiUrl}/{itemId}");
                var itemPrice = JsonConvert.DeserializeObject<ItemPrice>(json);
                return itemPrice.price;
            }           
        }

        public Dictionary<string, decimal> GetPrices()
        {
            string apiUrl = "http://localhost:46002//prices";

            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.DownloadString($"{apiUrl}");
                var itemPrice = JsonConvert.DeserializeObject<List<ItemPrice>>(json);
                Dictionary<string, decimal> prices = new Dictionary<string, decimal>();
                foreach (var item in itemPrice)
                {
                    prices.Add(item.itemId, item.price);
                }
                return prices;
            }
        }
    }
}
