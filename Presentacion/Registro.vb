Imports System.Windows.Forms
Imports System.Net
Imports System.Net.Mail

Public Class Registro

    Dim logica As New Logica.account
    Dim entidades As New Entidades.account
    Dim LocalHostName As String = Dns.GetHostName
    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusuario.Text = "Usuario"
        txtemail.Text = "Correo electronico"
        txtpass.Text = "Contraseña"
        txtpass1.Text = "Repita la Contraseña"
        VersBox.Text = "Version"
        txtusuario.TextAlign = Windows.Forms.HorizontalAlignment.Center
        txtemail.TextAlign = Windows.Forms.HorizontalAlignment.Center
        txtpass.TextAlign = Windows.Forms.HorizontalAlignment.Center
        txtpass1.TextAlign = Windows.Forms.HorizontalAlignment.Center
    End Sub
    Private Sub VersBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VersBox.KeyPress
        e.KeyChar = ""
        Clipboard.Clear()
    End Sub
    Private Sub txtusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusuario.KeyPress
        If txtusuario.Text = "Usuario" Then
            txtusuario.Text = ""
            txtusuario.TextAlign = Windows.Forms.HorizontalAlignment.Center
        Else
        End If

    End Sub
    Private Sub txtusuario_MouseDown(sender As Object, e As MouseEventArgs) Handles txtusuario.MouseDown
        If txtusuario.Text = "Usuario" Then
            txtusuario.Text = ""
            txtusuario.TextAlign = Windows.Forms.HorizontalAlignment.Center
        Else
        End If
    End Sub
    Private Sub txtemail_MouseDown(sender As Object, e As MouseEventArgs) Handles txtemail.MouseDown
        If txtemail.Text = "Correo electronico" Then
            txtemail.Text = ""
            txtemail.TextAlign = Windows.Forms.HorizontalAlignment.Center
        Else
        End If
    End Sub
    Private Sub txtemail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtemail.KeyPress
        If txtemail.Text = "Correo electronico" Then
            txtemail.Text = ""
            txtemail.TextAlign = Windows.Forms.HorizontalAlignment.Center
        Else
        End If
    End Sub
    Private Sub txtpass_MouseDown(sender As Object, e As MouseEventArgs) Handles txtpass.MouseDown
        If txtpass.Text = "Contraseña" Then
            txtpass.Text = ""
            txtpass.PasswordChar = "*"
            txtpass.TextAlign = Windows.Forms.HorizontalAlignment.Center
        Else

        End If
    End Sub
    Private Sub txtpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpass.KeyPress
        If txtpass.Text = "Contraseña" Then
            txtpass.Text = ""
            txtpass.PasswordChar = "*"
            txtpass.TextAlign = Windows.Forms.HorizontalAlignment.Center
        Else

        End If
    End Sub
    Private Sub txtpass1_MouseDown(sender As Object, e As MouseEventArgs) Handles txtpass1.MouseDown
        If txtpass1.Text = "Repita la Contraseña" Then
            txtpass1.Text = ""
            txtpass1.PasswordChar = "*"
            txtpass1.TextAlign = Windows.Forms.HorizontalAlignment.Center
        Else

        End If
    End Sub
    Private Sub txtpass1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpass1.KeyPress
        If txtpass1.Text = "Repita la Contraseña" Then
            txtpass1.Text = ""
            txtpass1.PasswordChar = "*"
            txtpass1.TextAlign = Windows.Forms.HorizontalAlignment.Center
        Else

        End If
    End Sub
    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Try
            registrar()
        Catch ex As Exception
            MessageBox.Show("Error Registrar #7", "WoW-Letal")
        End Try

    End Sub
    Sub registrar()
        Try
            If txtusuario.Text = "" Or txtemail.Text = "" Or txtpass.Text = "" Or txtpass1.Text = "" Or VersBox.Text = "" Or txtusuario.Text = "Usuario" Or txtemail.Text = "Correo electronico" Or txtpass.Text = "Contraseña" Or txtpass1.Text = "Repita la Contraseña" Or VersBox.Text = "Version" Then
                ToolTip1.Show("Revise Bien los campos  .", BtnRegistrar, 600)
                MessageBox.Show("Uno o varios de los Campos del registro no esta correcto", "WoW-Letal")
            Else
                entidades = logica.buscarPorUser(txtusuario.Text)
                If entidades Is Nothing Then
                    If txtpass.Text = txtpass1.Text Then
                        If txtpass.TextLength >= 6 Then
                            If logica.ValidateEmail(txtemail.Text) And emails(txtemail.Text) Then
                                entidades = logica.buscarCorreo(txtemail.Text)
                                If entidades Is Nothing Then
                                    Dim clave As String = (LocalHostName + "WoW-Letal" + logica.clic(txtusuario.Text, txtpass.Text) + "WoW-Letal" + txtusuario.Text)
                                    Dim entidade As New Entidades.accregistro
                                    Dim logi As New Logica.account
                                    entidade.username = txtusuario.Text
                                    entidade.sha_pass_hash = logica.clic(txtusuario.Text, txtpass.Text)
                                    entidade.email = txtemail.Text
                                    entidade.reg_mail = txtemail.Text
                                    entidade.last_ip = logica.getIp
                                    entidade.expansion = 4
                                    logi.RegistrarUsuario(entidade)
                                    Dim en As New Entidades.account
                                    Dim ens As New Entidades.accregistro
                                    en = logica.buscarPorUser(txtusuario.Text)
                                    If en Is Nothing Then
                                        MessageBox.Show("Error #3 -->Registro Null", "WoW-Letal")
                                    Else
                                        ens.id = en.id
                                        ens.bandate = -1
                                        ens.unbandate = 0
                                        ens.bannedby = "Sistema De Registro"
                                        ens.banreason = "Registro No Completado"
                                        ens.active = 1
                                        'ens.Registro = 1
                                        logica.Registrarbaneo(ens)
                                    End If
                                    correo(clave.ToUpper)
                                    Dim control As Integer = 0
                                    Do
                                        Dim confirmacion As String = InputBox("Se te ha enviado un Mensaje con un codigo al correo electronico " + txtemail.Text + " por favor revisalo y usa ese codigo para completar el registro", "WoW-Letal")
                                        If confirmacion.ToUpper = clave.ToUpper Then
                                            logica.EliminarBaneo(ens.id)
                                            MessageBox.Show("Registro Beta WOW-Letal Rev 0.1  Su registro a sido todo un exito!", "WoW-Letal")
                                            control = 1
                                        Else
                                            MessageBox.Show("Codigo Erroneo Revisa tu correo y vuelve a intentarlo!", "WoW-Letal")
                                            control = 0
                                        End If
                                    Loop While (control = 0)
                                Else
                                    MessageBox.Show("El Correo Ya Existe!", "WoW-Letal")
                                End If
                            Else
                                MessageBox.Show("El Correo esta mal escrito o No es valido!", "WoW-Letal")
                            End If
                        Else
                            MessageBox.Show("La Contraseña Debe tener 6 Digitos", "WoW-Letal")
                        End If
                    Else
                        MessageBox.Show("La Contraseña No conciden", "WoW-Letal")
                    End If
                Else
                    MessageBox.Show("error el usuario ingresado ya existe", "WoW-Letal")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("error #5 Falla en el registro", "WoW-Letal")
        End Try
       
    End Sub
    Function emails(email As String)
        Dim Cadena As String = email
        Dim ArrCadena As String() = Cadena.Split("@")
        If ArrCadena(1) = "hotmail.com" Or ArrCadena(1) = "hotmail.es" Or ArrCadena(1) = "gmail.com" Or ArrCadena(1) = "yahoo.es" Or ArrCadena(1) = "yahoo.com" Or ArrCadena(1) = "outlook.com" Or ArrCadena(1) = "outlook.es" Or ArrCadena(1) = "mail.com" Or ArrCadena(1) = "gmx.com" Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub correo(clave As String)
        Try
            Dim logpc As New Logica.RegistrarPC
            'Dim usuarios As New Entidades.Correos
            Dim s As String = "carlos-ac97"
            Dim Puerto As Integer = 25
            Dim SMTP As String = "smtp.live.com"
            Dim mastercorreo As String = "carlos-ac97"
            Dim direcion As String = "@hotmail.com"
            Dim correoenviar As String
            'Dim asusnto As String = "Inicio De seccion sospechosa"
            correoenviar = txtemail.Text
            Dim asunto As String = "Registro de Usuario WoW-Letal"
            Dim mensaje As String = "Buenas señor(A) " & txtusuario.Text & " Usted se ha registrado " & _
                    " en el servidor WoW-Letal el dia " + Date.Now.ToString + " Por ese motivo le estamos enviado los siguientes datos " & _
                    vbCr &
                    vbCr & " Su usuario es : " & txtusuario.Text & _
                    vbCr &
                    vbCr & " IP : " & logica.getIp & _
                    vbCr &
                    vbCr & " SU mac:  " & logpc.ObtenerMac & _
                    vbCr &
                    vbCr & " Codigo Generado:  [" & clave.ToUpper & "]" & _
                    vbCr & " si no fuiste tu quien hizo el registro haz caso omiso "
            Dim _Message As New System.Net.Mail.MailMessage()
            Dim _SMTP As New System.Net.Mail.SmtpClient
            _SMTP.Credentials = New System.Net.NetworkCredential(mastercorreo + direcion, "4015594wae")
            _SMTP.Host = SMTP
            _SMTP.Port = Puerto
            _SMTP.EnableSsl = True
            _Message.[To].Add(correoenviar.ToString)
            _Message.From = New System.Net.Mail.MailAddress(mastercorreo.ToString + direcion.ToString, txtusuario.Text, System.Text.Encoding.UTF8)
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
    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles BtnAtras.Click
        Me.Close()
        Login.Show()
    End Sub
    Private Sub Registro_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        Login.Show()
    End Sub
End Class