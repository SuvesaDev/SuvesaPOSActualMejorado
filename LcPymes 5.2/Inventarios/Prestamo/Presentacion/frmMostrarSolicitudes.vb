Imports System.Data
Public Class frmMostrarSolicitudes

    Public Property TipodeOperacion As TipoOperacion = TipoOperacion.ConsultarPendientes

    Private Function GetEmpresa() As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select Identificacion from seguridad.dbo.emisor", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("Identificacion")
        Else
            Return "0"
        End If
    End Function

    Private Sub CargarSolicitudes()
        Dim Logica As New OBSoluciones.LogisticaPrestamo
        Dim dt As New DataTable
        If Me.TipodeOperacion = TipoOperacion.ConsultarPendientes Then
            dt = Logica.MostrarSolicitudesPendientes(Me.GetEmpresa)
        Else
            dt = Logica.MostrarPrestamosxRecibir(Me.GetEmpresa)
        End If
        Me.DataGridView1.DataSource = dt
    End Sub

    Private Sub AbrirSolicitud(_Id As Long)
        Dim frm As New Prestamos.frm_prestamos
        frm.IdSPrestamo = _Id
        frm.ShowDialog()
        Me.CargarSolicitudes()
    End Sub

    Private Sub frmMostrarSolicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarSolicitudes()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.CargarSolicitudes()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If Me.DataGridView1.RowCount > 0 Then
            Me.AbrirSolicitud(Me.DataGridView1.Item("ID", Me.DataGridView1.CurrentRow.Index).Value)
        End If
    End Sub

End Class


Public Enum TipoOperacion
    ConsultarPendientes
    RecibirPrestamo
End Enum