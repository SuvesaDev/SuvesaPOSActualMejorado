Imports System.Data
Imports System.Data.SqlClient

Public Class frmPrepagoCxP
    Dim Tabla As DataTable

    Private Sub MostrarReporteBonificaciones()

    End Sub

    Private Sub MensajeBonificacion(ByVal codigo As String)
        Try
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select Bonificacion, MensajeBonificacion from Proveedores  where CodigoProv = " & codigo, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item("Bonificacion") = True Then
                    Dim msg As String = dt.Rows(0).Item("MensajeBonificacion")
                    MsgBox("favor revisar que el proveedor compla con las siguientes bonificaciones o descuentos: " & vbCrLf _
                           & "" & vbCrLf _
                           & msg, MsgBoxStyle.Information, Me.Text)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarInformacionProveedor(ByVal codigo As String)
        Dim cConexion As New Conexion
        Dim funciones As New cFunciones
        Dim rs As SqlDataReader
        Dim i As Integer
        Dim fila As DataRow
        Dim factura As Long
        Dim conex As New SqlConnection(CadenaConexionSeePOS)

        If codigo <> Nothing Then
            If conex.State = ConnectionState.Open Then conex.Close()
            conex.Open()
            rs = cConexion.GetRecorset(conex, "SELECT CodigoProv, Nombre from proveedores where codigoProv  ='" & codigo & "'")
            Try
                If rs.Read Then
                    txtCodigo.Text = rs("CodigoProv")
                    txtNombre.Text = rs("Nombre")

                    Tabla = funciones.BuscarFacturas_Proveedor2(codigo, conex.ConnectionString)

                    Dim index As Integer = 0
                    Me.viewDatos.Rows.Clear()
                    For Each r As DataRow In Tabla.Rows
                        Me.viewDatos.Rows.Add()
                        Me.viewDatos.Item("cIdCompra", index).Value = r.Item("Id_Compra")
                        Me.viewDatos.Item("cPagar", index).Value = r.Item("Prepagada")
                        Me.viewDatos.Item("cFactura", index).Value = r.Item("Factura")
                        Me.viewDatos.Item("cFecha", index).Value = r.Item("Fecha")
                        Me.viewDatos.Item("cFechaAbono", index).Value = r.Item("FechaPreabono")
                        Me.viewDatos.Item("cDocumento", index).Value = r.Item("DocumentoPreabono")

                        If CDec(r.Item("PreAbono")) > 0 Then
                            Me.viewDatos.Item("cAbono", index).Value = r.Item("PreAbono")
                        Else
                            Me.viewDatos.Item("cAbono", index).Value = r.Item("Saldo")
                        End If

                        Me.viewDatos.Item("cTotal", index).Value = r.Item("Saldo")
                        index += 1
                    Next

                    conex.Close()
                    If Tabla.Rows.Count = 0 Then
                        MessageBox.Show("El Proveedor no tiene facturas pendientes...", "Atención...", MessageBoxButtons.OK)
                        txtCodigo.Focus()
                        rs.Close()
                        Exit Sub
                    Else

                        
                    End If

                    Me.MensajeBonificacion(codigo)
                Else
                    MsgBox("La identificación del Proveedor no se encuentra", MsgBoxStyle.Information, "Atención...")
                    txtCodigo.Focus()
                    rs.Close()
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If rs.IsClosed = False Then rs.Close()
                If conex.State <> ConnectionState.Closed Then conex.Close()                
            End Try
        End If
    End Sub

    Private Sub CalcularTotal()
        Dim Total As Decimal = 0
        For Each row As DataGridViewRow In Me.viewDatos.Rows
            If row.Cells("cPagar").Value = True Then
                Total += row.Cells("cAbono").Value
            End If
        Next
        Me.lblTotal.Text = "Total: " & Total.ToString("N2")
    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F1
                    Dim cFunciones As New cFunciones
                    Me.txtCodigo.Text = cFunciones.BuscarDatos("SELECT CodigoProv AS Identificación, Nombre AS Proveedor FROM Proveedores", "Nombre", "Busqueda de Proveedor...", CadenaConexionSeePOS)
                Case Keys.Enter
                    If Not IsNumeric(txtCodigo.Text) Then Exit Sub
                    CargarInformacionProveedor(txtCodigo.Text)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Public Sub ActualizarDatos(Fecha, Documento)
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        Dim Prepagar As String = "0"
        Dim Id_Compra As String = "0"
        Dim Abono As Decimal = 0
        For Each i As DataGridViewRow In Me.viewDatos.Rows
            If IsNumeric(i.Cells("cAbono").Value) Then
                Prepagar = IIf(i.Cells("cPagar").Value = True, 1, 0)
                Id_Compra = i.Cells("cIdCompra").Value
                Abono = CDec(i.Cells("cAbono").Value)
                If Prepagar = False Then
                    i.Cells("cFechaAbono").Value = ""
                    i.Cells("cDocumento").Value = ""
                    db.Ejecutar("Update Compras set FechaPreabono = null, DocumentoPreabono = '', Preabono = 0, Prepagada = 0 Where Id_Compra = " & Id_Compra, CommandType.Text)
                Else
                    If i.Cells("cDocumento").Value = "" Then
                        i.Cells("cFechaAbono").Value = Fecha
                        i.Cells("cDocumento").Value = Documento
                        db.Ejecutar("Update Compras set FechaPreabono = '" & Fecha & "', DocumentoPreabono= '" & Documento & "', PreAbono = " & Abono & ", Prepagada = " & Prepagar & " Where Id_Compra = " & Id_Compra, CommandType.Text)
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub btnApliar_Click(sender As Object, e As EventArgs) Handles btnApliar.Click
        If MsgBox("Desea apliar los cambios", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Accion.") = MsgBoxResult.Yes Then
            Dim Fecha As DateTime = Date.Now
            Dim Documento As String = ""

            Dim CountAplicar As Decimal = (From x As DataGridViewRow In Me.viewDatos.Rows
                                      Where x.Cells("cPagar").Value = True
                                      Select x).Count

            If CountAplicar > 0 Then
                Dim frm As New frmAgregarFechaDocumento
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.ActualizarDatos(frm.dtpFecha.Value, frm.txtNumeroDocumento.Text)
                End If
            Else
                Me.ActualizarDatos(Fecha, Documento)
            End If

            
        End If
    End Sub

    Private Sub viewDatos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellEndEdit
        CalcularTotal()
    End Sub

    Private Sub viewDatos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellValueChanged
        CalcularTotal()
    End Sub

    Private Sub btnCalcularMonto_Click(sender As Object, e As EventArgs) Handles btnCalcularMonto.Click
        Me.CalcularTotal()
    End Sub

    Private Sub frmPrepagoCxP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBonificacion_Click(sender As Object, e As EventArgs) Handles btnBonificacion.Click
        If Me.txtNombre.Text <> "" Then
            Dim ReporteDocumento As New rptBonificacionCompras
            ReporteDocumento.Refresh()
            ReporteDocumento.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
            ReporteDocumento.SetParameterValue(0, CDbl(Me.txtCodigo.Text))
            CrystalReportsConexion.LoadShow(ReporteDocumento, MdiParent)
        End If
    End Sub
End Class