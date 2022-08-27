Imports System.Data
Imports System.Windows.Forms

Namespace Prestamos
    Public Class frm_buscar_producto
        Public codigo As String
        Public descrip As String
        Public exist As Double
        Public prestamos As Double
        Public precios As Double
        Dim dt As New DataTable

        Private Sub frm_buscar_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Try
                Dim func As New fprestamo

                dt = func.mostrar_productos
                datalistado.DataSource = dt

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Public Function buscar_producto()
            Dim id As String
            id = Me.datalistado.SelectedCells.Item(7).Value
            descrip = Me.datalistado.SelectedCells.Item(1).Value
            exist = Me.datalistado.SelectedCells.Item(4).Value
            precios = Me.datalistado.SelectedCells.Item(5).Value
            prestamos = Me.datalistado.SelectedCells.Item(6).Value
            codigo = id
            Return id
        End Function

        Private Sub dtaListado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentDoubleClick
            buscar_producto()
            Close()
        End Sub

        Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
            Try
                cFunciones.Llenar_Tabla_Generico("select * from InventarioGeneral where descripcion like '%" & txtbuscar.Text & "%'", dt, CadenaConexionSeePOS)
                datalistado.DataSource = dt

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
