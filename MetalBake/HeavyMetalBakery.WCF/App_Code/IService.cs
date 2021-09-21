using System.ServiceModel;

[ServiceContract]
public interface IService
{
    [OperationContract]
    int CheckStock(string itemId);

    [OperationContract]
    void ReduceStock(string itemId);

    [OperationContract]
    void AddStock(string itemId, int amount);
}