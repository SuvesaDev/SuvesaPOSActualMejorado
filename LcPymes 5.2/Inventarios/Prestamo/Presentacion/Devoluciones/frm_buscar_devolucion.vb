Imports System.Windows.Forms
Imports System.Data

Namespace Prestamos
    Public Class frm_buscar_devolucion
        Public codigo As String
        Dim dt As New DataTable
        Private Sub frm_buscar_devolucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Try
                Dim func As New fdevolucion
                dt = func.mostrar
                datalistado.DataSource = dt
                txtbuscar.Focus()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Public Function buscar_producto()
            Dim id As String
            id = Me.datalistado.SelectedCells.Item(0).Value
            codigo = id
            Return id
        End Function

        Private Sub dtaListado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentDoubleClick
            buscar_producto()
            Close()
        End Sub

        Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
            Try
                If rb_descripcion.Checked = True Then
                    cFunciones.Llenar_Tabla_Generico(" Select ID_prestamo,codigo,descripcion,cantidad,fecha from devolucion_prestamo where descripcion like'" & txtbuscar.Text & "%" & "'", dt, CadenaConexionSeePOS)
                End If
                If rb_codigo.Checked = True Then
                    cFunciones.Llenar_Tabla_Generico(" Select ID_prestamo,codigo,descripcion,cantidad,fecha from devolucion_prestamo where id_prestamo like'" & txtbuscar.Text & "%" & "'", dt, CadenaConexionSeePOS)
                End If
                datalistado.DataSource = dt

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub rb_codigo_CheckedChanged(sender As Object, e As EventArgs) Handles rb_codigo.CheckedChanged
            txtbuscar.Focus()
        End Sub

        Private Sub rb_descripcion_CheckedChanged(sender As Object, e As EventArgs) Handles rb_descripcion.CheckedChanged
            txtbuscar.Focus()
        End Sub
    End Class
End Namespace
