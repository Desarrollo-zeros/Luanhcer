Public Class web

    Dim lu As New Datos.web

    Public Function Registrarpromo(us As Entidades.account) As String
        Dim i As Integer = lu.insertarPromo(us)
        If i = 1 Then
            Return "SE GUARDO CORRECTAMENTE"
        Else
            Return "USUARIO YA REGISTRADO"
        End If
    End Function


   
    Public Function listado() As DataTable
        Dim dt As New DataTable
        dt = lu.consulta
        Return dt
    End Function


    Public Function BuscarPromo(u As Integer) As Entidades.account
        Try
            Dim dr As DataRow
            Dim filtro As String
            Dim usu As New Entidades.account
            filtro = String.Format("[id]='{0}'", u)
            dr = listado().Select(filtro)(0)
            usu.id = dr.Item("id")
            Return usu
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Function actualizardp(u As Integer) As String
        If lu.Editar(u) Then
            Return "ACTUALIZADO CORRECTAMENTE"
        Else
            Return "ERROR AL ACTUALIZAR"
        End If
    End Function


    Function promo(pr As Integer)
        Return lu.verIp(pr)
    End Function
End Class
