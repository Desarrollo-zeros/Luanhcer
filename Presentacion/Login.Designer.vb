<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnAyuda = New System.Windows.Forms.Button()
        Me.usertxt = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.RegiBtn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Checkuser = New System.Windows.Forms.CheckBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pcnametxt = New Presentacion.TransparentRichTextBox()
        Me.iptxt = New Presentacion.TransparentRichTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.MediumSeaGreen
        resources.ApplyResources(Me.BtnLogin, "BtnLogin")
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'BtnAyuda
        '
        Me.BtnAyuda.BackColor = System.Drawing.Color.MediumSeaGreen
        resources.ApplyResources(Me.BtnAyuda, "BtnAyuda")
        Me.BtnAyuda.Name = "BtnAyuda"
        Me.BtnAyuda.UseVisualStyleBackColor = False
        '
        'usertxt
        '
        Me.usertxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.usertxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.usertxt, "usertxt")
        Me.usertxt.Name = "usertxt"
        '
        'PictureBox2
        '
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'passtxt
        '
        Me.passtxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.passtxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.passtxt, "passtxt")
        Me.passtxt.Name = "passtxt"
        '
        'PictureBox3
        '
        resources.ApplyResources(Me.PictureBox3, "PictureBox3")
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.TabStop = False
        '
        'RegiBtn
        '
        Me.RegiBtn.BackColor = System.Drawing.Color.PaleTurquoise
        resources.ApplyResources(Me.RegiBtn, "RegiBtn")
        Me.RegiBtn.Name = "RegiBtn"
        Me.RegiBtn.UseVisualStyleBackColor = False
        '
        'Checkuser
        '
        resources.ApplyResources(Me.Checkuser, "Checkuser")
        Me.Checkuser.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Checkuser.Name = "Checkuser"
        Me.Checkuser.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        resources.ApplyResources(Me.PictureBox4, "PictureBox4")
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.TabStop = False
        '
        'pcnametxt
        '
        Me.pcnametxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.pcnametxt, "pcnametxt")
        Me.pcnametxt.Name = "pcnametxt"
        '
        'iptxt
        '
        Me.iptxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.iptxt, "iptxt")
        Me.iptxt.Name = "iptxt"
        '
        'Login
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Checkuser)
        Me.Controls.Add(Me.pcnametxt)
        Me.Controls.Add(Me.iptxt)
        Me.Controls.Add(Me.RegiBtn)
        Me.Controls.Add(Me.passtxt)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.usertxt)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnAyuda)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnAyuda As System.Windows.Forms.Button
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents RegiBtn As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents iptxt As Presentacion.TransparentRichTextBox
    Friend WithEvents pcnametxt As Presentacion.TransparentRichTextBox
    Friend WithEvents Checkuser As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Public WithEvents usertxt As System.Windows.Forms.TextBox
    Public WithEvents passtxt As System.Windows.Forms.TextBox
End Class
