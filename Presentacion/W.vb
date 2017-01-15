Imports System.Windows.Forms
Imports System.Net
Imports System.IO
Imports System.Threading

Public Class WoW_Letals
    Public launcher_update As Boolean
    Public started As Boolean
    Dim logica As String
    Dim lu As New Logica.characters
    Dim lus As New Logica.account
    Dim en As New Entidades.account
    Dim WithEvents CLIENTE As New WebClient


    Sub impir()
        Timer1.Enabled = True
        Timer1.Interval = 2
        Timer1.Start()
        noticiasTxt.ReadOnly = True
        ProgressBar1.Visible = False
        downloadedLb.TextAlign = Drawing.ContentAlignment.BottomCenter
        onlineA1.Text = lu.Total_onlineC
        onlineh2.Text = lu.Total_onlineB
        onlineh3.Text = lu.Total_onlineL
        noticiasTxt.Text = lus.Noticia
    End Sub
    Private Sub WoW_Letal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            noticiasTxt.ReadOnly = True
            ProgressBar1.Visible = False
            downloadedLb.TextAlign = Drawing.ContentAlignment.BottomCenter
            onlineA1.Text = lu.Total_onlineC
            onlineh2.Text = lu.Total_onlineB
            onlineh3.Text = lu.Total_onlineL
            onlineA1.ReadOnly = True
            onlineh3.ReadOnly = True
            onlineh2.ReadOnly = True
            noticiasTxt.Text = lus.Noticia
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BTnWeb_Click(sender As Object, e As EventArgs) Handles BTnWeb.Click
        Process.Start("http://wow-letal.xyz/")
    End Sub

    Private Sub BTNf_Click(sender As Object, e As EventArgs) Handles BTNf.Click
        Process.Start("http://wow-letal.xyz/foro/")
    End Sub

    Private Sub WoW_Letal_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If ProgressBar1.Value Then
                Me.Dispose()
                Cuenta.Dispose()
                Login.Show()

            Else
                Dim reul As MsgBoxResult = MessageBox.Show("Desea usted salir?, si hay una descarga activa la perdera?", "WoW-Letal", MessageBoxButtons.YesNo)
                If reul = vbYes Then
                    Me.Dispose()
                    Cuenta.Dispose()
                    Login.Show()
                Else
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub BtnCL_Click(sender As Object, e As EventArgs) Handles BtnCL.Click
        Dim rel As MsgBoxResult = MessageBox.Show("Desea Usted Descargar El juego?, Pesa aproximadamente 18GB ", "WoW-Letal", MessageBoxButtons.YesNo)
        If rel = vbYes Then
            Try
                CLIENTE = New WebClient

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
        btnjugar.Visible = True
        BtnCL.Visible = True
        BtnCC.Visible = True
        Button2.Visible = True
        Button1.Visible = True
    End Sub



    Private Sub downloadedLb_TextChanged(sender As Object, e As EventArgs)
        downloadedLb.Invalidate()
        ProgressBar1.Invalidate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim reul As MsgBoxResult = MessageBox.Show("Desea Cancelar La Descarga?", "WoW-Letal", MessageBoxButtons.YesNo)
        If reul = vbYes Then
            CLIENTE.CancelAsync()
            Button2.Visible = True
            Button1.Visible = True
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim reul As MsgBoxResult = MessageBox.Show("Desea Canselar La Descarga?", "WoW-Letal", MessageBoxButtons.YesNo)
        If reul = vbYes Then
            CLIENTE.CancelAsync()
        End If
    End Sub

    Private Sub BtnCC_Click(sender As Object, e As EventArgs) Handles BtnCC.Click
        Dim rel As MsgBoxResult = MessageBox.Show("Desea Usted Descargar El juego?, Pesa aproximadamente 18GB y este se descagara mientras jueagas", "WoW-Letal", MessageBoxButtons.YesNo)
        If rel = vbYes Then
            Try
                ProgressBar1.Visible = True
                BtnCL.Visible = False
                BtnCC.Visible = False
                Button1.Visible = False
                CLIENTE = New WebClient
                CLIENTE.DownloadFileAsync(New Uri("http://wow-letal.xyz/wowDescarga/Wow.exe"), Application.StartupPath & "\WoW4.3.4\Wow.exe") ' ASINCRONICO. SE COMPORTA COMO UN THREAD. NO SE BLOQUEA.
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub



    Private Sub btnjugar_Click(sender As Object, e As EventArgs) Handles btnjugar.Click
        Try
            Process.Start("WoW4.3.4\Wow.exe")
        Catch ex As Exception

        End Try
    End Sub


    Private Sub BtnAcc_Click(sender As Object, e As EventArgs) Handles BtnAcc.Click
        Cuenta.Show()
    End Sub

    Private Sub Btnser_Click(sender As Object, e As EventArgs) Handles Btnser.Click
        onlineA1.Text = lu.Total_onlineC
        onlineh2.Text = lu.Total_onlineB
        onlineh3.Text = lu.Total_onlineL
        MessageBox.Show("En Desarrollo ATT: Dev Zeros")
    End Sub

    Private Sub BtnDo_Click(sender As Object, e As EventArgs) Handles BtnDo.Click
        MessageBox.Show("En Desarrollo ATT: Dev Zeros")
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
                log.EscribirCata(wow)
                Dim wows As Process = Process.Start(log.leerCata)
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

    Private Sub Btnlk_Click(sender As Object, e As EventArgs) Handles Btnlk.Click
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = True
        Timer1.Interval = 2000
        Timer1.Start()
        onlineA1.Text = lu.Total_onlineC
        onlineh2.Text = lu.Total_onlineB
        onlineh3.Text = lu.Total_onlineL
        noticiasTxt.Text = lus.Noticia
    End Sub

    Private Sub noticiasTxt_MouseDown(sender As Object, e As MouseEventArgs) Handles noticiasTxt.MouseDown
        noticiasTxt.Text = lus.Noticia
    End Sub


    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        noticiasTxt.Text = lus.Noticia
    End Sub
End Class