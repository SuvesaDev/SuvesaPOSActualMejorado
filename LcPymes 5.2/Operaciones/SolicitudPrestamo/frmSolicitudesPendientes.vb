Imports System.Data
Public Class frmSolicitudesPendientes

    Private CeduaEmisor As String = ""
    Private Sub CargarCedulaEmisor()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Identificacion from Seguridad.dbo.Emisor", dt, CadenaConexionSeguridad)
        Me.CeduaEmisor = dt.Rows(0).Item("Identificacion")
    End Sub

    Private Sub BuscarSolicitudesNuevas()
        Dim dt As New DataTable
        OBSoluciones.db.AddParametro("pCedula", Me.CeduaEmisor)
        dt = OBSoluciones.db.Ejecutar("Obtener_Pedidos_Pendientes")
        Me.viewDatos.DataSource = dt
        Me.viewDatos.Columns("IdPedido").Visible = False
        Me.viewDatos.Columns("CedulaEmisor").Visible = False
        Me.viewDatos.Columns("CedulaReceptor").Visible = False
        Me.viewDatos.Columns("UsuarioReceptor").Visible = False
    End Sub

    Private Sub frmSolicitudesPendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarCedulaEmisor()
        Me.BuscarSolicitudesNuevas()
    End Sub

End Class