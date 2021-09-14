using MetalBake.Interfaces;
using MetalBake.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Servicios {
    class MenuService : IMenu {
        private IPay _payService;
        private IReader _readerService;

        public MenuService(IPay payService, IReader readerService) {
            _payService = payService;
            _readerService = readerService;
        }
        public void Display() {
            List<Item> VendingItems = FillItemsList();
            List<Item> ToBuyItems = new List<Item>();
            Client Client = new Client("IdUsuario", 100.00);
            MetalBakeAccount MetalBakeAccount = new MetalBakeAccount(0, "AL47 2121 1009 0000 0002 3569 8741");
            int OrderId = 0;
            while (true) {
                Console.WriteLine(@"What option do you want to select?
                1] Display Items
                2] Purchase 
                3] Display historial of orders
                4] Quit"
        );
                string input = Console.ReadLine();
                if (input == "1") {
                    _readerService.DisplayProducts(VendingItems);
                } else if (input == "2") {
                    while (true) {
                        Console.WriteLine("Introduce itemID to buy");
                        string ProductID = Console.ReadLine();
                        foreach (var v in VendingItems) {
                            if (v.ItemId == ProductID) {
                                ToBuyItems.Add(v);
                            }
                        }
                        Console.WriteLine(@"Do you want to introduce another item?
                        Y for yes, !Y to end");
                        string Continue = Console.ReadLine();
                        if (Continue != "Y") {
                            Order Order = new Order(OrderId, ToBuyItems);
                            OrderId++;
                            double total = 0;
                            foreach (var v in ToBuyItems) {
                                total += v.Price;
                            }
                            _payService.ClientPayToMetalBake(total, MetalBakeAccount, Client, Order);
                            break;
                        }
                    }
                } else if (input == "3") {

                } else if (input == "4") {
                    Console.WriteLine("Quitting");
                    break;
                } else {
                    Console.WriteLine("");
                }
            }
        }

        private List<Item> FillItemsList() {
            List<Item> ret = new List<Item>();
            Item Brownie = new Item("B", "Brownie ", 0.65, 40);
            Item Muffin = new Item("M", "Muffin  ", 1.00, 36);
            Item CakePop = new Item("C", "Cake Pop", 1.35, 24);
            Item Water = new Item("W", "Water   ", 1.50, 30);
            ret.Add(Brownie);
            ret.Add(Muffin);
            ret.Add(CakePop);
            ret.Add(Water);
            return ret;
        }
    }
}