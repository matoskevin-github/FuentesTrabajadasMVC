Public Class Funciones
    Public Shared Function ValidarCadenaVacia(strCadena As String) As Boolean
        If strCadena <> String.Empty Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
