Imports MySql.Data.MySqlClient

Public Class web
    Private ruta As String
    Private conexion As MySqlConnection

    Sub New()
        ruta = My.Settings.web
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

    Public Function insertarPromo(pr As Entidades.account)
        Try
            ConectarBaseDeDatos()
            Dim cmd As MySqlCommand = New MySqlCommand("INSERT INTO account_data (id,dp,nickname,ip) values('" & pr.id & "',10,'" & pr.username & "',1);", ConexionBaseDeDato)
            If cmd.ExecuteNonQuery Then
                Return 1
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        Finally
            DesconetarseBaseDeDatos()
        End Try
    End Function


    Public Function consulta() As DataTable
        Try
            ConectarBaseDeDatos()
            Dim ds As New DataSet
            Dim da As New MySqlDataAdapter("select id from account_data ORDER BY id", ConexionBaseDeDato)
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        Finally
            DesconetarseBaseDeDatos()
        End Try
    End Function


    Public Function Editar(pr As Integer) As String
        Try
            Dim comando As MySqlCommand
            ConectarBaseDeDatos()
            comando = New MySqlCommand
            comando.Connection = ConexionBaseDeDato
            comando.CommandText = ("UPDATE account_data set dp = dp + 10, ip = 1 where id  = '" & pr & "'")
            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        Finally
            DesconetarseBaseDeDatos()
        End Try
    End Function

    Public Function verIp(pr As Integer) As String
        Try
            Dim comando As MySqlCommand
            ConectarBaseDeDatos()
            Dim tabla As String
            Dim consult As String
            consult = String.Format("select ip from account_data where id= '" & pr & "'")
            comando = New MySqlCommand(consult, ConexionBaseDeDato)
            tabla = comando.ExecuteScalar
            Return tabla.ToString
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        Finally
            DesconetarseBaseDeDatos()
        End Try
    End Function

End Class
