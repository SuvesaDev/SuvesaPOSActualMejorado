Public Class frmArqueoDepositoAnulados

    Private Sub MostrarDatos()
        Try
            Dim dt As New System.Data.DataTable
            Dim strSQL As String = "Select * from viewArqueoDepositoAnulado "
            Dim strWhere As String = "Where dbo.dateonly(FechaAnulacion) >= dbo.dateonly('" & Me.dtpDesde.Value & "') and dbo.dateonly(FechaAnulacion) <= dbo.dateonly('" & Me.dtpHasta.Value & "') "


            cFunciones.Llenar_Tabla_Generico(strSQL & strWhere, dt, CadenaConexionSeePOS)
            Me.viewDatos.DataSource = dt
            Me.viewDatos.Columns("Id").Visible = False
            Me.viewDatos.Columns("Monto").DefaultCellStyle.Format = "N2"
            Me.viewDatos.Columns("Monto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmArqueoDepositoAnulados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.MostrarDatos()
    End Sub
End Class