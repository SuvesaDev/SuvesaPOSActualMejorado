Imports System.Data
Public Class frmRegistrarPedido
    Public CodigoProv As String = ""
    Public NombreProv As String = ""

    Private Sub Buscar_Proveedor()
        Dim Fx As New cFunciones
        Dim valor As String
        valor = Fx.BuscarDatos("Select CodigoProv,Nombre from Proveedores", "Nombre", "Buscar Proveedor...")
        If valor = "" Then
            Me.lblProveedor.Text = ""
            Me.CodigoProv = ""
            Me.NombreProv = ""
        Else
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select CodigoProv,Nombre from Proveedores Where CodigoProv = " & valor, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Me.lblProveedor.Text = dt.Rows(0).Item("Nombre")
                Me.CodigoProv = valor
                Me.NombreProv = dt.Rows(0).Item("Nombre")
            Else
                Me.lblProveedor.Text = ""
                Me.CodigoProv = ""
                Me.NombreProv = ""
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.CodigoProv <> "" And Me.txtCantidad.Value > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If        
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btnBuscarProveedor.Click
        Me.Buscar_Proveedor()
    End Sub

End Class