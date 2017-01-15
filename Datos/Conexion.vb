Imports MySql.Data.MySqlClient

Public Class Conexion
    Private ruta As String
    Private conexion As MySqlConnection

    Sub New()
        ruta = My.Settings.cnx
        conexion = New MySqlConnection(ruta)
    End Sub

    Public ReadOnly Property ConexionBaseDeDato As MySqlConnection
        Get
            Return conexion
        End Get
    End Property

    Public Function ConectarBaseDeDatos() As Boolean
        Try
            conexion.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function DesconetarseBaseDeDatos() As Boolean
        Try
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Public Function EjecutarConsulta(ssql As String) As DataTable
        Try
            Dim da As New MySqlDataAdapter(ssql, conexion)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
