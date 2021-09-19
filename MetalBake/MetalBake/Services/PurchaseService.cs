using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class PurchaseService
    {
        private Dictionary<Type, decimal> priceList = SetItem();

        private static Dictionary<Type, decimal> SetItem()
        {
            Dictionary<Type, decimal> list = new Dictionary<Type, decimal>();
            list.Add(typeof(Cake_Pop), 1.35m);
            list.Add(typeof(Brownie), 0.65m);
            list.Add(typeof(Water), 1.50m);
            list.Add(typeof(Muffin), 1);
            return list;
        }

        private Brownie _brownie = new Brownie();
        private Cake_Pop _cakePop = new Cake_Pop();
        private Muffin _muffin = new Muffin();
        private Water _water = new Water();

        private static PurchaseService _instance;

        public decimal OrderPrice(string orderItems)
        {
            decimal total = 0;
            char[] totalItems = orderItems.Replace(",", string.Empty).ToCharArray();
            foreach (var item in totalItems)
            {
                if (item.Equals(_cakePop.ShortName))
                {
                    total += priceList[typeof(Cake_Pop)];
                }
                else if (item.Equals(_water.ShortName))
                {
                    total += priceList[typeof(Water)];
                }
                else if (item.Equals(_muffin.ShortName))
                {
                    total += priceList[typeof(Muffin)];
                }
                else if (item.Equals(_brownie.ShortName))
                {
                    total += priceList[typeof(Brownie)];
                }
            }
            return total;
        }

        public decimal Purchase(decimal totalPrice, decimal payed)
        {
            return payed - totalPrice;
        }

        static public PurchaseService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PurchaseService();
            }
            return _instance;
        }
    }
}