using MetalBlake.Domain.Enums;
using MetalBlake.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBlake.Domain.Models
{
    public class Water : IProduct
    {
        public char Short { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public Water(int amount)
        {
            Price = 1.50;
            Name = ProductOptions.Water.ToString();
            Short = 'W';
            Amount = amount;
        }
        public void RemoveStock(IProduct product)
        {
            Water p = (Water)product;
            p.Amount -= 1;

        }

        public void AddStock(IProduct product)
        {
            Water p = (Water)product;
            p.Amount -= 1;
        }
    }
}
