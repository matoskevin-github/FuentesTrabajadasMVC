Imports WcfAccesoUsuarioVB

Public Class ServiceUsuario
    Implements IServiceUsuario

    Public Function getUsuario() As UsuarioBE Implements IServiceUsuario.getUsuario
        Dim oUsuarioBE As New UsuarioBE
        oUsuarioBE.Login = "vmatosse"
        oUsuarioBE.Password = "Peru123."
        Return oUsuarioBE
    End Function

End Class
