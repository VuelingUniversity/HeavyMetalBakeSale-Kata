using System.ServiceModel;
using System.ServiceModel.Web;

namespace HeavyMetalBakery.WCF
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/CheckStock?itemId={itemId}")]
        int CheckStock(string itemId);

        [OperationContract]
        [WebGet(UriTemplate = "/ReduceStock?itemId={itemId}")]
        bool ReduceStock(string itemId);

        [OperationContract]
        [WebGet(UriTemplate = "AddStock?itemId={itemId}&amount={amount}")]
        bool AddStock(string itemId, int amount);

        [OperationContract]
        int[] GetStocks();

        [OperationContract]
        string[] GetShorts();
    }
}