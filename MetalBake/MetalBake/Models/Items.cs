using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Items
    {

        #region Propierties
        public string Name { get; set; }
        public string Short { get; set; }
        public double UnitPrice { get; set; }
        #endregion
        public Dictionary<string, string> ShortName = new Dictionary<string, string>()
        {
            { "B", "Brownie" },
            { "C", "Cake Pop" },
            { "M", "Muffin"},
            { "W", "Water"},
        };
        /// <summary>
        /// Dictionary press a short return the product's value
        /// </summary>
        /// <param name="Short"></param>
        /// <returns></returns>
        public string ItemName(string Short)
        {
            var name = ShortName[Short];
            return name;
        }
        public  Dictionary<string, double> _itemsUnityPice = new Dictionary<string, double>()
        {
            { "B", 0.65 },
            { "C", 1.00 },
            { "M", 1.35},
            { "W", 1.50},
        };
        /// <summary>
        /// Dictionary press short and returns unityPrice of item's choose
        /// </summary>
        /// <param name="Short"></param>
        /// <returns></returns>
        public double ItemUnityPrice(string key)
        {          
            return _itemsUnityPice[key];
        }
    }
}
