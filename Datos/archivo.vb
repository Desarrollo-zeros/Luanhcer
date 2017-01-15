Imports System.IO

Public Class archivo
    Inherits archivodb
    Sub New(_ruta As String)
        MyBase.New(_ruta)
    End Sub

    Overloads Function leer() As List(Of Entidades.Usuario)
        Try
            Dim lista As New List(Of Entidades.Usuario)
            Dim sr As New StreamReader(ruta)
            Do While Not sr.EndOfStream
                lista.Add(New Entidades.Usuario(sr.ReadLine))
            Loop
            sr.Close()
            Return lista
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
