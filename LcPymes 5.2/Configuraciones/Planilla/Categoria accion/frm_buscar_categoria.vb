Imports System.Data


Public Class frm_buscar_categoria
    Public codigo As Integer
    Dim dt As DataTable
    Private Sub frm_buscar_categoria_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Dim func As New Fcategoria_accion
            Dim dts As New DataTable

            dt = func.mostrar
            dtaListado.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function buscar_categoria()
        Dim id As String
        id = Me.dtaListado.SelectedCells.Item(0).Value
        codigo = id
        Return id
    End Function

    Private Sub txtbuscar_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtbuscar.TextChanged
        Try

            cFunciones.Llenar_Tabla_Generico("select * from categoria_accion where categoria like'" & txtbuscar.Text & "%" & "'", dt, CadenaConexionSeePOS)
            dtaListado.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub dtaListado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtaListado.CellDoubleClick
        buscar_categoria()
        Close()
    End Sub
End Class