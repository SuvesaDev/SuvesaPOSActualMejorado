Public Class frmLaboratorio

    Private Enviar As String = "Enviar Muestra"
    Private Recibir As String = "Recibir Muestra"

    Private Sub PendientesEnviar()
        Try
            Me.lblTexto.Text = Me.Enviar
            Me.lblTexto.ForeColor = Drawing.Color.DarkGreen
            Me.viewDatos.MultiSelect = True
            Me.btnAplicar.Text = Me.Enviar
            Dim dt As New System.Data.DataTable
            cFunciones.Llenar_Tabla_Generico("select * from viewlaboratorio where Id = 0", dt, CadenaConexionSeePOS)
            Me.viewDatos.DataSource = dt

            viewDatos.Columns("Id").Visible = False
            viewDatos.Columns("IdFactura").Visible = False
            viewDatos.Columns("Usuario").Visible = False
            viewDatos.Columns("Fecha").Visible = False
            viewDatos.Columns("Proveedor").Visible = False
            viewDatos.Columns("FacturaCompra").Visible = False
            viewDatos.Columns("Costo").Visible = False

            viewDatos.Columns("Telefono").Visible = False
            viewDatos.Columns("Guia").Visible = False
            viewDatos.Columns("Doctor").Visible = False

            viewDatos.Columns("Cantidad").Visible = True
            viewDatos.Columns("SubTotal").Visible = True

            viewDatos.Columns("FechaFactura").DefaultCellStyle.Format = "d"
            viewDatos.Columns("Cantidad").DefaultCellStyle.Format = "N2"
            viewDatos.Columns("Precio_Unit").DefaultCellStyle.Format = "N2"
            viewDatos.Columns("SubTotal").DefaultCellStyle.Format = "N2"

            viewDatos.Columns("Cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            viewDatos.Columns("Precio_Unit").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            viewDatos.Columns("SubTotal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            viewDatos.Columns("FechaFactura").Width = 80
            viewDatos.Columns("Num_Factura").Width = 80
            viewDatos.Columns("Nombre_Cliente").Width = 300
            viewDatos.Columns("CodArticulo").Width = 75
            viewDatos.Columns("Descripcion").Width = 250
            viewDatos.Columns("Cantidad").Width = 65
            viewDatos.Columns("Precio_Unit").Width = 80
            viewDatos.Columns("SubTotal").Width = 80
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub PendienteRecibir()
        Try
            Me.lblTexto.Text = Me.Recibir
            Me.lblTexto.ForeColor = Drawing.Color.DarkBlue
            Me.viewDatos.MultiSelect = False
            Me.btnAplicar.Text = Me.Recibir
            Dim dt As New System.Data.DataTable
            cFunciones.Llenar_Tabla_Generico("select * from viewlaboratorio where Id > 0 and Costo = 0", dt, CadenaConexionSeePOS)
            Me.viewDatos.Refresh()
            Me.viewDatos.DataSource = dt

            viewDatos.Columns("Id").Visible = False
            viewDatos.Columns("IdFactura").Visible = False
            viewDatos.Columns("Usuario").Visible = False
            viewDatos.Columns("Fecha").Visible = False
            viewDatos.Columns("Cantidad").Visible = False
            viewDatos.Columns("SubTotal").Visible = False
            viewDatos.Columns("Proveedor").Visible = True
            viewDatos.Columns("Telefono").Visible = False
            viewDatos.Columns("Guia").Visible = False
            viewDatos.Columns("Doctor").Visible = False

            viewDatos.Columns("FechaFactura").DefaultCellStyle.Format = "d"
            viewDatos.Columns("Cantidad").DefaultCellStyle.Format = "N2"
            viewDatos.Columns("Precio_Unit").DefaultCellStyle.Format = "N2"
            viewDatos.Columns("SubTotal").DefaultCellStyle.Format = "N2"

            viewDatos.Columns("Cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            viewDatos.Columns("Precio_Unit").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            viewDatos.Columns("SubTotal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            viewDatos.Columns("FechaFactura").Width = 80
            viewDatos.Columns("Num_Factura").Width = 80
            viewDatos.Columns("Nombre_Cliente").Width = 300
            viewDatos.Columns("Proveedor").Width = 140
            viewDatos.Columns("CodArticulo").Width = 75
            viewDatos.Columns("Descripcion").Width = 250
            viewDatos.Columns("Cantidad").Width = 65
            viewDatos.Columns("Precio_Unit").Width = 80
            viewDatos.Columns("SubTotal").Width = 80
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub frmLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PendientesEnviar()
    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        If Me.viewDatos.Rows.Count > 0 Then
            If Me.btnAplicar.Text = Me.Enviar Then
                ''Eviar muestra
                Dim frm As New frmRegistrarLaboratorio
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    For Each r As DataGridViewRow In Me.viewDatos.SelectedRows
                        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                        db.Ejecutar("Insert Into Laboratorio(IdFactura, IdUsuario,Fecha, CodigoProv, FacturaCompra, Costo, Guia, Doctor) values(" & r.Cells("IdFactura").Value & ",'" & frm.IdUsuario & "',GETDATE()," & frm.CodProveedor & ",'',0, '" & frm.txtGuia.Text & "', '" & frm.txtDoctor.Text & "')", Data.CommandType.Text)
                    Next
                    Me.PendientesEnviar()
                End If
            Else
                ''Recibir muestra
                Dim frm As New frmRecibirMuestraLaboratorio
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                    db.Ejecutar("Update Laboratorio Set FacturaCompra = '" & frm.txtNumFactura.Text & "', Costo = " & frm.txtCostoUnit.Text & ", IdUsuarioRecibido = '" & frm.IdUsuario & "', FechaRecibido = GetDate() where Id = " & Me.viewDatos.Item("Id", Me.viewDatos.CurrentRow.Index).Value, Data.CommandType.Text)
                    Me.PendienteRecibir()
                End If                
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.PendientesEnviar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.PendienteRecibir()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New frmConsultaLaboratorio
        frm.WindowState = FormWindowState.Maximized
        frm.ShowDialog()
    End Sub
End Class