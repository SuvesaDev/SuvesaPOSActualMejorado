Imports System.Data
Imports System.Data.SqlClient

Public Class frm_buscar_empleado
    Public codigo As Integer
    Dim dt As DataTable
    Private Sub frm_buscar_empleado_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Dim func As New Fempleado
            Dim dts As New DataTable

            dt = func.mostrar
            dtaListado.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function buscar_empleado()
        Dim id As String
        id = Me.dtaListado.SelectedCells.Item(0).Value
        codigo = id
        Return id
    End Function

    Private Sub txtbuscar_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtbuscar.TextChanged
        Try
            If rb_cedula.Checked = True Then
                cFunciones.Llenar_Tabla_Generico("select * from empleado where cedula like'" & txtbuscar.Text & "%" & "'", dt, CadenaConexionSeePOS)
                dtaListado.DataSource = dt
            ElseIf rb_nombre.Checked = True Then
                cFunciones.Llenar_Tabla_Generico("select * from empleado where nombre like'" & txtbuscar.Text & "%" & "'", dt, CadenaConexionSeePOS)
                dtaListado.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dtaListado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtaListado.CellDoubleClick
        buscar_empleado()
        Close()
    End Sub
End Class