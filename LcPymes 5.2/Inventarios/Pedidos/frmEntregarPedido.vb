Public Class frmEntregarPedido

    Private IdUsuario As String = ""

    Private Sub CargarBodegas()
        Dim dt As New System.Data.DataTable
        cFunciones.Llenar_Tabla_Generico("select id, nombre from solicitara where predeterminada = 0", dt, CadenaConexionSeePOS)
        Me.cboSolicitarA.DataSource = dt
        Me.cboSolicitarA.DisplayMember = "nombre"
        Me.cboSolicitarA.ValueMember = "id"
    End Sub

    Private Sub CargarPedidos()
        Try
            Dim dt As New System.Data.DataTable
            cFunciones.Llenar_Tabla_Generico("select Estado, FechaSolicitud, UsuarioSolicito, Consecutivo from viewPedidosBodega where IdSolicitara = " & Me.cboSolicitarA.SelectedValue & " and Estado =  'SOLICITADO' group by Estado, FechaSolicitud, UsuarioSolicito, Consecutivo ", dt, CadenaConexionSeePOS)
            Me.viewDatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub frmEntregarPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarBodegas()
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Me.CargarPedidos()
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dt As New System.Data.DataTable
            cFunciones.Llenar_Tabla_Generico("select Id_Usuario, Nombre from Usuarios where Clave_Interna = '" & Me.txtUsuario.Text & "'", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Me.GroupBox1.Enabled = True
                Me.txtUsuario.Enabled = False
                Me.IdUsuario = dt.Rows(0).Item("Id_Usuario")
                Me.lblUsuario.Text = dt.Rows(0).Item("Nombre")
            End If
        End If
    End Sub

    Private Sub viewDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellDoubleClick
        Dim frm As New frmEntregarSolicitudPedido
        frm.Consecutivo = Me.viewDatos.Item("Consecutivo", Me.viewDatos.CurrentRow.Index).Value
        frm.txtNombreUsuario.Text = Me.lblUsuario.Text
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim Registrado As Boolean = False
            Dim db As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
            Try
                For Each r As DataGridViewRow In frm.DataGridView1.Rows
                    db.Ejecutar("update PedidoBodega set Estado = 'Entregado', FechaEntrega = GETDATE(), CantidadEntrega = " & r.Cells("Entrega").Value & ", IdUsuarioEntrega = '" & Me.IdUsuario & "' where IdPedido = " & r.Cells("IdPedido").Value, Data.CommandType.Text)
                Next
                db.Commit()
                Registrado = True
            Catch ex As Exception
                db.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "No se pudo realizar la operacion.")
            End Try

            If Registrado = True Then
                Dim ReporteDocumento As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                ReporteDocumento.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
                ReporteDocumento = New rptEntregaBodega
                ReporteDocumento.SetParameterValue(0, frm.Consecutivo)
                CrystalReportsConexion.LoadShow(ReporteDocumento, MdiParent, CadenaConexionSeePOS)
            End If

            Me.CargarPedidos()
        End If
    End Sub

End Class