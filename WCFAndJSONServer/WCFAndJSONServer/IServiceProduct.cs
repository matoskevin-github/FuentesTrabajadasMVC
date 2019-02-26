using System.Collections.Generic;
using System.ServiceModel;

namespace WCFAndJSONServer
{
    [ServiceContract]
    public interface IServiceProduct
    {
        [OperationContract]
        Product find();

        [OperationContract]
        List<Product> findAll();
    }
}
