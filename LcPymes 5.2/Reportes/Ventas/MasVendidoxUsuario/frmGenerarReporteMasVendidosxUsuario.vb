Imports System.Data
Public Class frmGenerarReporteMasVendidosxUsuario

    Private CodProveedor As String = ""

    Private Sub txtCodigo_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        Dim dt As New DataTable
        Select Case e.KeyCode
            Case Windows.Forms.Keys.Enter
                cFunciones.Llenar_Tabla_Generico("select CodigoProv, Nombre from Proveedores where CodigoProv = " & Me.txtCodigo.Text, dt, CadenaConexionSeePOS)
                If dt.Rows.Count > 0 Then
                    Me.CodProveedor = dt.Rows(0).Item("CodigoProv")
                    Me.txtCodigo.Text = dt.Rows(0).Item("CodigoProv")
                    Me.lblProveedor.Text = dt.Rows(0).Item("Nombre")
                End If
            Case Windows.Forms.Keys.F1
                Dim Fx As New cFunciones
                Dim valor As String
                valor = Fx.BuscarDatos("Select CodigoProv,Nombre from Proveedores", "Nombre", "Buscar Proveedor...")
                If valor = "" Then
                    Me.CodProveedor = ""
                    Me.txtCodigo.Text = ""
                    Me.lblProveedor.Text = ""
                Else
                    cFunciones.Llenar_Tabla_Generico("select CodigoProv, Nombre from Proveedores where CodigoProv = " & valor, dt, CadenaConexionSeePOS)
                    If dt.Rows.Count > 0 Then
                        Me.CodProveedor = dt.Rows(0).Item("CodigoProv")
                        Me.txtCodigo.Text = dt.Rows(0).Item("CodigoProv")
                        Me.lblProveedor.Text = dt.Rows(0).Item("Nombre")
                    End If
                End If
        End Select
    End Sub

    Private Sub ConsultarxProveedor()
        If CodProveedor <> "" Then
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select Codigo, Cod_Articulo, Descripcion  from CatalogoInventario Where Inhabilitado = 0 and Proveedor = " & CodProveedor, dt, CadenaConexionSeePOS)
            Dim index As Integer = 0
            Me.viewDatos.Rows.Clear()
            For Each r As DataRow In dt.Rows
                Me.viewDatos.Rows.Add()
                Me.viewDatos.Item("cCodigo", index).Value = r.Item("Codigo")
                Me.viewDatos.Item("cCodArticulo", index).Value = r.Item("Cod_Articulo")
                Me.viewDatos.Item("cDescripcion", index).Value = r.Item("Descripcion")
                Me.viewDatos.Item("cUsar", index).Value = True
                index += 1
            Next
        End If
    End Sub

    Private Sub ConsultarxDescripcion()
        If Me.txtDescripcion.Text <> "" Then
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select Codigo, Cod_Articulo, Descripcion  from CatalogoInventario Where Inhabilitado = 0 and Descripcion Like '%" & Me.txtDescripcion.Text & "%'", dt, CadenaConexionSeePOS)
            Dim index As Integer = 0
            Me.viewDatos.Rows.Clear()
            For Each r As DataRow In dt.Rows
                Me.viewDatos.Rows.Add()
                Me.viewDatos.Item("cCodigo", index).Value = r.Item("Codigo")
                Me.viewDatos.Item("cCodArticulo", index).Value = r.Item("Cod_Articulo")
                Me.viewDatos.Item("cDescripcion", index).Value = r.Item("Descripcion")
                Me.viewDatos.Item("cUsar", index).Value = True
                index += 1
            Next
        End If
    End Sub

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Me.ConsultarxProveedor()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.ConsultarxDescripcion()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim db As OBSoluciones.SQL.Transaccion
        db = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
        Try
            db.Ejecutar("Delete from ListaReporte where PC = '" & My.Computer.Name & "'", CommandType.Text)
            For Each r As DataGridViewRow In Me.viewDatos.Rows
                If r.Cells("cUsar").Value = True Then
                    db.Ejecutar("Insert Into ListaReporte(Fecha, PC, Codigo) Values(GETDATE(),'" & My.Computer.Name & "'," & r.Cells("cCodigo").Value & ")", CommandType.Text)
                End If
            Next
            db.Commit()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            db.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "No se pudo realizar la operacion")
        End Try
    End Sub

End Class