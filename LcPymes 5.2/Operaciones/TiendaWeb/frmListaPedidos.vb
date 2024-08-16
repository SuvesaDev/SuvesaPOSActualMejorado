Public Class frmListaPedidos

    Private Pagina As Integer = 1

    Private Async Sub CargarPedidos(Optional ByVal _Estado As String = "any")
        Dim cls As New TiendaWeb.apiTienda
        Dim datos As System.Collections.Generic.List(Of TiendaWeb.Pedidos) = Await cls.AllPedidos(Me.Pagina, _Estado)
        If IsNothing(datos) Then
            Me.viewDatos.Rows.Clear()
        Else
            Me.Cargar(datos)
        End If
    End Sub

    Private Sub Cargar(_datos As System.Collections.Generic.List(Of TiendaWeb.Pedidos))
        Try
            Dim Index As Integer = 0
            Me.viewDatos.Rows.Clear()
            Me.viewDatos.Columns("ctotal").DefaultCellStyle.Format = "N2"
            For Each r As TiendaWeb.Pedidos In _datos
                Me.viewDatos.Rows.Add()
                Me.viewDatos.Item("cid", Index).Value = r.id
                Me.viewDatos.Item("cstatus", Index).Value = r.status
                Me.viewDatos.Item("cdate_created", Index).Value = r.date_created
                Me.viewDatos.Item("cdate_modified", Index).Value = r.date_modified
                Me.viewDatos.Item("cshipping_total", Index).Value = r.shipping_total
                Me.viewDatos.Item("ctotal", Index).Value = CDec(r.total)
                Me.viewDatos.Item("ccustomer_id", Index).Value = r.customer_id
                Me.viewDatos.Item("cfirst_nameB", Index).Value = r.billing.first_name.ToUpper
                Me.viewDatos.Item("clast_nameB", Index).Value = r.billing.last_name.ToUpper
                Me.viewDatos.Item("caddress_1B", Index).Value = r.billing.address_1
                Me.viewDatos.Item("ccityB", Index).Value = r.billing.city
                Me.viewDatos.Item("cstateB", Index).Value = r.billing.state
                Me.viewDatos.Item("cemailB", Index).Value = r.billing.email
                Me.viewDatos.Item("cfirst_nameE", Index).Value = r.shipping.first_name.ToUpper
                Me.viewDatos.Item("clast_nameE", Index).Value = r.shipping.last_name.ToUpper
                Me.viewDatos.Item("caddress_1E", Index).Value = r.shipping.address_1
                Me.viewDatos.Item("ccityE", Index).Value = r.shipping.city
                Me.viewDatos.Item("cstateE", Index).Value = r.shipping.state
                Me.viewDatos.Item("cphoneE", Index).Value = r.shipping.phone
                Index += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Public SoloLectura As Boolean = False

    Private Sub frmListaPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarPedidos()
        If Me.SoloLectura = True Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Me.CargarPedidos()
    End Sub

    Private Sub viewDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellDoubleClick
        Try
            Dim frm As New frmPedidoWeb
            frm.SoloLectura = Me.SoloLectura
            frm.Id = Me.viewDatos.Item("cid", Me.viewDatos.CurrentRow.Index).Value
            frm.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CargarPedidos("processing")
    End Sub

End Class