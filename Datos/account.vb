Imports MySql.Data.MySqlClient
Public Class account
    Inherits Datos.Conexion
    Dim Comando As MySqlCommand
    Public Function consulta() As DataTable
        Try
            ConectarBaseDeDatos()
            Dim ds As New DataSet
            Dim da As New MySqlDataAdapter("select id, USERNAME, sha_pass_hash, email from account ORDER BY id", ConexionBaseDeDato)
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        Finally
            DesconetarseBaseDeDatos()
        End Try
    End Function


    Public Function Verip(ip As String) As DataTable
        Try

            ConectarBaseDeDatos()
            Dim ds As New DataSet
            Dim da As New MySqlDataAdapter("select  last_ip from account where last_ip = '" + ip + "' ", ConexionBaseDeDato)
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        Finally
            DesconetarseBaseDeDatos()
        End Try
    End Function

    Public Function Noticias() As String
        Try
            ConectarBaseDeDatos()
            Dim tabla As String
            Dim consult As String
            consult = String.Format("select Noticia from Noticias where id= 1")
            Comando = New MySqlCommand(consult, ConexionBaseDeDato)
            tabla = Comando.ExecuteScalar
            Return tabla.ToString
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        Finally
            DesconetarseBaseDeDatos()
        End Try
    End Function

    Public Function Insertaruser(pr As Entidades.accregistro)
        Try
            ConectarBaseDeDatos()
            Dim cmd As MySqlCommand = New MySqlCommand("INSERT INTO account (username,sha_pass_hash,email,reg_mail,last_ip,expansion) values('" & pr.username & "', '" & pr.sha_pass_hash & "', '" & pr.email & "', '" & pr.reg_mail & "', '" & pr.last_ip & "', '" & pr.expansion & "');", ConexionBaseDeDato)
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




    Public Function Insertarpc(pr As Entidades.Registropc)
        Try
            ConectarBaseDeDatos()
            Comando = New MySqlCommand
            Comando.Connection = ConexionBaseDeDato
            Comando.CommandText = "INSERT into registropc VALUES(@id,@Usuario,@Contraseña,@NombrePC,@IP,@Codigo,@mac)"
            Comando.Parameters.Add("@id", MySqlDbType.Int32)
            Comando.Parameters.Add("@Usuario", MySqlDbType.String)
            Comando.Parameters.Add("@Contraseña", MySqlDbType.String)
            Comando.Parameters.Add("@NombrePC", MySqlDbType.String)
            Comando.Parameters.Add("@IP", MySqlDbType.String)
            Comando.Parameters.Add("@Codigo", MySqlDbType.String)
            Comando.Parameters.Add("@mac", MySqlDbType.String)
            Comando.Parameters("@id").Value = CInt(pr.id)
            Comando.Parameters("@Usuario").Value = CStr(pr.usuario)
            Comando.Parameters("@Contraseña").Value = CStr(pr.pass)
            Comando.Parameters("@NombrePC").Value = CStr(pr.Nombrepc)
            Comando.Parameters("@IP").Value = CStr(pr.Ip)
            Comando.Parameters("@Codigo").Value = CStr(pr.codigo)
            Comando.Parameters("@mac").Value = CStr(pr.mac)
            If Comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
                MsgBox("Error #2 Registro de cuenta", "WoW-Letal")
            End If
        Catch ex As Exception
            Return 0
        Finally
            DesconetarseBaseDeDatos()
        End Try
    End Function

    Public Function Insertarcodigo(pr As Entidades.Registropc)
        Try
            ConectarBaseDeDatos()
            Comando = New MySqlCommand
            Comando.Connection = ConexionBaseDeDato
            Comando.CommandText = "INSERT into Codigo VALUES(@id,@Usuario,@Codigo)"
            Comando.Parameters.Add("@id", MySqlDbType.Int32)
            Comando.Parameters.Add("@Usuario", MySqlDbType.String)
            Comando.Parameters.Add("@Codigo", MySqlDbType.String)
            Comando.Parameters("@id").Value = CInt(pr.id)
            Comando.Parameters("@Usuario").Value = CStr(pr.usuario)
            Comando.Parameters("@Codigo").Value = CStr(pr.codigo)
            If Comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return 0
        Finally
            DesconetarseBaseDeDatos()
        End Try
    End Function

    Public Function consultarcodigo() As DataTable
        Try
            ConectarBaseDeDatos()
            Dim ds As New DataSet
            Dim da As New MySqlDataAdapter("select id,usuario,Codigo from Codigo", ConexionBaseDeDato)
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        Finally
            DesconetarseBaseDeDatos()
        End Try
    End Function


    Public Function consultapc() As DataTable
        Try
            ConectarBaseDeDatos()
            Dim ds As New DataSet
            Dim da As New MySqlDataAdapter("select id,usuario,Contraseña,NombrePC,ip,Codigo,mac from registropc", ConexionBaseDeDato)
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        Finally
            DesconetarseBaseDeDatos()
        End Try
    End Function


    Public Function validarUsuario(ID As Entidades.account) As Boolean
        Try
            ConectarBaseDeDatos()
            Dim tabla As MySqlDataReader
            Dim consult As String
            consult = String.Format("SELECT * FROM registropc WHERE [id]='{0}'", ID.id)
            Comando = New MySqlCommand(consult, ConexionBaseDeDato)
            tabla = Comando.ExecuteReader
            If tabla.HasRows Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        Finally
            DesconetarseBaseDeDatos()
        End Try
    End Function

    Public Function EditarCodigo(pr As Entidades.Registropc) As String
        Try
            ConectarBaseDeDatos()
            Comando = New MySqlCommand
            Comando.Connection = ConexionBaseDeDato
            Comando.CommandText = "UPDATE registropc set NombrePC = @Nombrepc, IP = @IP, codigo = @codigo, mac= @mac where usuario = '" + pr.usuario + "'"
            Comando.Parameters.Add("@NombrePC", MySqlDbType.String)
            Comando.Parameters.Add("@IP", MySqlDbType.String)
            Comando.Parameters.Add("@codigo", MySqlDbType.String)
            Comando.Parameters.Add("@mac", MySqlDbType.String)
            Comando.Parameters("@NombrePC").Value = CStr(pr.Nombrepc)
            Comando.Parameters("@IP").Value = CStr(pr.Ip)
            Comando.Parameters("@codigo").Value = CStr(pr.codigo)
            Comando.Parameters("@mac").Value = CStr(pr.mac)
            If Comando.ExecuteNonQuery Then
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

    Public Function Editarpass(pr As Entidades.account) As String
        Try
            ConectarBaseDeDatos()
            Comando = New MySqlCommand
            Comando.Connection = ConexionBaseDeDato
            Comando.CommandText = "UPDATE account set sha_pass_hash = @sha_pass_hash, sessionkey = '',v='',s='' where username =  '" + pr.username + "'"
            'Comando.Parameters.Add("@username", MySqlDbType.String)
            Comando.Parameters.Add("@sha_pass_hash", MySqlDbType.String)
            'Comando.Parameters("@username").Value = CStr(pr.username)
            Comando.Parameters("@sha_pass_hash").Value = CStr(pr.sha_pass_hash)
            If Comando.ExecuteNonQuery Then
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


    Public Function EditarPC(pr As Entidades.Registropc) As String
        Try
            ConectarBaseDeDatos()
            Comando = New MySqlCommand
            Comando.Connection = ConexionBaseDeDato
            Comando.CommandText = "UPDATE Codigo = @Codigo  where usuario = '" + pr.usuario + "'"
            'Comando.Parameters.Add("@NombrePC", MySqlDbType.String)
            'Comando.Parameters.Add("@IP", MySqlDbType.String)
            Comando.Parameters.Add("@Codigo", MySqlDbType.String)
            'Comando.Parameters.Add("@mac", MySqlDbType.String)
            ' Comando.Parameters("@NombrePC").Value = CStr(pr.Nombrepc)
            'Comando.Parameters("@IP").Value = CStr(pr.Ip)
            Comando.Parameters("@Codigo").Value = CStr(pr.codigo)
            'Comando.Parameters("@mac").Value = CStr(pr.mac)
            If Comando.ExecuteNonQuery Then
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

    Public Function consultarRegistro() As DataTable
        Try
            ConectarBaseDeDatos()
            Dim ds As New DataSet
            Dim da As New MySqlDataAdapter("select id,bandate,unbandate,bannedby,banreason,active,Registro from account_banned ", ConexionBaseDeDato)
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        Finally
            DesconetarseBaseDeDatos()
        End Try
    End Function



    Public Function insertarbaneo(pr As Entidades.accregistro)
        Try
            ConectarBaseDeDatos()
            Dim cmd As MySqlCommand = New MySqlCommand("INSERT INTO account_banned (id,bandate,unbandate,bannedby,banreason,active) values('" & pr.id & "', '" & pr.bandate & "', '" & pr.unbandate & "', '" & pr.bannedby & "', '" & pr.banreason & "', '" & pr.active & "');", ConexionBaseDeDato)
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



    Public Function eliminarbaneo(cc As Integer) As Boolean
        Try
            ConectarBaseDeDatos()

            Dim cmd As MySqlCommand = New MySqlCommand("DELETE FROM account_banned WHERE id='" & cc & "'", ConexionBaseDeDato)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            DesconetarseBaseDeDatos()
        End Try
    End Function

End Class
