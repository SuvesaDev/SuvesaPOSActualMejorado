Imports System.Data
Public Class frmPrepagos


    Private Sub CargarPrepagosActivos()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from viewSaldoPrepago where Nombre like '%" & Me.txtCliente.Text & "%' And saldo > 0 order by nombre", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.viewDatos.DataSource = dt
            Me.viewDatos.Columns("Identificacion").Visible = False
            Me.viewDatos.Columns("Saldo").DefaultCellStyle.Format = "N2"
            Me.viewDatos.Columns("Saldo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
    End Sub

    Private Sub frmPrepagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarPrepagosActivos()
    End Sub

    Private Sub btnSincronizacion_Click(sender As Object, e As EventArgs)
        Me.CargarPrepagosActivos()
    End Sub

    Private Sub txtCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.CargarPrepagosActivos()
        End If
    End Sub
End Class