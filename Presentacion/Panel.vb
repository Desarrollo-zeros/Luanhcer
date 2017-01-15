Imports System.Drawing
Imports System.Windows.Forms
Imports System.Net
Imports System.Threading
Imports System.IO

Public Class Panel
    Public launcher_update As Boolean
    Public started As Boolean
    Dim logica As String
    Dim lu As New Logica.characters
    Dim lus As New Logica.account
    Dim en As New Entidades.account
    Dim WithEvents CLIENTE As New WebClient

    Private Sub Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        noticiasTxt.ReadOnly = True
        downloadedLb.Visible = False
        boton(BtnCata)
        boton(BtnLk)
        boton(Button2)
        noticiasTxt.Text = lus.Noticia
        Button1.Visible = False
    End Sub


    Sub boton(boton As Button)
        Dim buttonLocation As Point = Me.PictureBox1.PointToClient(Me.PointToScreen(boton.Location))

        boton.Parent = Me.PictureBox1
        boton.Location = buttonLocation

        Dim buttonBackground As New Bitmap(boton.Width, boton.Height)

        Using g As Graphics = Graphics.FromImage(buttonBackground)
            g.DrawImage(Me.PictureBox1.Image, _
                        New Rectangle(0, _
                                      0, _
                                      buttonBackground.Width, _
                                      buttonBackground.Height), _
                        boton.Bounds, _
                        GraphicsUnit.Pixel)
        End Using

        boton.BackgroundImage = buttonBackground
    End Sub

    Private Sub btnforo_Click(sender As Object, e As EventArgs) Handles btnforo.Click
        Process.Start("http://wow-letal.xyz/foro/")
    End Sub

    Private Sub btnweb_Click(sender As Object, e As EventArgs) Handles btnweb.Click
        Process.Start("http://wow-letal.xyz/")
    End Sub

    Private Sub BtnOnline_Click(sender As Object, e As EventArgs) Handles BtnOnline.Click
        online.Cbliz.Text = lu.Total_onlineB
        online.CFun.Text = lu.Total_onlineC
        online.Lk.Text = lu.Total_onlineL
        online.Show()
    End Sub

    Private Sub BTnTienda_Click(sender As Object, e As EventArgs) Handles BTnTienda.Click
        MessageBox.Show("Herramienta en Mantenimiento Att: Dev-Zeros", "WoW-Letal")
    End Sub

    Private Sub BTnCuenta_Click(sender As Object, e As EventArgs) Handles BTnCuenta.Click
        Cuenta.Show()
    End Sub

    Private Sub BtnCata_Click(sender As Object, e As EventArgs) Handles BtnCata.Click
        Dim log As New Logica.WoW
        If File.Exists("WoWCata.txt") Then
            Dim wow As Process = Process.Start(log.leerCata)
            wow.WaitForInputIdle()
            Do
                If wow.Responding Then
                    Thread.Sleep(100)
                    SendKeys.Send(Login.usuario.username)
                    Thread.Sleep(2)
                    SendKeys.Send("{TAB}")
                    Thread.Sleep(5)
                    SendKeys.Send(Login.passtxt.Text)
                    Thread.Sleep(5)
                    SendKeys.Send("{ENTER}")
                    Exit Do
                End If
            Loop Until 2 = 1
            ' Process.Start(log.leerLk)
        Else
            Dim wow As String
            Dim reul As MsgBoxResult = MessageBox.Show("Para Abrir y guardar la Direcion en el launcher de tu cliente de juego debes Colocar el ejecutable, por ejemplo wow.exe", "WoW-Letal")
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                wow = OpenFileDialog1.FileName
                log.EscribirCata(wow)
                Dim wows As Process = Process.Start(log.leerCata)
                wows.WaitForInputIdle()
                Do
                    If wows.Responding Then
                        Thread.Sleep(100)
                        SendKeys.Send(Login.usuario.username)
                        Thread.Sleep(2)
                        SendKeys.Send("{TAB}")
                        Thread.Sleep(5)
                        SendKeys.Send(Login.passtxt.Text)
                        Thread.Sleep(5)
                        SendKeys.Send("{ENTER}")
                        Exit Do
                    End If
                Loop Until 2 = 1
            End If
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles noticiasTxt.TextChanged, noticiasTxt.TextChanged
        'noticiasTxt.Text = lus.Noticia
    End Sub

    Private Sub Btn335_Click(sender As Object, e As EventArgs) Handles Btn335.Click
        Dim rel As MsgBoxResult = MessageBox.Show("Desea Usted Descargar El juego?, Pesa aproximadamente 18GB ", "WoW-Letal", MessageBoxButtons.YesNo)
        If rel = vbYes Then
            Try
                CLIENTE = New WebClient
                downloadedLb.Visible = True
                My.Computer.FileSystem.CreateDirectory("WoW3.3.5a")
                CLIENTE.DownloadFileAsync(New Uri("http://s1.cdn.downloads.wowcore.net/c52876ea206c1b61efb9"), Application.StartupPath & "\WoW3.3.5a\WoW-Letal 3.3.5a.rar") ' ASINCRONICO. SE COMPORTA COMO UN THREAD. NO SE BLOQUEA.
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub CLIENTE_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles CLIENTE.DownloadProgressChanged

        Try

            'downloadedLb.Text = "Donwloaded : " & e.BytesReceived / 100000000 & " MB / " & e.TotalBytesToReceive / 100000000 & " MB  "
            Dim a As Integer = e.BytesReceived / 1024 / 1024
            Dim b As Integer = e.TotalBytesToReceive / 1024 / 1048576
            downloadedLb.Text = "Downloaded: " & a & " MB / " & b & " GB"
            downloadedLb.Text = "( " & ProgressBar1.Value & "% )" & "" + downloadedLb.Text + ""
            downloadedLb.TextAlign = HorizontalAlignment.Center
            ProgressBar1.Value = e.ProgressPercentage
        Catch ex As Exception
            MsgBox("Error ! " & ex.Message)
        End Try

    End Sub

    Private Sub CLIENTE_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles CLIENTE.DownloadFileCompleted
        MsgBox("DESCARGA FINALIZADA") ' YA SE HA DESCARGADO COMPLETAMENTE.
        Button1.Visible = True

    End Sub

    Private Sub Btn434_Click(sender As Object, e As EventArgs) Handles Btn434.Click
        Dim rel As MsgBoxResult = MessageBox.Show("Desea Usted Descargar El juego?, Pesa aproximadamente 18GB y este se descagara mientras jueagas", "WoW-Letal", MessageBoxButtons.YesNo)
        If rel = vbYes Then
            Try
                downloadedLb.Visible = True

                CLIENTE = New WebClient
                CLIENTE.DownloadFileAsync(New Uri("http://wow-letal.xyz/wowDescarga/Wow.exe"), Application.StartupPath & "\WoW4.3.4\Wow.exe") ' ASINCRONICO. SE COMPORTA COMO UN THREAD. NO SE BLOQUEA.
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnLk_Click(sender As Object, e As EventArgs) Handles BtnLk.Click
        Dim log As New Logica.WoW
        If File.Exists("WoWLK.txt") Then
            Dim wow As Process = Process.Start(log.leerLk)
            wow.WaitForInputIdle()
            Do
                If wow.Responding Then
                    Thread.Sleep(100)
                    SendKeys.Send(Login.usuario.username)
                    Thread.Sleep(2)
                    SendKeys.Send("{TAB}")
                    Thread.Sleep(2)
                    SendKeys.Send(Login.passtxt.Text)
                    SendKeys.Send("{ENTER}")
                    Exit Do
                End If
            Loop Until 2 = 1
            ' Process.Start(log.leerLk)
        Else
            Dim wow As String
            Dim reul As MsgBoxResult = MessageBox.Show("Para Abrir y guardar la Direcion en el launcher de tu cliente de juego debes Colocar el ejecutable, por ejemplo wow.exe", "WoW-Letal")
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                wow = OpenFileDialog1.FileName
                log.escribirLk(wow)
                Dim wows As Process = Process.Start(log.leerLk)
                wows.WaitForInputIdle()
                Do
                    If wows.Responding Then
                        Thread.Sleep(100)
                        SendKeys.Send(Login.usuario.username)
                        Thread.Sleep(2)
                        SendKeys.Send("{TAB}")
                        Thread.Sleep(2)
                        SendKeys.Send(Login.passtxt.Text)
                        SendKeys.Send("{ENTER}")
                        Exit Do
                    End If
                Loop Until 2 = 1
            End If
        End If
    End Sub

    Private Sub OpenFileDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Process.Start("WoW4.3.4\Wow.exe")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCancelarC_Click(sender As Object, e As EventArgs) Handles btnCancelarC.Click
        Dim reul As MsgBoxResult = MessageBox.Show("Desea Canselar La Descarga?", "WoW-Letal", MessageBoxButtons.YesNo)
        If reul = vbYes Then
            CLIENTE.CancelAsync()
        End If
    End Sub

    Private Sub btnCancelarL_Click(sender As Object, e As EventArgs) Handles btnCancelarL.Click
        Dim reul As MsgBoxResult = MessageBox.Show("Desea Canselar La Descarga?", "WoW-Letal", MessageBoxButtons.YesNo)
        If reul = vbYes Then
            CLIENTE.CancelAsync()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("No hay Reino online para Pandaria, esta en desarrollo", "WoW-Letal")
    End Sub

    Private Sub Panel_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Dim reul As MsgBoxResult = MessageBox.Show("Desea usted salir?, si hay una descarga activa la perdera?", "WoW-Letal", MessageBoxButtons.YesNo)
                If reul = vbYes Then
                    Me.Dispose()
                    Cuenta.Dispose()
                    Login.Show()
                Else
                    e.Cancel = True
                End If
        Catch ex As Exception
        End Try
    End Sub
End Class