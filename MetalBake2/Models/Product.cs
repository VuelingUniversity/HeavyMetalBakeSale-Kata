using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBakeMVC.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public double Price { get; set; }
        public string Img { get; set; }

        public Product(string name, string id, double price, string img)
        {
            Name = name;
            Id = id;
            Price = price;
            Img = img;
        }
    }
}