Imports System.IO

Public Class archivodb
    Private _r As String
    Public ReadOnly Property ruta As String
        Get
            Return _r
        End Get
    End Property
    Sub New(_ruta As String)
        _r = _ruta
    End Sub

    Function guardar(datos As String) As String
        Try
            Dim sw As New StreamWriter(ruta, True)
            sw.WriteLine(datos)
            sw.Close()
            Return "Se ha Guardado Correctamente su Usuario y Contraseña al launcher"
        Catch ex As Exception
            Return "error al guardar"
        End Try
    End Function


    Function guardarr(datos As String) As String
        Try
            '1. abrir para escritura
            Dim sw As New StreamWriter(ruta, True)
            '2 operacion
            sw.WriteLine(datos)
            '3. cerrar el flujo - guardar en disco
            sw.Close()
            Return "se agregaron los datos satisfactoriamente ..!"
        Catch ex As Exception
            Return "error al guardar!:Fguardar" & vbCrLf & ex.Message
        End Try
    End Function


    Function leer() As List(Of String)
        Try
            Dim lista As New List(Of String)
            Dim sr As New StreamReader(ruta)
            Do While Not sr.EndOfStream
                lista.Add(sr.ReadLine)
            Loop
            Return lista
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class
