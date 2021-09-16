using MetalBlake.Domain.Interfaces;
using MetalBlake.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBlake.Domain.Services
{
    public class MachineService : IMachine
    {
        private static MachineService _service;

        private MachineService()
        {
            
        }

        public static MachineService GetInstance()
        {
            if (_service == null)
            {
                return new MachineService();
            }
            return _service;
        }

        public void BuyProduct(Order order, Machine machine, double amountPaid)
        {
            if (amountPaid > order.Total)
            {
                order.ListOrders.ForEach(product =>
                {
                    machine.ProductList.ForEach(machineProduct =>
                    {
                        if (machineProduct.GetName() == product.GetName())
                        {
                            machineProduct.RemoveStock(product);
                        }
                    });
                });
            }
            else
            {
                Console.WriteLine("No se ha podido realizar la compra, la cantidad no es suficiente");
            }
        }

        public List<IProduct> ParseOrders(string msg)
        {
            List<IProduct> OrderList = new List<IProduct>();
            string[] msgList = msg.Split(",");
            msg.ToList().ForEach(x =>
            {
                if (x == 'C')
                {
                    OrderList.Add(new CakePop(1));
                }
                else if (x == 'M')
                {
                    OrderList.Add(new Muffin(1));
                }
                else if (x == 'W')
                {
                    OrderList.Add(new Water(1));
                }
                else if (x == 'B')
                {
                    OrderList.Add(new Brownie(1));
                }
            });
            return OrderList;

        }
    }
}
