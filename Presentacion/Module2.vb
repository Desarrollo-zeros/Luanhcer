Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Windows.Forms

Module Module2

    'Dim Username = "zeros"
    'Dim PostData = "user_name=" & Username
    'Dim request As WebRequest = WebRequest.Create("http://localhost/")
    'Sub main()
    '    request.Method = "POST"
    '    Dim byteArray As Byte() = Encoding.UTF8.GetBytes(PostData)
    '    request.ContentType = "application/x-www-form-urlencoded"
    '    request.ContentLength = byteArray.Length
    '    Dim dataStream As Stream = request.GetRequestStream()
    '    dataStream.Write(byteArray, 0, byteArray.Length)
    '    dataStream.Close()
    '    Dim response As WebResponse = request.GetResponse()
    '    dataStream = response.GetResponseStream()
    '    Dim reader As New StreamReader(dataStream)
    '    Dim responseFromServer As String = reader.ReadToEnd()
    '    reader.Close()
    '    dataStream.Close()
    '    response.Close()
    '    MsgBox(responseFromServer)
    'End Sub

    'Dim ent As New Entidades.Usuario
    'Private usuariotext As New Logica.usuario(Application.StartupPath & "\wow.conf")

    'Sub main()
    '    ent.usuario = "hola"
    '    ent.contraseña = "hi"
    '    usuariotext.agregar(ent)
    '    MsgBox(usuariotext.agregar(ent))
    'End Sub


    ' Declaraciones del Api
End Module
