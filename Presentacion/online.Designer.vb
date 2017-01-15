<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class online
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(online))
        Me.Lks = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lk = New System.Windows.Forms.Label()
        Me.Cbliz = New System.Windows.Forms.Label()
        Me.CFun = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lks
        '
        Me.Lks.AutoSize = True
        Me.Lks.ForeColor = System.Drawing.Color.Red
        Me.Lks.Location = New System.Drawing.Point(12, 19)
        Me.Lks.Name = "Lks"
        Me.Lks.Size = New System.Drawing.Size(67, 13)
        Me.Lks.TabIndex = 0
        Me.Lks.Text = "Lk --> 3.3.5a"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bliz --> 4.3.4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(12, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fun --> 4.3.4"
        '
        'Lk
        '
        Me.Lk.AutoSize = True
        Me.Lk.ForeColor = System.Drawing.Color.Red
        Me.Lk.Location = New System.Drawing.Point(97, 19)
        Me.Lk.Name = "Lk"
        Me.Lk.Size = New System.Drawing.Size(0, 13)
        Me.Lk.TabIndex = 3
        '
        'Cbliz
        '
        Me.Cbliz.AutoSize = True
        Me.Cbliz.ForeColor = System.Drawing.Color.Red
        Me.Cbliz.Location = New System.Drawing.Point(98, 42)
        Me.Cbliz.Name = "Cbliz"
        Me.Cbliz.Size = New System.Drawing.Size(0, 13)
        Me.Cbliz.TabIndex = 4
        '
        'CFun
        '
        Me.CFun.AutoSize = True
        Me.CFun.ForeColor = System.Drawing.Color.Red
        Me.CFun.Location = New System.Drawing.Point(98, 63)
        Me.CFun.Name = "CFun"
        Me.CFun.Size = New System.Drawing.Size(0, 13)
        Me.CFun.TabIndex = 5
        '
        'online
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(207, 85)
        Me.Controls.Add(Me.CFun)
        Me.Controls.Add(Me.Cbliz)
        Me.Controls.Add(Me.Lk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lks)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "online"
        Me.Text = "online"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lks As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lk As System.Windows.Forms.Label
    Friend WithEvents Cbliz As System.Windows.Forms.Label
    Friend WithEvents CFun As System.Windows.Forms.Label
End Class
