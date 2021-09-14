using MetalBlake.Domain.Enums;
using MetalBlake.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBlake.Domain.Models
{
    public class CakePop : IProduct
    {
        public char Short { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public CakePop(int amount)
        {
            Price = 1.35;
            Name = ProductOptions.CakePop.ToString();
            Short = 'C';
            Amount = amount;
        }
        public void RemoveStock(IProduct product)
        {
            CakePop p = (CakePop)product;
            p.Amount -= 1;

        }

        public void AddStock(IProduct product)
        {
            CakePop p = (CakePop)product;
            p.Amount -= 1;
        }
    }
}
