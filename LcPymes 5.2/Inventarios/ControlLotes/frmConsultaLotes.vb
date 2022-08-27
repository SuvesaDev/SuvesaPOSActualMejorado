Imports System.Data
Public Class frmConsultaLotes
    Private CodigoLoteActual As Long = 0

    Private Sub CargarLote(_text As String)
        Dim dt As New DataTable
        Dim dtRelacionados As New DataTable

        Dim codigos() = _text.Split("_")
        If codigos.Count > 1 Then
            _text = codigos(1)
        End If

        cFunciones.Llenar_Tabla_Generico("select l.Codigo, l.Barras, i.Descripcion + ' (' + CAST(i.PresentaCant as nvarchar) + ' ' + p.Presentaciones + ' )' as Descripcion, l.Lote, l.Vence, l.Actual from ControlLotes l inner join Inventario i on i.codigo = l.codigo inner join Presentaciones p on i.CodPresentacion = p.CodPres where l.Actual > 0 and l.Barras = '" & _text & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.CodigoLoteActual = dt.Rows(0).Item("Codigo")
            Me.txtBarras.Text = dt.Rows(0).Item("Barras")
            Me.txtDescripcion.Text = dt.Rows(0).Item("Descripcion")
            Me.txtLote.Text = dt.Rows(0).Item("Lote")
            Me.txtFechaVence.Text = CDate(dt.Rows(0).Item("Vence")).ToShortDateString
            Me.txtExistenciaLote.Text = dt.Rows(0).Item("Actual")
            cFunciones.Llenar_Tabla_Generico("select Barras, Lote, Vence, Actual from ControlLotes where Codigo = " & Me.CodigoLoteActual & " and Actual > 0 and Barras <> '" & _text & "' order by vence", dtRelacionados, CadenaConexionSeePOS)
            Me.viewLotesRelacionados.DataSource = dtRelacionados
        Else
            MsgBox("No se encontro ningun lote relacionado a este codigo de barras.", MsgBoxStyle.Information, Text)
            Me.CodigoLoteActual = 0
            Me.txtBarras.Text = ""
            Me.txtDescripcion.Text = ""
            Me.txtLote.Text = ""
            Me.txtFechaVence.Text = ""
            Me.txtExistenciaLote.Text = ""
            Me.viewLotesRelacionados.DataSource = Nothing
        End If

    End Sub

    Private Sub txtBarras_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarras.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.CargarLote(Me.txtBarras.Text)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.CodigoLoteActual = 0
        Me.txtBarras.Text = ""
        Me.txtDescripcion.Text = ""
        Me.txtLote.Text = ""
        Me.txtFechaVence.Text = ""
        Me.txtExistenciaLote.Text = ""
        Me.viewLotesRelacionados.DataSource = Nothing
        Me.txtBarras.Focus()
    End Sub

    Private Sub frmConsultaLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtBarras.Focus()
    End Sub
End Class