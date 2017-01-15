<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtpass1 = New System.Windows.Forms.TextBox()
        Me.VersBox = New System.Windows.Forms.ComboBox()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.BtnAtras = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(799, 445)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtusuario
        '
        Me.txtusuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtusuario.Location = New System.Drawing.Point(491, 70)
        Me.txtusuario.Multiline = True
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(256, 25)
        Me.txtusuario.TabIndex = 23
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtemail.Location = New System.Drawing.Point(491, 111)
        Me.txtemail.Multiline = True
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(256, 25)
        Me.txtemail.TabIndex = 29
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpass.Location = New System.Drawing.Point(491, 156)
        Me.txtpass.Multiline = True
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(256, 25)
        Me.txtpass.TabIndex = 30
        '
        'txtpass1
        '
        Me.txtpass1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtpass1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpass1.Location = New System.Drawing.Point(491, 199)
        Me.txtpass1.Multiline = True
        Me.txtpass1.Name = "txtpass1"
        Me.txtpass1.Size = New System.Drawing.Size(256, 25)
        Me.txtpass1.TabIndex = 31
        '
        'VersBox
        '
        Me.VersBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersBox.FormattingEnabled = True
        Me.VersBox.Items.AddRange(New Object() {"Mop", "Cataclysh", "LK", "TBC", "Vanilla"})
        Me.VersBox.Location = New System.Drawing.Point(491, 239)
        Me.VersBox.Name = "VersBox"
        Me.VersBox.Size = New System.Drawing.Size(256, 21)
        Me.VersBox.TabIndex = 32
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnRegistrar.Image = CType(resources.GetObject("BtnRegistrar.Image"), System.Drawing.Image)
        Me.BtnRegistrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnRegistrar.Location = New System.Drawing.Point(491, 276)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnRegistrar.Size = New System.Drawing.Size(133, 28)
        Me.BtnRegistrar.TabIndex = 33
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = False
        '
        'BtnAtras
        '
        Me.BtnAtras.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAtras.Image = CType(resources.GetObject("BtnAtras.Image"), System.Drawing.Image)
        Me.BtnAtras.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnAtras.Location = New System.Drawing.Point(630, 276)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnAtras.Size = New System.Drawing.Size(117, 28)
        Me.BtnAtras.TabIndex = 34
        Me.BtnAtras.Text = "Atras"
        Me.BtnAtras.UseVisualStyleBackColor = False
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(796, 442)
        Me.Controls.Add(Me.BtnAtras)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.VersBox)
        Me.Controls.Add(Me.txtpass1)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Registro"
        Me.Text = "Registro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtpass1 As System.Windows.Forms.TextBox
    Friend WithEvents VersBox As System.Windows.Forms.ComboBox
    Friend WithEvents BtnRegistrar As System.Windows.Forms.Button
    Friend WithEvents BtnAtras As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
