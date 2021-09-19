using BakeryStockLibrary;
using System.Runtime.Serialization;
using System.ServiceModel;

[ServiceContract]
public interface IStockService {
    [OperationContract]
    Item ReduceStock(Item item);
}

[DataContract]
public class CompositeType {
    bool boolValue = true;
    string stringValue = "Hello ";

    [DataMember]
    public bool BoolValue {
        get { return boolValue; }
        set { boolValue = value; }
    }
    [DataMember]
    public string StringValue {
        get { return stringValue; }
        set { stringValue = value; }
    }
}