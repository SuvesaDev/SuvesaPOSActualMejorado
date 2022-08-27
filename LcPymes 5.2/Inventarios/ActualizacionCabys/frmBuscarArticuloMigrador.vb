Imports System.Data
Public Class frmBuscarArticuloMigrador

    Private Sub Cargar(texto As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT cp.Proveedor, cp.Descripcion, cp.Cabys, c.description as DescripcionCabys FROM cabysproveedores cp inner join seguridad.dbo.cabys c on cp.cabys = c.code WHERE cp.descripcion LIKE '%" & texto & "%';", dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        Me.Cargar(Me.txtDescripcion.Text)
    End Sub

    Private Sub frmBuscarArticuloMigrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cargar("algo raro para que salga en blanco")
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class