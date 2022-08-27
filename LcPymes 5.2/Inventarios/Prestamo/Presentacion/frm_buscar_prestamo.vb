Imports System.Data
Imports System.Windows.Forms

Namespace Prestamos
    Public Class frm_buscar_prestamo
        Public codigo As String
        Dim dt As New DataTable
        Public Function buscar_producto()
            Dim id As String
            id = Me.datalistado.SelectedCells.Item(0).Value
            codigo = id
            Return id
        End Function

        Private Sub Buscar()
            Try
                Dim BuscarporArticulo As String = "select p.id, p.boleta, dp.descripcion,p.fecha,p.nombre_destino,p.nombre_destinatario from prestamo p inner join detalle_prestamo dp on p.id = dp.ID_prestamo where p.nombre_destino like'%" & txtbuscar.Text & "%' or p.nombre_destinatario like'%" & txtbuscar.Text & "%' or p.boleta like'%" & txtbuscar.Text & "%' or dp.Descripcion like'%" & txtbuscar.Text & "%' Order By fecha Desc"
                Dim BuscarNormal As String = "select id,boleta,fecha,nombre_destino,nombre_destinatario from prestamo where nombre_destino like'%" & txtbuscar.Text & "%' or nombre_destinatario like'%" & txtbuscar.Text & "%' or boleta like'%" & txtbuscar.Text & "%' Order By fecha Desc"

                cFunciones.Llenar_Tabla_Generico(BuscarporArticulo, dt, CadenaConexionSeePOS)
                datalistado.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub txtbuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbuscar.KeyDown
            If e.KeyCode = Keys.Enter And Me.txtbuscar.Text <> "" And Me.datalistado.RowCount > 0 Then
                Me.datalistado.Focus()
            End If
        End Sub

        Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
            Me.Buscar()
        End Sub

        Private Sub frm_buscar_prestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.Buscar()
            Me.txtbuscar.Focus()
        End Sub

        Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
            Try
                buscar_producto()
                Close()
            Catch ex As Exception
            End Try
        End Sub

        Private Sub bt_aceptar_Click(sender As Object, e As EventArgs) Handles bt_aceptar.Click
            If Me.datalistado.RowCount > 0 Then
                Try
                    buscar_producto()
                    Close()
                Catch ex As Exception
                End Try
            End If
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Close()
        End Sub

    End Class
End Namespace
