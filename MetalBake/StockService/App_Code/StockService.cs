using BakeryStockLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
public class StockService : IStockService {
    public Item ReduceStock(Item item) {
        item.Quantity--;
        Console.WriteLine("Se ha vendido el objeto.");
        return item;
    }

    public CompositeType GetDataUsingDataContract(CompositeType composite) {
        if (composite == null) {
            throw new ArgumentNullException("composite");
        }
        if (composite.BoolValue) {
            composite.StringValue += "Suffix";
        }
        return composite;
    }
}
