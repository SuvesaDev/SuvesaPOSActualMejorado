Public Class frmBitacoraVuelto
    Public caja As Integer = 1

    Private Sub CargarDatos()
        Dim dt As New System.Data.DataTable
        cFunciones.Llenar_Tabla_Generico("select v.id, v.napertura, a.nombre as cajera, v.caja, v.fecha, v.documento,v.totalcobro, v.totalpagado, v.vuelto from bitacoravuelto v inner join aperturacaja a on v.napertura = a.NApertura where dbo.DateOnly(v.fecha) >= dbo.dateonly('" & Me.dtpDesde.Value & "') and dbo.DateOnly(v.fecha) <= dbo.dateonly('" & Me.dtpHasta.Value & "') and v.caja = " & Me.caja & "  Order by v.fecha desc", dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt
        Me.viewDatos.Columns("id").Visible = False
        Me.viewDatos.Columns("cajera").Visible = False
        Me.viewDatos.Columns("fecha").Width = 150
        Me.viewDatos.Columns("totalcobro").DefaultCellStyle.Format = "N2"
        Me.viewDatos.Columns("totalcobro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.viewDatos.Columns("totalpagado").DefaultCellStyle.Format = "N2"
        Me.viewDatos.Columns("totalpagado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.viewDatos.Columns("vuelto").DefaultCellStyle.Format = "N2"
        Me.viewDatos.Columns("vuelto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub frmBitacoraVuelto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarDatos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CargarDatos()
    End Sub

End Class