Public Class Usuario

    Public Property usuario As String
    Public Property contraseña As String
    Sub New()
        MyBase.New()
    End Sub
    Sub New(datos As String)
        usuario = Split(datos, ";")(0)
        contraseña = Split(datos, ";")(1)
    End Sub
    Function lineaDatos() As String()
        Dim s(1) As String
        s(0) = usuario
        s(1) = contraseña
        Return s
    End Function
End Class
