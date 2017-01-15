<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WoW_Letals
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WoW_Letals))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnAcc = New System.Windows.Forms.Button()
        Me.Btnser = New System.Windows.Forms.Button()
        Me.BtnDo = New System.Windows.Forms.Button()
        Me.BTnWeb = New System.Windows.Forms.Button()
        Me.BTNf = New System.Windows.Forms.Button()
        Me.BtnCC = New System.Windows.Forms.Button()
        Me.BtnCL = New System.Windows.Forms.Button()
        Me.BtnCata = New System.Windows.Forms.Button()
        Me.Btnlk = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnjugar = New System.Windows.Forms.Button()
        Me.downloadedLb = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.noticiasTxt = New System.Windows.Forms.RichTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1294, 611)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtnAcc
        '
        Me.BtnAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAcc.Location = New System.Drawing.Point(51, 33)
        Me.BtnAcc.Name = "BtnAcc"
        Me.BtnAcc.Size = New System.Drawing.Size(120, 23)
        Me.BtnAcc.TabIndex = 8
        Me.BtnAcc.Text = "Estado De Cuenta"
        Me.BtnAcc.UseVisualStyleBackColor = False
        '
        'Btnser
        '
        Me.Btnser.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btnser.Location = New System.Drawing.Point(235, 33)
        Me.Btnser.Name = "Btnser"
        Me.Btnser.Size = New System.Drawing.Size(138, 23)
        Me.Btnser.TabIndex = 10
        Me.Btnser.Text = "Estado Del Servidor"
        Me.Btnser.UseVisualStyleBackColor = False
        '
        'BtnDo
        '
        Me.BtnDo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDo.Location = New System.Drawing.Point(432, 33)
        Me.BtnDo.Name = "BtnDo"
        Me.BtnDo.Size = New System.Drawing.Size(138, 23)
        Me.BtnDo.TabIndex = 13
        Me.BtnDo.Text = "Tienda De Donacion"
        Me.BtnDo.UseVisualStyleBackColor = False
        '
        'BTnWeb
        '
        Me.BTnWeb.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTnWeb.Location = New System.Drawing.Point(626, 33)
        Me.BTnWeb.Name = "BTnWeb"
        Me.BTnWeb.Size = New System.Drawing.Size(81, 23)
        Me.BTnWeb.TabIndex = 14
        Me.BTnWeb.Text = "Pagina web"
        Me.BTnWeb.UseVisualStyleBackColor = False
        '
        'BTNf
        '
        Me.BTNf.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTNf.Location = New System.Drawing.Point(740, 33)
        Me.BTNf.Name = "BTNf"
        Me.BTNf.Size = New System.Drawing.Size(66, 23)
        Me.BTNf.TabIndex = 14
        Me.BTNf.Text = "Foro"
        Me.BTNf.UseVisualStyleBackColor = False
        '
        'BtnCC
        '
        Me.BtnCC.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCC.Location = New System.Drawing.Point(25, 344)
        Me.BtnCC.Name = "BtnCC"
        Me.BtnCC.Size = New System.Drawing.Size(143, 23)
        Me.BtnCC.TabIndex = 17
        Me.BtnCC.Text = "Descargar WoW 4.3.4"
        Me.BtnCC.UseVisualStyleBackColor = False
        '
        'BtnCL
        '
        Me.BtnCL.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnCL.Location = New System.Drawing.Point(25, 541)
        Me.BtnCL.Name = "BtnCL"
        Me.BtnCL.Size = New System.Drawing.Size(146, 23)
        Me.BtnCL.TabIndex = 18
        Me.BtnCL.Text = "Descargar WoW 3.3.5a"
        Me.BtnCL.UseVisualStyleBackColor = False
        '
        'BtnCata
        '
        Me.BtnCata.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnCata.AutoEllipsis = True
        Me.BtnCata.BackColor = System.Drawing.Color.Transparent
        Me.BtnCata.BackgroundImage = CType(resources.GetObject("BtnCata.BackgroundImage"), System.Drawing.Image)
        Me.BtnCata.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCata.Image = CType(resources.GetObject("BtnCata.Image"), System.Drawing.Image)
        Me.BtnCata.Location = New System.Drawing.Point(25, 201)
        Me.BtnCata.Name = "BtnCata"
        Me.BtnCata.Size = New System.Drawing.Size(143, 137)
        Me.BtnCata.TabIndex = 19
        Me.BtnCata.UseVisualStyleBackColor = False
        '
        'Btnlk
        '
        Me.Btnlk.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Btnlk.AutoEllipsis = True
        Me.Btnlk.BackColor = System.Drawing.Color.Transparent
        Me.Btnlk.BackgroundImage = CType(resources.GetObject("Btnlk.BackgroundImage"), System.Drawing.Image)
        Me.Btnlk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnlk.Image = CType(resources.GetObject("Btnlk.Image"), System.Drawing.Image)
        Me.Btnlk.Location = New System.Drawing.Point(25, 403)
        Me.Btnlk.Name = "Btnlk"
        Me.Btnlk.Size = New System.Drawing.Size(146, 132)
        Me.Btnlk.TabIndex = 20
        Me.Btnlk.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(432, 569)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(331, 23)
        Me.ProgressBar1.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.Location = New System.Drawing.Point(25, 569)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Cancelar Descarga"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(25, 373)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Cancelar Descarga"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnjugar
        '
        Me.btnjugar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnjugar.Location = New System.Drawing.Point(769, 568)
        Me.btnjugar.Name = "btnjugar"
        Me.btnjugar.Size = New System.Drawing.Size(63, 23)
        Me.btnjugar.TabIndex = 25
        Me.btnjugar.Text = "Jugar"
        Me.btnjugar.UseVisualStyleBackColor = False
        Me.btnjugar.Visible = False
        '
        'downloadedLb
        '
        Me.downloadedLb.Location = New System.Drawing.Point(432, 569)
        Me.downloadedLb.Name = "downloadedLb"
        Me.downloadedLb.Size = New System.Drawing.Size(331, 22)
        Me.downloadedLb.TabIndex = 26
        Me.downloadedLb.Text = "0% Mb - 18GB"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        '
        'noticiasTxt
        '
        Me.noticiasTxt.BackColor = System.Drawing.Color.Gray
        Me.noticiasTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noticiasTxt.Location = New System.Drawing.Point(882, 80)
        Me.noticiasTxt.Name = "noticiasTxt"
        Me.noticiasTxt.Size = New System.Drawing.Size(352, 498)
        Me.noticiasTxt.TabIndex = 27
        Me.noticiasTxt.Text = ""
        '
        'WoW_Letal
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1275, 604)
        Me.Enabled = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "WoW_Letal"
        Me.Text = "Panel De Control"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents onlineA1 As Presentacion.TransparentRichTextBox
    Friend WithEvents onlineh2 As Presentacion.TransparentRichTextBox
    Friend WithEvents onlineh3 As Presentacion.TransparentRichTextBox
    Friend WithEvents BtnAcc As System.Windows.Forms.Button
    Friend WithEvents Btnser As System.Windows.Forms.Button
    Friend WithEvents BtnDo As System.Windows.Forms.Button
    Friend WithEvents BTnWeb As System.Windows.Forms.Button
    Friend WithEvents BTNf As System.Windows.Forms.Button
    Friend WithEvents BtnCC As System.Windows.Forms.Button
    Friend WithEvents BtnCL As System.Windows.Forms.Button
    Friend WithEvents BtnCata As System.Windows.Forms.Button
    Friend WithEvents Btnlk As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnjugar As System.Windows.Forms.Button
    Friend WithEvents downloadedLb As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents noticiasTxt As System.Windows.Forms.RichTextBox
End Class
