Imports System.Windows.Forms

Public Class Cuenta


    Dim db As Datos.CharactersL
    Public id As Integer
    Dim lu As New Logica.web
    Dim a As New Entidades.account
    Dim lo As New Logica.account
    Dim loc As New Logica.characters

    Private Sub Cuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim l As New Logica.characters


        'a = l.Buscarpromo(usuario.id)
        'If a Is Nothing Then
        'Else
        'Characters.DataSource = l.listar(Login.usuario.id)
        'Characters.DisplayMember = ("name")
        'Characters.ValueMember = ("account")
        'End If
        Nameusuario.Text = Login.usuario.username
        Corretxt.Text = Login.usuario.email
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reul As MsgBoxResult = MessageBox.Show("Desea tomar la promocion con esta Cuenta?, Si aceptar quedara Registrada y tu ip sera bloqueada para no recibir mas promocion", "WoW-Letal", MessageBoxButtons.YesNo)
        If reul = vbYes Then
            'a.id = Login.usuario.id
            'a.username = Login.usuario.username
            'lu.Registrarpromo(a)
            a = lu.BuscarPromo(Login.usuario.id)
            If a Is Nothing Then
                Dim b As New Entidades.account
                b.id = Login.usuario.id
                b.username = Login.usuario.username
                lu.Registrarpromo(b)
            Else
                If lo.Verip(Login.usuario.last_ip) = True And lu.promo(Login.usuario.id) = "0" Then
                    lu.actualizardp(Login.usuario.id)
                Else
                    If lu.promo(Login.usuario.id) = "0" Then
                        lu.actualizardp(Login.usuario.id)
                    Else
                        MessageBox.Show("Su Ip tiene una cuenta ya con promocion!, SI Juegas en un ciber debes hablar con un gms para que este te ayude", "WoW-Letal")
                    End If
                End If
            End If
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            MessageBox.Show("Recuerda la Contraseña debe tener maximo 6 digito", "WoW-Letal")
            Dim a As Integer = 0
            Dim b As Integer = 0
            Dim ls As New Logica.account
            Dim rs As New Entidades.account
            Do
                Dim pass1 As String = InputBox("Cambios de contraseña en en la version 0.1 si presenta falla comunicate con asistencia o un gm", "WoW-Letal")
                Dim pass2 As String = InputBox("Vuelve a ingresar la contraseña", "WoW-Letal")
                If pass1 = pass2 And pass1.Length >= 6 And pass2.Length >= 6 Then
                    rs.username = Login.usuario.username
                    rs.sha_pass_hash = ls.clic(Login.usuario.username, pass1)
                    ls.actualizarpass(rs)
                    MessageBox.Show("Su cuenta ha sido actualizada")
                    a = 1
                Else
                    MessageBox.Show("Error, La contraseña digita no son iguales", "WoW-Letal")
                    a = 0
                End If
                b = 1
            Loop While (a = 0 And b = 0)

        Catch ex As Exception

        End Try
    End Sub
End Class