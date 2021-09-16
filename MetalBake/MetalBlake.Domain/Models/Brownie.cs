﻿using MetalBlake.Domain.Enums;
using MetalBlake.Domain.Interfaces;
using System;

namespace MetalBlake.Domain.Models

{
    public class Brownie : IProduct
    {
        public char Short { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public Brownie(int amount)
        {
            Price = 0.65;
            Name = ProductOptions.Brownie.ToString();
            Short = 'B';
            Amount = amount;
        }

        public void RemoveStock(IProduct product)
        {
                Amount -= 1;
            
        }

        public void AddStock(IProduct product)
        {
            Brownie p = (Brownie)product;
            p.Amount += 1;
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
