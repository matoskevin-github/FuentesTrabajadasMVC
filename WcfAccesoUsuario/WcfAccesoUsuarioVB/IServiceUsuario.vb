Imports System.ServiceModel

<ServiceContract()>
Public Interface IServiceUsuario

    <OperationContract()>
    Function getUsuario() As UsuarioBE

End Interface
