﻿using MetalBake.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.services
{
    class InventoryManagerService
    {
        private CakePop _cakePop;
        private Muffin _muffin;
        private Water _water;
        private Brownie _brownie;

        public InventoryManagerService(CakePop cakePop, Muffin muffin, Water water, Brownie brownie)
        {
            _cakePop = cakePop;
            _muffin = muffin;
            _water = water;
            _brownie = brownie;
        }

        public double SumItemPrices(char[] totalItems)
        {
            double total = 0;
            foreach (var item in totalItems)
            {
                if (item.Equals('C'))
                {
                    if (_cakePop.stock > 0)
                    {
                        total += _cakePop.price;
                    }
                    else
                    {
                        Console.WriteLine("No queda stock de Cake Pop");
                    }
                }
                else if (item.Equals('B'))
                {
                    if (_brownie.stock > 0)
                    {
                        total += _brownie.price;
                    }
                    else
                    {
                        Console.WriteLine("No queda stock de Brownie");
                    }
                }
                else if (item.Equals('M'))
                {
                    if(_muffin.stock > 0)
                    {
                        total += _muffin.price;
                    }
                    else
                    {
                        Console.WriteLine("No queda stock de Brownie");
                    }
                }
                else if (item.Equals('W'))
                {
                    if (_water.stock > 0)
                    {
                        total += _water.price;
                    } else
                    {
                        Console.WriteLine("No queda stock de Brownie");
                    }
                }
                else
                {
                    Console.WriteLine($"El producto {item} no existe");
                }
            }
            return total;
        }
        public void PrintStocks()
        {
            Console.WriteLine(_water.stock);
            Console.WriteLine(_brownie.stock);
            Console.WriteLine(_muffin.stock);
            Console.WriteLine(_cakePop.stock);
        }


    }
}
