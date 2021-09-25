using MetalBake.core.Models;
using MetalBake.core.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.infra
{
    public class NameService : INameService
    {
        private readonly string _apiUrl = "https://localhost:44375/name";

        public List<ItemName> GetAllNames()
        {
            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string jsonResponse = client.DownloadString($"{_apiUrl}");
                var ListItemNames = JsonConvert.DeserializeObject<List<ItemName>>(jsonResponse);
                return ListItemNames;
            }
        }

        public string GetItemName(string itemId)
        {
            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string jsonResponse = client.DownloadString($"{_apiUrl}/{itemId}");
                var itemName = JsonConvert.DeserializeObject<ItemName>(jsonResponse);
                return itemName.Name;
            }
        }

        public bool ChangeItemName(string itemId, string name)
        {
            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                var item = new ItemName { ItemId = itemId, Name = name };
                var bodyJson = JsonConvert.SerializeObject(item);
                var ApiResponse = client.UploadString($"{_apiUrl}/changeName", bodyJson);
                return bool.Parse(ApiResponse);
            }
        }
    }
}