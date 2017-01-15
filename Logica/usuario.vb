Imports Datos
Imports System.Text
Imports System.Security.Cryptography

Public Class usuario
    Dim archivo As Datos.archivo
    Private lista As List(Of Entidades.Usuario)
    Private actual As New Date
    Dim ruta As String

    Sub New(ruta As String)
        archivo = New Datos.archivo(ruta)
        refresh()
    End Sub
    Sub New()
        archivo = New Datos.archivo("wow.conf")
        refresh()
    End Sub
    Sub refresh()
        lista = archivo.leer
    End Sub

    Function agregar(bar As Entidades.Usuario) As String
        Try
            If IsNothing(bar) Then
                Return "no puede agregar  valores nulos"
            End If
            Dim mensaje As String = archivo.guardar(Join(bar.lineaDatos, ";"))
            refresh()
            Return mensaje

        Catch ex As Exception
            Return "no se agrego la persona : " & ex.Message
        End Try
    End Function

    Function listar() As List(Of Entidades.Usuario)
        Return lista
    End Function

    Function total() As Integer
        Return lista.Count > 0
    End Function

    Function usuario(index As Integer) As Entidades.Usuario
        Return CType(lista(index), Entidades.Usuario)
    End Function



    Public Function Encriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi") 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
        Dim buffer() As Byte = Encoding.UTF8.GetBytes(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function

    Public Function Desencriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi") 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
        Dim buffer() As Byte = Convert.FromBase64String(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))
    End Function

End Class
