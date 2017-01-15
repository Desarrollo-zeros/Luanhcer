Imports System.Windows.Forms
Imports System.Threading

Public Class account
    Dim l As New Logica.account
    Dim usuario As New Entidades.account




    Sub user()
        Dim name As String = TextBox1.Text
        Dim pass As String = TextBox2.Text
        usuario = l.buscarPorUser(TextBox1.Text)
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Por favor dijite los datos")
        Else
            If usuario Is Nothing Then
                MsgBox("el usuario no existe")
            Else
                If usuario.sha_pass_hash = l.clic(TextBox1.Text, TextBox2.Text) Then
                    Dim wow As Process = Process.Start("E:\wow 3.3.5a\wow.exe")
                    wow.WaitForInputIdle()
                    Do
                        If wow.Responding Then
                            Thread.Sleep(100)
                            SendKeys.Send("" + usuario.username + "")
                            Thread.Sleep(1)
                            SendKeys.Send("{TAB}")
                            Thread.Sleep(1)
                            SendKeys.Send("" + pass + "")
                            SendKeys.Send("{ENTER}")
                            Exit Do
                        End If
                    Loop Until 2 = 1

                End If
            End If
        End If

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        user()
    End Sub

    Private Sub account_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class