Imports System.Data
Public Class frmAreasme
    Private IdArea As Integer = 0
    Private IndexEncargado As Integer = 0
    Private IndexArticulo As Integer = 0

    Private Sub Limpiar()
        Me.IdArea = 0
        pEncabezado.Enabled = False
        pDetalle.Enabled = False
        Me.viewArticulosArea.Rows.Clear()
        Me.viewEncargados.Rows.Clear()
        Me.IndexArticulo = 0
        Me.IndexEncargado = 0
        Me.txtCodigo.Text = ""
        Me.txtDescripcion.Text = ""
        Me.txtObservaciones.Text = ""
        Me.Codigo = ""
        Me.txtDescripcionProducto.Text = ""
        Me.CodArticulo = ""
        Me.Barras = ""
        Me.Descripcion = ""
        Me.Existencia = ""
    End Sub

    Private Sub AgregarEncargado(_Cedula As String, _Nombre As String)
        Me.viewEncargados.Rows.Add()
        Me.viewEncargados.Item("cCedula", Me.IndexEncargado).Value = _Cedula
        Me.viewEncargados.Item("cNombre", Me.IndexEncargado).Value = _Nombre
        Me.IndexEncargado += 1
    End Sub

    Private Codigo, CodArticulo, Barras, Descripcion, Existencia As String

    Private Sub BuscarF1()
        Dim Codigo As String = ""
        Dim BuscarArt As New FrmBuscarArticulo2
        BuscarArt.StartPosition = FormStartPosition.CenterParent
        BuscarArt.Codigo = ""
        BuscarArt.Cod_Articulo = True
        BuscarArt.ShowDialog()
        If BuscarArt.Cancelado Then
            Exit Sub
        End If
        Codigo = BuscarArt.Codigo
        Me.txtCodigo.Text = Codigo
        Me.CargarArticulo(Codigo)
    End Sub

    Private Sub CargarArticulo(_CodArticulo As String)
        Dim dt As New DataTable
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        db.AddParametro("@Codigo", _CodArticulo)
        dt = db.Ejecutar("select Codigo, Cod_Articulo, Barras, Costo, Descripcion + ' ( ' + CAST(PresentaCant AS varchar) + ' ' + Presentaciones + ') ' As Descripcion, Existencia, Consignacion from Inventario inner JOIN dbo.Presentaciones ON dbo.Inventario.CodPresentacion = dbo.Presentaciones.CodPres where Inhabilitado = 0 and (Cod_Articulo = @Codigo or Barras = @Codigo or Barras2 = @Codigo)", CommandType.Text)
        If dt.Rows.Count > 0 Then
            Me.Codigo = dt.Rows(0).Item("Codigo")
            Me.txtDescripcionProducto.Text = dt.Rows(0).Item("Descripcion")
            Me.CodArticulo = dt.Rows(0).Item("Cod_Articulo")
            Me.Barras = dt.Rows(0).Item("Barras")
            Me.Descripcion = dt.Rows(0).Item("Descripcion")
            Me.Existencia = dt.Rows(0).Item("Existencia")
        Else
            Me.Codigo = ""
            Me.txtDescripcionProducto.Text = ""
            Me.CodArticulo = ""
            Me.Barras = ""
            Me.Descripcion = ""
            Me.Existencia = ""
        End If
    End Sub

    Private Sub AgregarArticulo(_Codigo As String, _CodArticulo As String, _Barras As String, _Descripcion As String, _Existencia As Decimal)
        If _Descripcion <> "" Then
            Me.viewArticulosArea.Rows.Add()
            Me.viewArticulosArea.Item("cCodigo", Me.IndexArticulo).Value = _Codigo
            Me.viewArticulosArea.Item("cCodArticulo", Me.IndexArticulo).Value = _CodArticulo
            Me.viewArticulosArea.Item("cBarras", Me.IndexArticulo).Value = _Barras
            Me.viewArticulosArea.Item("cDescripcion", Me.IndexArticulo).Value = _Descripcion
            Me.viewArticulosArea.Item("cExistencia", Me.IndexArticulo).Value = Math.Round(CDec(_Existencia), 2)
            Me.IndexArticulo += 1
            Me.txtCodigo.Text = ""
            Me.Codigo = ""
            Me.txtDescripcionProducto.Text = ""
            Me.CodArticulo = ""
            Me.Barras = ""
            Me.Descripcion = ""
            Me.Existencia = ""
        End If
    End Sub

    Private Sub CargarUsuarios()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select Cedula, Nombre from Usuarios", dt, CadenaConexionSeePOS)
        Me.cboEncargado.DataSource = dt
        Me.cboEncargado.DisplayMember = "Nombre"
        Me.cboEncargado.ValueMember = "Cedula"
    End Sub

    Private Sub frmAreas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarUsuarios()
        Me.viewArticulosArea.Columns("cExistencia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.viewArticulosArea.Columns("cExistencia").DefaultCellStyle.Format = "N2"
    End Sub

    Private Sub btnAgregarEncargado_Click(sender As Object, e As EventArgs) Handles btnAgregarEncargado.Click
        Me.AgregarEncargado(Me.cboEncargado.SelectedValue, Me.cboEncargado.Text)
    End Sub

    Private Sub viewEncargados_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles viewEncargados.UserDeletedRow
        Me.IndexEncargado -= 1
    End Sub


    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.CargarArticulo(Me.txtCodigo.Text)
        End If
        If e.KeyCode = Keys.F1 Then
            Me.BuscarF1()
        End If
    End Sub

    Private Sub btnAgregarArticulo_Click(sender As Object, e As EventArgs) Handles btnAgregarArticulo.Click
        If Me.Descripcion <> "" Then
            Me.AgregarArticulo(Me.Codigo, Me.CodArticulo, Me.Barras, Me.Descripcion, Me.Existencia)
        End If
    End Sub

    Private Sub viewArticulosArea_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles viewArticulosArea.UserDeletedRow
        Me.IndexArticulo -= 1
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Limpiar()
        pEncabezado.Enabled = True
        pDetalle.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If pEncabezado.Enabled = True Then
            If Me.txtDescripcion.Text <> "" Then
                Dim cls As New Area
                cls.IdArea = Me.IdArea
                cls.Descripcion = Me.txtDescripcion.Text
                cls.Observaciones = Me.txtObservaciones.Text
                If cls.Guardar(Me.viewEncargados, viewArticulosArea) = True Then
                    Me.Limpiar()
                    MsgBox("Datos guardados correctamente", MsgBoxStyle.Information, Text)
                    Me.Imprimir(cls.IdArea)
                End If
            End If            
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim cls As New Area
        Dim Fx As New cFunciones
        Dim valor As String = ""
        valor = Fx.BuscarDatos("Select IdArea, Descripcion from Area", "Descripcion", "Buscar Area...")
        If valor <> "" Then
            If IsNumeric(valor) = True Then
                If CDec(valor) > 0 Then
                    Me.Limpiar()
                    Dim dtArea As New DataTable
                    Dim dtAreaEncargado As New DataTable
                    Dim dtAreaArticulo As New DataTable
                    dtArea = cls.ObtenerArea(valor)
                    Me.IdArea = valor
                    Me.txtDescripcion.Text = dtArea.Rows(0).Item("Descripcion")
                    Me.txtObservaciones.Text = dtArea.Rows(0).Item("Observaciones")
                    dtAreaEncargado = cls.ObtenerAreaEncargado(valor)
                    For Each r As DataRow In dtAreaEncargado.Rows
                        Me.AgregarEncargado(r.Item("Cedula"), r.Item("Nombre"))
                    Next
                    dtAreaArticulo = cls.ObtenerAreaArticulo(valor)
                    For Each r As DataRow In dtAreaArticulo.Rows
                        Me.AgregarArticulo(r.Item("Codigo"), r.Item("Cod_Articulo"), r.Item("Barras"), r.Item("Descripcion"), r.Item("Existencia"))
                    Next
                    Me.pEncabezado.Enabled = True
                    Me.pDetalle.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        If Me.IdArea > 0 Then
            If MsgBox("Desea eliminar el area seleccionada.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.Yes Then
                Dim cls As New Area
                If cls.EliminarArea(Me.IdArea) = True Then
                    Me.Limpiar()
                    MsgBox("Area eliminada correctamente", MsgBoxStyle.Information, Text)
                End If
            End If
        End If
    End Sub

    Private Sub Imprimir(_IdArea As Integer)
        Dim ReporteDocumento As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ReporteDocumento.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
        ReporteDocumento = New rptArea
        ReporteDocumento.Refresh()
        ReporteDocumento.SetParameterValue(0, _IdArea)
        CrystalReportsConexion.LoadShow(ReporteDocumento, MdiParent, CadenaConexionSeePOS)
    End Sub
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If Me.IdArea > 0 Then
            Me.Imprimir(Me.IdArea)
        End If
    End Sub
End Class