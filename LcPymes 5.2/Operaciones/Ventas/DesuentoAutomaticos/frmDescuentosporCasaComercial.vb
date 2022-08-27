Imports System.Data

Public Class frmDescuentosporCasaComercial

    Private IdDescuento As String = "0"
    Private IdProveedor As String = "0"

    Private Sub txtProveedor_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtProveedor.KeyDown
        Dim dt As New DataTable


        Select Case e.KeyCode

            'Case Windows.Forms.Keys.Enter

            '    cFunciones.Llenar_Tabla_Generico("select CodigoProv, Nombre from Proveedores where CodigoProv = " & Me.txtCodigo.Text, dt, CadenaConexionSeePOS)
            '    If dt.Rows.Count > 0 Then
            '        Me.IdProveedor = dt.Rows(0).Item("CodigoProv")
            '        Me.txtProveedor.Text = dt.Rows(0).Item("Nombre")
            '    End If

            Case Windows.Forms.Keys.F1
                Dim Fx As New cFunciones
                Dim valor As String
                valor = Fx.BuscarDatos("Select CodigoProv,Nombre from Proveedores", "Nombre", "Buscar Proveedor...")
                If valor = "" Then
                    Me.IdProveedor = "0"
                    Me.txtProveedor.Text = ""
                Else
                    cFunciones.Llenar_Tabla_Generico("select CodigoProv, Nombre from Proveedores where CodigoProv = " & valor, dt, CadenaConexionSeePOS)
                    If dt.Rows.Count > 0 Then
                        Me.IdProveedor = dt.Rows(0).Item("CodigoProv")
                        Me.txtProveedor.Text = dt.Rows(0).Item("Nombre")
                    End If
                End If
        End Select
    End Sub

    Private Sub Cargar_Descuntos()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from viewDescuentos", dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt
        Me.viewDatos.Columns("IdDescuento").Visible = False
        Me.viewDatos.Columns("IdProveedor").Visible = False
        Me.viewDatos.Columns("ContactoConfirmo").Visible = False
    End Sub

    Private Sub LimpiarDescuento()
        Me.btnEliminar.Enabled = False
        Me.dtpDesde.Value = Date.Now
        Me.dtpHasta.Value = Date.Now
        Me.ckEstado.Checked = False
        Me.txtContactoConfirmo.Text = ""
        Me.txtDescuento.Text = ""
        Me.txtProveedor.Text = ""
        Me.IdProveedor = "0"
        Me.IdDescuento = "0"
    End Sub

    Private Sub Guardar_Descuento()
        If Me.IdProveedor <> "0" And Me.txtProveedor.Text <> "" Then
            If IsNumeric(Me.txtDescuento.Text) Then
                If CDec(Me.txtDescuento.Text) > 0 Then
                    If CDate(Me.dtpHasta.Value.ToShortDateString) >= CDate(Me.dtpDesde.Value.ToShortDateString) Then
                        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)

                        If Me.IdDescuento = "0" Then
                            db.Ejecutar("Insert into Descuentos(IdProveedor, Desde, Hasta, Descuento, Confirmado, ContactoConfirmo) Values(" & Me.IdProveedor & ", dbo.dateonly('" & Me.dtpDesde.Value.ToShortDateString & "'), dbo.dateonly('" & Me.dtpHasta.Value.ToShortDateString & "')," & CDec(Me.txtDescuento.Text) & ", " & IIf(Me.ckEstado.Checked = True, 1, 0) & ", '" & Me.txtContactoConfirmo.Text & "')", Data.CommandType.Text)
                        Else
                            db.Ejecutar("Update Descuentos set IdProveedor = " & Me.IdProveedor & ", Desde = dbo.dateonly('" & Me.dtpDesde.Value.ToShortDateString & "') , Hasta = dbo.dateonly('" & Me.dtpHasta.Value.ToShortDateString & "') , Descuento = " & CDec(Me.txtDescuento.Text) & ", Confirmado = " & IIf(Me.ckEstado.Checked = True, 1, 0) & ", ContactoConfirmo = '" & Me.txtContactoConfirmo.Text & "' Where IdDescuento = " & Me.IdDescuento, CommandType.Text)
                        End If
                        Me.LimpiarDescuento()
                        Me.Cargar_Descuntos()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btnBuscarProveedor.Click
        Dim dt As New DataTable
        Dim Fx As New cFunciones
        Dim valor As String
        valor = Fx.BuscarDatos("Select CodigoProv,Nombre from Proveedores", "Nombre", "Buscar Proveedor...")
        If valor = "" Then
            Me.IdProveedor = "0"
            Me.txtProveedor.Text = ""
        Else
            cFunciones.Llenar_Tabla_Generico("select CodigoProv, Nombre from Proveedores where CodigoProv = " & valor, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Me.IdProveedor = dt.Rows(0).Item("CodigoProv")
                Me.txtProveedor.Text = dt.Rows(0).Item("Nombre")
            End If
        End If
    End Sub

    Private Sub frmDescuentosporCasaComercial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cargar_Descuntos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.Guardar_Descuento()
    End Sub

    Private Sub viewDatos_CellDoubleClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles viewDatos.CellDoubleClick
        Me.IdDescuento = Me.viewDatos.Item("IdDescuento", e.RowIndex).Value
        Me.dtpDesde.Value = Me.viewDatos.Item("Desde", e.RowIndex).Value
        Me.dtpHasta.Value = Me.viewDatos.Item("Hasta", e.RowIndex).Value
        Me.txtDescuento.Text = Me.viewDatos.Item("Descuento", e.RowIndex).Value
        Me.IdProveedor = Me.viewDatos.Item("IdProveedor", e.RowIndex).Value
        Me.txtProveedor.Text = Me.viewDatos.Item("Nombre", e.RowIndex).Value
        Me.ckEstado.Checked = Me.viewDatos.Item("Confirmado", e.RowIndex).Value
        Me.txtContactoConfirmo.Text = Me.viewDatos.Item("ContactoConfirmo", e.RowIndex).Value
        Me.btnEliminar.Enabled = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MsgBox("Desea Eliminar El Descuento", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") Then
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            db.Ejecutar("Delete from Descuentos Where IdDescuento = " & Me.IdDescuento, CommandType.Text)
            Me.LimpiarDescuento()
            Me.Cargar_Descuntos()
        End If        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmListaDescuentosAutomaticos
        frm.ShowDialog()
    End Sub

End Class