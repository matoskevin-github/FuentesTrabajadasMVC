using System.ServiceModel;
using WcfAccesoUsuario.model;

namespace WcfAccesoUsuario
{

    [ServiceContract]
    public interface IIServiceUsuario
    {
        [OperationContract]  
        UsuarioBE getUsuario(); 
    }
}
