Imports System.Net.NetworkInformation

Public Class RegistrarPC
    Dim lu As New Datos.account

    Public Function GuardarPC(us As Entidades.Registropc) As String
        Dim i As Integer = lu.Insertarpc(us)
        If i = 1 Then
            Return "SE GUARDO CORRECTAMENTE "
        Else
            Return "USUARIO YA REGISTRADO"
        End If
    End Function


    Public Function GuardarCodigo(us As Entidades.Registropc) As String
        Dim i As Integer = lu.Insertarcodigo(us)
        If i = 1 Then
            Return "SE GUARDO CORRECTAMENTE "
        Else
            Return "USUARIO YA REGISTRADO"
        End If
    End Function


    Public Function actualizarCodigo(u As Entidades.Registropc) As String
        If lu.EditarCodigo(u) Then
            Return "ACTUALIZADO CORRECTAMENTE"
        Else
            Return "ERROR AL ACTUALIZAR"
        End If
    End Function


    Public Function actualizarpc(u As Entidades.Registropc) As String
        If lu.EditarPC(u) Then
            Return "ACTUALIZADO CORRECTAMENTE"
        Else
            Return "ERROR AL ACTUALIZAR"
        End If
    End Function

    Public Function ObtenerMac() As String
        Try
            Dim adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
            Dim adapter As NetworkInterface
            Dim myMac As String = String.Empty

            For Each adapter In adapters
                Select Case adapter.NetworkInterfaceType
                    'Exclude Tunnels, Loopbacks and PPP
                    Case NetworkInterfaceType.Tunnel, NetworkInterfaceType.Loopback, NetworkInterfaceType.Ppp
                    Case Else
                        If Not adapter.GetPhysicalAddress.ToString = String.Empty And Not adapter.GetPhysicalAddress.ToString = "00000000000000E0" Then
                            myMac = adapter.GetPhysicalAddress.ToString
                            Exit For ' Got a mac so exit for
                        End If

                End Select
            Next adapter

            Return myMac
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function


    Public Function GenerarCadena() As String
        Dim numeroCaracteres As Integer = 20
        ' Dimensionamos un array para almacenar tanto las 
        ' letras mayúsculas como minúsculas (52 letras). 
        ' 
        Dim letras(51) As String

        ' Rellenamos el array. 
        ' 
        Dim n As Integer
        For item As Int32 = 65 To 90
            letras(n) = Chr(item)
            letras(n + 1) = letras(n).ToLower
            n += 2
        Next

        Dim cadenaAleatoria As String = String.Empty
        ' Iniciamos el generador de números aleatorios 
        ' 
        Dim rnd As New Random(DateTime.Now.Millisecond)

        For n = 0 To numeroCaracteres

            Dim numero As Integer = rnd.Next(0, 51)

            cadenaAleatoria &= letras(numero)
        Next
        Return cadenaAleatoria

    End Function



    Public Function listado() As DataTable
        Dim dt As New DataTable
        dt = lu.consultapc
        Return dt
    End Function



    Public Function listados() As DataTable
        Dim dt As New DataTable
        dt = lu.consultarcodigo
        Return dt
    End Function


    Public Function Buscarpc(u As Integer) As Entidades.Registropc
        Try
            Dim dr As DataRow
            Dim filtro As String
            Dim usu As New Entidades.Registropc
            filtro = String.Format("[id]='{0}'", u)
            dr = listado().Select(filtro)(0)
            usu.id = dr.Item("id")
            usu.usuario = dr.Item("usuario")
            usu.pass = dr.Item("Contraseña")
            usu.Nombrepc = dr.Item("NombrePC")
            usu.Ip = dr.Item("ip")
            usu.codigo = dr.Item("Codigo")
            usu.mac = dr.Item("mac")
            Return usu
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function BuscarCodigo(u As String) As Entidades.Registropc
        Try
            Dim dr As DataRow
            Dim filtro As String
            Dim usu As New Entidades.Registropc
            filtro = String.Format("[Usuario]='{0}'", u)
            dr = listados().Select(filtro)(0)
            usu.id = dr.Item("id")
            usu.usuario = dr.Item("usuario")
            usu.codigo = dr.Item("Codigo")
            Return usu
        Catch ex As Exception
            Return Nothing
        End Try
    End Function





End Class
