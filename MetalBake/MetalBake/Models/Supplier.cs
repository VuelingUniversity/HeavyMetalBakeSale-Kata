using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Supplier
    {
        public Supplier(int id, string name)
        {
            Id = id;
            Name = name;
        }
        #region Propierties
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion
    }
}
