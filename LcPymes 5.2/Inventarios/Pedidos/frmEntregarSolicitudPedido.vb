Public Class frmEntregarSolicitudPedido

    Public Consecutivo As String = "0"

    Private Sub CargarSolicitud()
        Try
            Dim dt As New System.Data.DataTable
            cFunciones.Llenar_Tabla_Generico("select pb.IdPedido, i.Codigo, i.Cod_Articulo, pb.Descripcion, i.Existencia, pb.CantidadSolicitud as Solicitud, case when i.Existencia >= pb.CantidadSolicitud then pb.CantidadSolicitud when i.Existencia < 0 then 0 else i.Existencia end as Entrega from viewPedidosBodega pb inner join Inventario i on pb.Cod_Articulo = i.Codigo where Consecutivo = " & Me.Consecutivo, dt, CadenaConexionSeePOS)
            Me.DataGridView1.DataSource = dt
            Me.DataGridView1.Columns("IdPedido").Visible = False
            Me.DataGridView1.Columns("Codigo").Visible = False

            Me.DataGridView1.Columns("Cod_Articulo").ReadOnly = True
            Me.DataGridView1.Columns("Descripcion").ReadOnly = True

            Me.DataGridView1.Columns("Existencia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.DataGridView1.Columns("Existencia").DefaultCellStyle.Format = "N2"
            Me.DataGridView1.Columns("Existencia").ReadOnly = True
            Me.DataGridView1.Columns("Solicitud").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.DataGridView1.Columns("Solicitud").DefaultCellStyle.Format = "N2"
            Me.DataGridView1.Columns("Solicitud").ReadOnly = True
            Me.DataGridView1.Columns("Entrega").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.DataGridView1.Columns("Entrega").DefaultCellStyle.Format = "N2"
            Me.DataGridView1.Columns("Entrega").ReadOnly = False

            Me.DataGridView1.Columns("Cod_Articulo").Width = 75

            Me.DataGridView1.Columns("Descripcion").Width = 360

            Me.DataGridView1.Columns("Existencia").Width = 75

            Me.DataGridView1.Columns("Solicitud").Width = 75

            Me.DataGridView1.Columns("Entrega").Width = 75

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Function ValidaCantidades() As Boolean
        Dim pasa As Boolean = True
        For Each r As DataGridViewRow In Me.DataGridView1.Rows
            Dim existencia As Decimal = r.Cells("Existencia").Value
            Dim entregar As String = r.Cells("Entrega").Value

            If Not IsNumeric(entregar) Then
                r.DefaultCellStyle.BackColor = Drawing.Color.Tomato
                r.DefaultCellStyle.SelectionBackColor = Drawing.Color.Tomato
                pasa = False
            Else
                If existencia > 0 And CDec(entregar) > existencia Then
                    r.DefaultCellStyle.BackColor = Drawing.Color.Tomato
                    r.DefaultCellStyle.SelectionBackColor = Drawing.Color.Tomato
                    pasa = False
                Else
                    r.DefaultCellStyle.BackColor = Drawing.Color.White
                    r.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
                End If
            End If
        Next
        Return pasa
    End Function

    Private Sub frmEntregarSolicitudPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtFechaEntrega.Text = Date.Now
        Me.CargarSolicitud()
    End Sub

    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        If Not Me.ValidaCantidades Then
            MsgBox("Revise la cantidad a entregar" & vbCrLf _
                   & "debe ser un valor numerico no mayor a la existencia del producto.", MsgBoxStyle.Critical, "No se puede realizar la operacion.")
            Exit Sub
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub
End Class