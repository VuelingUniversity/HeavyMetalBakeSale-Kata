using MetalBlake.Domain.Enums;
using MetalBlake.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBlake.Domain.Models
{
    public class Muffin : IProduct
    {
        public char Short { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public Muffin(int amount)
        {
            Price = 1;
            Name = ProductOptions.Muffin.ToString();
            Short = 'M';
            Amount = amount;
        }
        public void RemoveStock(IProduct product)
        {
            Muffin p = (Muffin)product;
            p.Amount -= 1;

        }

        public void AddStock(IProduct product)
        {
            Muffin p = (Muffin)product;
            p.Amount -= 1;
        }
        public string GetName()
        {
            return Name;
        }

        public double GetPrice()
        {
            return Price;
        }
        public void ShowProduct()
        {
            Console.WriteLine($"Name: {Name} Amount: {Amount}");
        }
    }
}
