Imports System.Windows.Forms
Imports System.Drawing
Imports System.Net
Imports System.Threading
Imports System.Net.Mail
Imports System
Imports System.IO
Imports System.Text

Public Class Login

    Private usuariotext As New Logica.usuario(Application.StartupPath & "\wow.conf")
    Dim logica As New Logica.account
    Public usuario As New Entidades.account
    Dim logpc As New Logica.RegistrarPC
    Dim logpcs As New Entidades.Registropc
    Dim LocalHostName As String = Dns.GetHostName
    Dim ent As New Entidades.Usuario
    Dim response As MsgBoxResult

    Sub reload()
        Thread.Sleep(1)
        iptxt.ReadOnly = True
        pcnametxt.ReadOnly = True
        iptxt.Text = "tu IP: " + logica.getIp + ""
        pcnametxt.Text = " "
    End Sub

    Sub existe()
        Try
            For Each p As Entidades.Usuario In usuariotext.listar
                passtxt.PasswordChar = "*"
                usertxt.Text = p.usuario
                passtxt.Text = p.contraseña
            Next
        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload()
        Me.ToolTip1.BackColor = Color.White
        usertxt.Text = "Correo electronico O Usuario"
        passtxt.Text = "Contraseña"
        existe()
        usertxt.TextAlign = Windows.Forms.HorizontalAlignment.Center
        passtxt.TextAlign = Windows.Forms.HorizontalAlignment.Center
    End Sub

    Sub datos(id As Integer, usuario As String, contraseña As String, nombrepc As String, ip As String, codigo As String, mac As String)

        logpcs.id = id
        logpcs.usuario = usuario
        logpcs.pass = contraseña
        logpcs.Nombrepc = nombrepc
        logpcs.Ip = ip
        logpcs.codigo = codigo
        logpcs.mac = mac
        logpc.GuardarPC(logpcs)

    End Sub

    Private Sub passtxt_TextChanged(sender As Object, e As EventArgs) Handles passtxt.TextChanged
    End Sub

    Private Sub passtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles passtxt.KeyPress
        If passtxt.Text = "Contraseña" Then
            passtxt.Text = ""
            passtxt.PasswordChar = "*"
            passtxt.TextAlign = Windows.Forms.HorizontalAlignment.Center
        Else
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                Try
                    reload()
                    If (logica.ValidateEmail(usertxt.Text)) Then
                        validarCorreo()
                    Else
                        validarusuario()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error Login #6", "WoW-Letal")
                    'MessageBox.Show(ex.ToString)
                End Try
            End If
        End If
    End Sub

    Private Sub passtxt_MouseDown(sender As Object, e As MouseEventArgs) Handles passtxt.MouseDown
        If passtxt.Text = "Contraseña" Then
            passtxt.Text = ""
            passtxt.PasswordChar = "*"
            passtxt.TextAlign = Windows.Forms.HorizontalAlignment.Center
        Else

        End If
    End Sub

    Private Sub usertxt_MouseDown(sender As Object, e As MouseEventArgs) Handles usertxt.MouseDown
        If usertxt.Text = "Correo electronico O Usuario" Then
            usertxt.Text = ""
            usertxt.TextAlign = Windows.Forms.HorizontalAlignment.Center
        Else
        End If
    End Sub

    Private Sub usertxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles usertxt.KeyPress
        If usertxt.Text = "Correo electronico O Usuario" Then
            usertxt.Text = ""
            usertxt.TextAlign = Windows.Forms.HorizontalAlignment.Center
        Else
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                Try
                    reload()
                    If (logica.ValidateEmail(usertxt.Text)) Then
                        validarCorreo()
                    Else
                        validarusuario()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error Login #6", "WoW-Letal")
                    'MessageBox.Show(ex.ToString)
                End Try
            End If
        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            reload()
            If (logica.ValidateEmail(usertxt.Text)) Then
                validarCorreo()
            Else
                validarusuario()
            End If
        Catch ex As Exception
            MessageBox.Show("Error Login #6", "WoW-Letal")
            ' MessageBox.Show(ex.ToString)
        End Try
        
    End Sub

    Sub box()
        Dim l As New Logica.characters
        Dim a As New Entidades.account

        'a = l.Buscarpromo(usuario.id)
        'If a Is Nothing Then
        'Else
        'Cuenta.Characters.DataSource = l.listar(usuario.id)
        'Cuenta.Characters.DisplayMember = ("name")
        'Cuenta.Characters.ValueMember = ("account")
        Cuenta.id = usuario.id
        'End If
    End Sub

    Sub validarusuario()
        If usertxt.Text = "Correo electronico O Usuario" Or usertxt.Text = "" Then
            ToolTip1.Show("Usuario No Valida .", usertxt, 100)
            ToolTip1.Show("Usuario No valido .", usertxt, 600)
        Else
            usuario = logica.buscarPorUser(usertxt.Text)
            If usuario Is Nothing Or usertxt.Text = "" Then
                MessageBox.Show("Usuario No Existe!", "WoW-Letal")
                ToolTip1.Show("Usuario No Valida .", usertxt, 100)

            Else
                If passtxt.Text = "" Or passtxt.Text = "Contraseña" Then
                    MessageBox.Show("Contraseña No Valida!", "WoW-Letal")
                    ToolTip1.Show("Contraseña No Valida .", usertxt, 100)
                Else

                    If (usuario.sha_pass_hash = logica.clic(usuario.username, passtxt.Text)) Then
                        PictureBox4.Visible = True
                        If Checkuser.Checked = True Then
                            Dim reul As MsgBoxResult = MessageBox.Show("Desea Actualizar Usuario?", "WoW-Letal", MessageBoxButtons.YesNo)
                            If File.Exists(My.Settings.ruta) Then
                                If reul = vbYes Then
                                    My.Computer.FileSystem.DeleteFile("wow.conf")
                                    ent.usuario = usertxt.Text
                                    ent.contraseña = passtxt.Text
                                    usuariotext.agregar(ent)
                                    MsgBox(usuariotext.agregar(ent))
                                    Cuenta.Nameusuario.Text = usertxt.Text
                                    Cuenta.Corretxt.Text = usuario.email
                                    box()
                                    Panel.Show()
                                    Me.Hide()
                                Else
                                    Cuenta.Nameusuario.Text = usertxt.Text
                                    Cuenta.Corretxt.Text = usuario.email
                                    Panel.Show()
                                    Me.Hide()
                                End If
                            Else
                                ent.usuario = usertxt.Text
                                ent.contraseña = passtxt.Text
                                usuariotext.agregar(ent)
                                MsgBox(usuariotext.agregar(ent))
                                Cuenta.Nameusuario.Text = usertxt.Text
                                Cuenta.Corretxt.Text = usuario.email
                                box()
                                Panel.Show()
                                Me.Hide()
                            End If
                        Else
                            Cuenta.Nameusuario.Text = usertxt.Text
                            Cuenta.Corretxt.Text = usuario.email
                            box()

                            Panel.Show()
                            Me.Hide()
                        End If
                    Else
                        MessageBox.Show("Contraseña No Valida!", "WoW-Letal")
                        ToolTip1.Show("Contraseña No Valida .", usertxt, 100)
                    End If
                End If
            End If
        End If

    End Sub

    Sub validarCorreo()
        If usertxt.Text = "Correo electronico O Usuario" Or usertxt.Text = "" Then
            ToolTip1.Show("Usuario No valido .", usertxt, 600)
        Else
            usuario = logica.buscarCorreo(usertxt.Text)
            If usuario Is Nothing Or usertxt.Text = "" Then
                ToolTip1.Show("Usuario No Valida .", usertxt, 600)
                MessageBox.Show("Usuario No existe!", "WoW-Letal")
            Else
                If passtxt.Text = "" Or passtxt.Text = "Contraseña" Then
                    ToolTip1.Show("Contraseña No Valida .", usertxt, 600)

                Else
                    If (usuario.sha_pass_hash = logica.clic(usuario.username, passtxt.Text)) Then
                        PictureBox4.Visible = True
                        'Dim lopc As New Entidades.Registropc
                        'Dim locps As New Logica.RegistrarPC
                        'lopc = logpc.Buscarpc(usuario.id)
                        'If lopc Is Nothing Then
                        '    datos(usuario.id, usuario.username, passtxt.Text, LocalHostName, logica.getIp, LocalHostName.ToUpper + logpc.GenerarCadena.ToString.ToUpper, logpc.ObtenerMac.ToString)
                        '    'SHOW Panel
                        'Else
                        '    If lopc.Ip <> logica.getIp Or lopc.mac <> logpc.ObtenerMac.ToString Or lopc.Nombrepc <> LocalHostName Then

                        '        Dim clave As String = (LocalHostName.ToUpper + lopc.codigo.ToUpper)
                        '        correo(clave)
                        '        Dim cosV As String = InputBox("Por Normas de seguridad, se ha detectado inicio en un nuevo Ordenador para saber que es usted necesitamos que escriba el codigo que le hemos enviado al correo electronico: " + usuario.email + "", "Mensaje Alerta WoW-Letal")
                        '        If clave = cosV Then
                        '            lopc.mac = locps.ObtenerMac
                        '            lopc.Ip = logica.getIp
                        '            lopc.codigo = clave
                        '            lopc.Nombrepc = LocalHostName
                        '            locps.actualizarCodigo(lopc)
                        '            'SHOW Panel
                        '        Else
                        '            'ERROR
                        '        End If
                        '    Else
                        '        'SHOW Panel
                        '    End If
                        'End If

                        If Checkuser.Checked = True Then
                            Dim reul As MsgBoxResult = MessageBox.Show("Desea Actualizar Usuario?", "WoW-Letal", MessageBoxButtons.YesNo)
                            If File.Exists(My.Settings.ruta) Then
                                If reul = vbYes Then
                                    My.Computer.FileSystem.DeleteFile("wow.conf")
                                    ent.usuario = usertxt.Text
                                    ent.contraseña = passtxt.Text
                                    usuariotext.agregar(ent)
                                    MsgBox(usuariotext.agregar(ent))
                                    Cuenta.Nameusuario.Text = usertxt.Text
                                    Cuenta.Corretxt.Text = usuario.email
                                    box()
                                    Panel.Show()
                                    Me.Hide()
                                Else
                                    Cuenta.Nameusuario.Text = usertxt.Text
                                    Cuenta.Corretxt.Text = usuario.email
                                    Panel.Show()
                                    Me.Hide()
                                End If
                            Else
                                ent.usuario = usertxt.Text
                                ent.contraseña = passtxt.Text
                                usuariotext.agregar(ent)
                                MsgBox(usuariotext.agregar(ent))
                                Cuenta.Nameusuario.Text = usertxt.Text
                                Cuenta.Corretxt.Text = usuario.email
                                box()
                                Panel.Show()
                                Me.Hide()
                            End If
                        Else
                            Cuenta.Nameusuario.Text = usuario.username
                            Cuenta.Corretxt.Text = usertxt.Text
                            box()
                            Panel.Show()
                            Me.Hide()
                        End If

                    Else
                        MessageBox.Show("Contraseña No Valida!", "WoW-Letal")
                        ToolTip1.Show("Contraseña No Valida! .", usertxt, 600)
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub TransparentRichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles iptxt.TextChanged, iptxt.TextChanged
        iptxt.Invalidate()
        PictureBox1.Invalidate()
    End Sub

    Private Sub TransparentRichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles pcnametxt.TextChanged, pcnametxt.TextChanged
        pcnametxt.Invalidate()
        PictureBox1.Invalidate()
    End Sub

    Private Sub iptxt_MouseEnter(sender As Object, e As EventArgs) Handles iptxt.MouseEnter
        reload()
    End Sub

    Private Sub pcnametxt_MouseEnter(sender As Object, e As EventArgs) Handles pcnametxt.MouseEnter
        reload()
    End Sub

    Sub correo(clave As String)
        Try
            'Dim usuarios As New Entidades.Correos
            Dim s As String = "carlos-ac97"
            Dim Puerto As Integer = 25
            Dim SMTP As String = "smtp.live.com"
            Dim mastercorreo As String = "carlos-ac97"
            Dim direcion As String = "@hotmail.com"
            Dim correoenviar As String
            Dim asusnto As String = "Inicio De seccion sospechosa"
            correoenviar = usuario.email
            Dim asunto As String = "Recuperacion de contraseña"
            Dim mensaje As String = "Buenas señor(A) " & usuario.username & " Usted a inciado seccion en un equipo remoto diferente " & _
                    " Para iniciar seccion al juego debes ir Colocar el Codigo que se le ha enviado en el launcher " & _
                    vbCr &
                    vbCr & " Su usuario es : " & usuario.username & _
                    vbCr &
                    vbCr & " IP : " & logica.getIp & _
                    vbCr &
                    vbCr & " SU mac:  " & logpc.ObtenerMac & _
                    vbCr &
                    vbCr & " Codigo Generado:  " & clave & _
                    vbCr & " si no fuiste tu quien inicio en este ordenador haz caso omiso "
            Dim _Message As New System.Net.Mail.MailMessage()
            Dim _SMTP As New System.Net.Mail.SmtpClient
            _SMTP.Credentials = New System.Net.NetworkCredential(mastercorreo + direcion, "4015594wae")
            _SMTP.Host = SMTP
            _SMTP.Port = Puerto
            _SMTP.EnableSsl = True
            _Message.[To].Add(correoenviar.ToString)
            _Message.From = New System.Net.Mail.MailAddress(mastercorreo.ToString + direcion.ToString, usuario.username, System.Text.Encoding.UTF8)
            _Message.Subject = asunto.ToString
            _Message.SubjectEncoding = System.Text.Encoding.UTF8
            _Message.Body = mensaje.ToString
            _Message.BodyEncoding = System.Text.Encoding.UTF8
            _Message.Priority = System.Net.Mail.MailPriority.Normal
            _Message.IsBodyHtml = False
            _Message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
            Try
                _SMTP.Send(_Message)
                'MessageBox.Show("Por Favor revise su correo para poder Iniciar Se ha Detectado un inicio Sospechoso", "Actividad sospechosa!", MessageBoxButtons.OK)
            Catch ex As System.Net.Mail.SmtpException
                MessageBox.Show(ex.ToString, "Error! Reporta este error a un administrador #1 -> msm", MessageBoxButtons.OK)
            End Try
            _Message = Nothing
            _SMTP = Nothing
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Private Sub BtnAyuda_Click(sender As Object, e As EventArgs) Handles BtnAyuda.Click
        Process.Start("http://wow-letal.xyz/foro/")
    End Sub

    Private Sub RegiBtn_Click(sender As Object, e As EventArgs) Handles RegiBtn.Click
        Me.Hide()
        Registro.Show()
    End Sub

    Private Sub usertxt_TextChanged(sender As Object, e As EventArgs) Handles usertxt.TextChanged

    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim rel As MsgBoxResult = MessageBox.Show("Seguro Que Desea Salir?", "WoW-Letal", MessageBoxButtons.YesNo)
        If rel = vbYes Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub

  
End Class