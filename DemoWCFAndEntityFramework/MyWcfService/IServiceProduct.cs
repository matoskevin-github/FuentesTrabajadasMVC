using MyWcfService.model;
using System.Collections.Generic;
using System.ServiceModel;

namespace MyWcfService
{

    [ServiceContract]
    public interface IServiceProduct
    {
        [OperationContract]
        Product find(int Id);

        [OperationContract]
        List<Product> findAll();
    }
}
