Public Class characters


    Dim lu As New Datos.characters
    Dim lus As New Datos.CharactersB
    Dim luse As New Datos.CharactersL

    Public Function listadoC() As DataTable
        Dim dt As New DataTable
        dt = lu.consulta
        Return dt
    End Function
    Public Function Total_onlineC() As Integer
        Return listadoC.Rows.Count
    End Function
    Public Function listadoB() As DataTable
        Dim dt As New DataTable
        dt = lus.consulta
        Return dt
    End Function
    Public Function Total_onlineB() As Integer
        Return listadoB.Rows.Count
    End Function
    Public Function listadoL() As DataTable
        Dim dt As New DataTable
        dt = luse.consulta
        Return dt
    End Function
    Public Function Total_onlineL() As Integer
        Return listadoL.Rows.Count
    End Function


    Public Function listar(id As Integer) As DataTable
        Return luse.promocion(id)
    End Function

    Public Function l(id As Integer) As Boolean
        If listar(id).Rows.Count < 2 Then
            Return True
        Else
            Return False
        End If
    End Function


    'Public Function Buscarpromo(u As String) As Entidades.account
    '    Try
    '        Dim dr As DataRow
    '        Dim filtro As String
    '        Dim usu As New Entidades.account
    '        filtro = String.Format("[account]='{0}'", u)
    '        dr = listar().Select(filtro)(0)
    '        usu.account = dr.Item("account")
    '        usu.name = dr.Item("name")
    '        Return usu
    '    Catch ex As Exception
    '        Return Nothing
    '    End Try
    'End Function


End Class
