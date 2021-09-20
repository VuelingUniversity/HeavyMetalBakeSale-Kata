
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetalBake.Models
{
    public class Orders
    {
       
        #region Propieties
        public int Id { get; set; }
        public int Quantity { get;set;}
        public double TotalPrice { get; set; }
        public List<Items> ListProduct { get; set; }
      
        #endregion
        #region Methods
        
        //Le podemos añadir items y tb los precios
        public void AddItems(Items items)
        {
            ListProduct.Add(items);
             
        }
        /// <summary>
        /// Returns short and total price by item
        /// </summary>
        /// <param name="items"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public Tuple<string,double> CalculatePriceByItem(string _short,int quantity)
        {
            var items = new Items();          
            TotalPrice = items.ItemUnityPrice(_short) * quantity;
            return new Tuple<string, double>(_short, TotalPrice);

        }
        /// <summary>
        /// Return a bill with name and total price by item
        /// </summary>
        /// <param name="_short"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        /*public List<Tuple<string,double>> AddItemsToBill(string _short, int quantity)
        {
            List<Tuple<string, double>> _priceByItems = new List<Tuple<string, double>>();
            _priceByItems.Add(CalculatePriceByItem(_short,quantity));
            return _priceByItems;
        }
        */
        public double GetBill(List<Tuple<string, double>> _priceByItems)
        {                        
                foreach (var item in _priceByItems)
                {
                    TotalPrice += item.Item2;
                }
                return TotalPrice ;           
        }
    
        #endregion
    }
}
