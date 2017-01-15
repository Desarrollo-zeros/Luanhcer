Imports System.Text
Imports System.Security.Cryptography
Imports System.Net

Public Class account
    'Inherits Datos.account

    Dim lu As New Datos.account

    Public Function listado() As DataTable
        Dim dt As New DataTable
        dt = lu.consulta
        Return dt
    End Function


    Public Function Consultarip(ip As String) As DataTable
        Dim dt As New DataTable
        dt = lu.Verip(ip)
        Return dt
    End Function


    Public Function Verip(ip As String) As Boolean
        If Consultarip(ip).Rows.Count <= 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Function Noticia()
        Return lu.Noticias()
    End Function


    Public Function Registrarbaneo(us As Entidades.accregistro) As String
        Dim i As Integer = lu.insertarbaneo(us)
        If i = 1 Then
            Return "SE GUARDO CORRECTAMENTE"
        Else
            Return "USUARIO YA REGISTRADO"
        End If
    End Function


    Public Function actualizarpass(u As Entidades.account) As String
        If lu.Editarpass(u) Then
            Return "ACTUALIZADO CORRECTAMENTE"
        Else
            Return "ERROR AL ACTUALIZAR"
        End If
    End Function

    Public Function EliminarBaneo(cc As Integer) As String
        If lu.eliminarbaneo(cc) Then
            Return "ELIMINADO CORRECTAMENTE"
        Else
            Return "ERROR AL ELIMINAR"
        End If

    End Function

    Public Function RegistrarUsuario(us As Entidades.accregistro) As String
        Dim i As Integer = lu.Insertaruser(us)
        If i = 1 Then
            Return "SE GUARDO CORRECTAMENTE "
        Else
            Return "USUARIO YA REGISTRADO"
        End If
    End Function

    Public Function buscarPorUser(u As String) As Entidades.account
        Try
            Dim dr As DataRow
            Dim filtro As String
            Dim usu As New Entidades.account
            filtro = String.Format("[username]='{0}'", u)
            dr = listado().Select(filtro)(0)
            usu.id = dr.Item("id")
            usu.username = dr.Item("username")
            usu.sha_pass_hash = dr.Item("sha_pass_hash")
            usu.email = dr.Item("email")
            Return usu
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    'Public Function VErIp(u As String) As Entidades.account
    '    Try
    '        Dim dr As DataRow
    '        Dim filtro As String
    '        Dim usu As New Entidades.account
    '        filtro = String.Format("[last_ip]='{0}'", u)
    '        dr = listado().Select(filtro)(0)
    '        usu.last_ip = dr.Item("last_ip")
    '        Return usu
    '    Catch ex As Exception
    '        Return Nothing
    '    End Try
    'End Function


    Public Function BuscarRegistro(u As String) As Entidades.accregistro
        Try
            Dim dr As DataRow
            Dim filtro As String
            Dim usu As New Entidades.accregistro
            filtro = String.Format("[id]='{0}'", u)
            dr = listado().Select(filtro)(0)
            usu.id = dr.Item("id")
            usu.bandate = dr.Item("bandate")
            usu.unbandate = dr.Item("unbandate")
            usu.bannedby = dr.Item("bannedby")
            usu.banreason = dr.Item("banreason")
            usu.active = dr.Item("active")
            Return usu
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function buscarCorreo(u As String) As Entidades.account
        Try
            Dim dr As DataRow
            Dim filtro As String
            Dim usu As New Entidades.account
            filtro = String.Format("[email]='{0}'", u)
            dr = listado().Select(filtro)(0)
            usu.id = dr.Item("id")
            usu.username = dr.Item("username")
            usu.sha_pass_hash = dr.Item("sha_pass_hash")
            usu.email = dr.Item("email")
            Return usu
        Catch ex As Exception
            Return Nothing
        End Try
    End Function





    Public Function Encrypt(ByVal Num As String) As String
        Dim ASCIIEnc As New ASCIIEncoding
        Dim Rtnstring As String = Nothing
        Dim SourceTxt() As Byte = ASCIIEnc.GetBytes(Num)
        Dim Hash As New SHA1CryptoServiceProvider
        Dim HashByte() As Byte = Hash.ComputeHash(SourceTxt)

        For Each b As Byte In HashByte
            Rtnstring &= b.ToString("x2")
        Next
        Return Rtnstring
    End Function

    Public Function clic(ByVal usuario As String, ByVal Contraseña As String)
        Dim GetHash As String = Encrypt(usuario.ToUpper + ":" + Contraseña.ToUpper)
        Debug.Print(GetHash.ToUpper)
        Return GetHash.ToUpper
    End Function


    Public Function getIp() As String
        Dim valorIp As String
        valorIp = Dns.GetHostEntry(My.Computer.Name).AddressList.FirstOrDefault(Function(i) i.AddressFamily = Sockets.AddressFamily.InterNetwork).ToString()
        Return valorIp
    End Function

    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match = emailRegex.Match(email)
        Return emailMatch.Success
    End Function

End Class
