Imports System.Data
Imports System.Data.SqlClient
Public Class frm_buscar_accion

    Public codigo As Integer
    Dim dt As DataTable

    Public Function buscar()
        Dim id As String
        id = Me.dtaListado.SelectedCells.Item(0).Value
        codigo = id
        Return id
    End Function

    Private Sub txtbuscar_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtbuscar.TextChanged
        Try
            cFunciones.Llenar_Tabla_Generico("select * from accion where nombre like'" & txtbuscar.Text & "%" & "'", dt, CadenaConexionSeePOS)
            dtaListado.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frm_buscar_accion_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Dim func As New Faccion
            Dim dts As New DataTable

            dt = func.mostrar
            dtaListado.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub dtaListado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtaListado.CellDoubleClick
        buscar()
        Close()
    End Sub
End Class