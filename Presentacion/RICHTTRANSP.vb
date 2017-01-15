Imports System.Windows.Forms


'Public Class RICHTTRANSP
'    Inherits RichTextBox
'    <DllImport("kernel32.dll", CharSet:=CharSet.Auto)> _
'    Private Shared Function LoadLibrary(ByVal lpFileName As String) As IntPtr
'    End Function
'    Protected Overrides ReadOnly Property CreateParams() As CreateParams
'        Get
'            Dim params As CreateParams = MyBase.CreateParams
'            If LoadLibrary("msftedit.dll") <> IntPtr.Zero Then
'                params.ExStyle = params.ExStyle Or &H20
'                params.ClassName = "RICHEDIT50W"
'            End If
'            Return params
'        End Get
'    End Property
'End Class

Class TransparentControl
    Inherits Control

    Public Sub New()
        MyBase.New()
        MyBase.SetStyle(ControlStyles.UserPaint, True)
        MyBase.SetStyle(ControlStyles.DoubleBuffer, True)
        MyBase.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
    End Sub
End Class
Class TransparentRichTextBox
    Inherits RichTextBox



    Public Sub New()
        MyBase.New()
        MyBase.ScrollBars = RichTextBoxScrollBars.None
    End Sub

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = (cp.ExStyle Or 32)
            Return cp
        End Get
    End Property




    Protected Overrides Sub OnPaintBackground(ByVal e As PaintEventArgs)

    End Sub
End Class




