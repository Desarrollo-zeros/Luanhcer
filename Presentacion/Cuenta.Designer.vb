<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cuenta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cuenta))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Nickname = New System.Windows.Forms.Label()
        Me.Nameusuario = New System.Windows.Forms.Label()
        Me.Corretxt = New System.Windows.Forms.Label()
        Me.Correo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(525, 379)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Nickname
        '
        Me.Nickname.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Nickname.Location = New System.Drawing.Point(36, 67)
        Me.Nickname.Name = "Nickname"
        Me.Nickname.Size = New System.Drawing.Size(121, 17)
        Me.Nickname.TabIndex = 2
        Me.Nickname.Text = "Usuario"
        Me.Nickname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Nameusuario
        '
        Me.Nameusuario.BackColor = System.Drawing.Color.Firebrick
        Me.Nameusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nameusuario.Location = New System.Drawing.Point(163, 67)
        Me.Nameusuario.Name = "Nameusuario"
        Me.Nameusuario.Size = New System.Drawing.Size(143, 17)
        Me.Nameusuario.TabIndex = 5
        Me.Nameusuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Corretxt
        '
        Me.Corretxt.BackColor = System.Drawing.Color.Firebrick
        Me.Corretxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Corretxt.Location = New System.Drawing.Point(163, 102)
        Me.Corretxt.Name = "Corretxt"
        Me.Corretxt.Size = New System.Drawing.Size(143, 17)
        Me.Corretxt.TabIndex = 7
        Me.Corretxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Correo
        '
        Me.Correo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Correo.Location = New System.Drawing.Point(36, 102)
        Me.Correo.Name = "Correo"
        Me.Correo.Size = New System.Drawing.Size(121, 17)
        Me.Correo.TabIndex = 6
        Me.Correo.Text = "Correo Electronico"
        Me.Correo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(39, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(267, 65)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Moneda De Promocion " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "10 Puntos De Donacion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(312, 67)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(212, 244)
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGray
        Me.Button2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button2.Location = New System.Drawing.Point(48, 241)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Cambiar Contraseña"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Cuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(520, 310)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Corretxt)
        Me.Controls.Add(Me.Correo)
        Me.Controls.Add(Me.Nameusuario)
        Me.Controls.Add(Me.Nickname)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Cuenta"
        Me.Text = "Cuenta"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Nickname As System.Windows.Forms.Label
    Friend WithEvents Nameusuario As System.Windows.Forms.Label
    Friend WithEvents Corretxt As System.Windows.Forms.Label
    Friend WithEvents Correo As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
