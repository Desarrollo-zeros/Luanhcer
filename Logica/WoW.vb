Imports System.IO
Imports System.Net.Mime.MediaTypeNames
Imports System.Text

Public Class WoW
    Dim objStreamReader As StreamReader
    Dim strLine As String

    Function leerLk()
        objStreamReader = New StreamReader("WoWLk.txt")
        strLine = objStreamReader.ReadLine
        objStreamReader.Close()
        Console.ReadLine()
        Return strLine
    End Function
    Function leerCata()
        objStreamReader = New StreamReader("WoWCata.txt")
        strLine = objStreamReader.ReadLine
        objStreamReader.Close()
        Console.ReadLine()
        Return strLine
    End Function

    Sub escribirLk(dr As String)
        Dim objStreamWriter As StreamWriter
        objStreamWriter = New StreamWriter("WoWLk.txt", True, Encoding.Unicode)
        objStreamWriter.WriteLine(dr)
        objStreamWriter.Close()
    End Sub

    Sub EscribirCata(dr As String)
        Dim objStreamWriter As StreamWriter
        objStreamWriter = New StreamWriter("WoWCata.txt", True, Encoding.Unicode)
        objStreamWriter.WriteLine(dr)
        objStreamWriter.Close()
    End Sub


End Class
