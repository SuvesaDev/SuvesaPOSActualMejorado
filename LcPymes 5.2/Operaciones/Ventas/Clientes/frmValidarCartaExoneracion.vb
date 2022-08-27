Imports System.Data
Public Class frmValidarCartaExoneracion

    Public Property NumeroCarta As String = ""
    Private Property Correcto As Boolean = False
    Private Property IdentificacionCliente As String = ""

    Public Sub CargarTiposExoneracion()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select Codigo, TipoExoneracion from TipoExoneracion where TipoExoneracion <> ''", dt, CadenaConexionSeePOS)
        Me.cboTipDocumento.DataSource = dt
        Me.cboTipDocumento.DisplayMember = "TipoExoneracion"
        Me.cboTipDocumento.ValueMember = "Codigo"
    End Sub

    Private Sub CargarDatos()
        Try
            Me.Correcto = False
            If Me.NumeroCarta <> "" Then
                Dim datos As api.Hacienda.Exoneracion = api.Hacienda.ConsultaExoneracion(Me.NumeroCarta)

                Me.txtNumCarta.Text = datos.numeroDocumento
                Me.txtIdentificacion.Text = datos.identificacion
                Me.txtPorcentaje.Text = datos.porcentajeExoneracion
                Me.dtpFecha.Value = datos.fechaEmision
                Me.cboTipDocumento.SelectedValue = datos.tipoDocumento.codigo
                Me.Correcto = True

            Else
                Me.txtNumCarta.ReadOnly = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If Me.Correcto = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub frmValidarCartaExoneracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarTiposExoneracion()
        Me.CargarDatos()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.NumeroCarta = Me.txtNumCarta.Text
        Me.CargarDatos()
    End Sub

End Class