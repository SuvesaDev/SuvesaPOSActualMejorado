Imports System.Data
Public Class frmAnalisisCxC
    Private Identificacion As String = "0"

    Private Sub BuscarClienteF1()
        Dim cFunciones As New cFunciones
        Me.Identificacion = cFunciones.BuscarDatosClientes("select identificacion as identificacion,nombre as Nombre from Clientes", "Nombre")
        Me.BuscarEnter(Me.Identificacion)        
    End Sub

    Private Sub BuscarEnter(_Identificador As String, Optional ByVal _Cedula As Boolean = False)
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        Dim dt As New System.Data.DataTable
        If Me.Identificacion <> "" Then
            If _Cedula = False Then
                dt = db.Ejecutar("Select * from Clientes where identificacion = " & Me.Identificacion, CommandType.Text)
            Else
                dt = db.Ejecutar("Select * from Clientes where cedula = " & Me.Identificacion, CommandType.Text)
            End If

            Me.Identificacion = dt.Rows(0).Item("identificacion")
            Me.txtCodigo.Text = _Identificador
            Me.lblCliente.Text = dt.Rows(0).Item("Nombre")
        Else
            Me.Identificacion = "0"
            Me.lblCliente.Text = ""
        End If
    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Me.BuscarClienteF1()
        End If

        If e.KeyCode = Keys.Enter Then
            Me.BuscarEnter(Me.txtCodigo.Text)
        End If
    End Sub

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        If Me.Identificacion <> "0" Then
            Dim rpt As New rptAnalisisCredito
            rpt.SetParameterValue(0, Me.Identificacion)
            rpt.SetParameterValue(1, Me.FechaFinal.Value)
            rpt.SetParameterValue(2, Me.lblCliente.Text)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
            VisorReporte.Show()
        End If
    End Sub
End Class