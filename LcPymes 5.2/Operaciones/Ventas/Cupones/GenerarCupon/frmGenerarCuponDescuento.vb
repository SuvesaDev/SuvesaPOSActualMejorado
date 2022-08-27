Imports System.Data
Imports System.Drawing
Imports GenCode128
Imports System.IO

Public Class frmGenerarCuponDescuento
    Private Empresa, Telefono, Celular As String

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.GroupBox1.Enabled = True
        Me.btnGuardar.Enabled = True
        Me.txtCantidad.Text = ""
        Me.txtDescuento.Text = ""
        Me.dtpDesde.Value = Date.Now
        Me.dtpHasta.Value = Date.Now
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.txtCantidad.Text <> "" And Me.txtDescuento.Text <> "" Then
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            db.AddParametro("@CantidadCupones", CDec(Me.txtCantidad.Text))
            db.AddParametro("@Descuento", CDec(Me.txtDescuento.Text))
            db.AddParametro("@Desde", Me.dtpDesde.Value)
            db.AddParametro("@Hasta", Me.dtpHasta.Value)
            db.Ejecutar("spCrearCupones")
            Me.Close()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.dtDetalle = New DataTable
        Dim IdCupon As Long = 0
        Dim frm As New frmBuscarCupones
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim dt As New DataTable

            IdCupon = frm.viewDatos.Item("IdCupon", frm.viewDatos.CurrentRow.Index).Value
            cFunciones.Llenar_Tabla_Generico("Select * from Cupon where IdCupon = " & IdCupon, dt, CadenaConexionSeePOS)
            cFunciones.Llenar_Tabla_Generico("Select * from CuponDetalle where IdCupon = " & IdCupon, dtDetalle, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Me.txtCantidad.Text = dt.Rows(0).Item("CantidadCupones")
                Me.txtDescuento.Text = dt.Rows(0).Item("Descuento")
                Me.dtpDesde.Value = dt.Rows(0).Item("Desde")
                Me.dtpHasta.Value = dt.Rows(0).Item("Hasta")
            End If

            Me.GroupBox1.Enabled = False
            Me.btnGuardar.Enabled = False

        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescuento.KeyPress, txtCantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private WithEvents printDocument1 As New System.Drawing.Printing.PrintDocument

    Private I As Integer = 0
    Private dtDetalle As DataTable
    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDocument1.PrintPage
        Dim Codigo As String = Me.dtDetalle.Rows(I).Item("Codigo")
        Dim myimg As Image = Code128Rendering.MakeBarcodeImage(Codigo, Integer.Parse(1), True)
        pictBarcode.Image = myimg

        Dim caption As String = ""
        Dim tamanyo As Integer = 0
        Dim pos As Integer = 0

        Dim g As Graphics = e.Graphics
        Dim fnt As Font = New Font("Arial", 10)

        pos = 0
        caption = "Cupon de Descuento " & Me.txtDescuento.Text & "%"
        g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 5, pos)

        pos = 20
        g.DrawImage(pLogo.Image, 1, pos, 69, 69)
        pos = 25
        g.DrawImage(pictBarcode.Image, 70, pos)

        pos = 58
        caption = Codigo
        g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 76, pos)

        pos = 74
        'caption = "₡" & " " & Format(CDec(Me.txtPrecio.Text * Me.txtCantidad.Value), "N2")
        ' g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 76, pos)

        caption = "Valido para un solo Uso"
        g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 76, pos)

        fnt = New Font("Arial", 7)

        pos = 98
        caption = Me.Empresa.Replace(", S.A.", "") & " " & "Tel. :" & Me.Telefono & " Cel. :" & Me.Celular
        g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 2, pos)

        I += 1
        e.HasMorePages = I < CInt(Me.txtCantidad.Text)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.I = 0
        printDocument1.Print()
    End Sub

    Private Sub frmGenerarCuponDescuento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Empresa, Tel_01, Fax_02, Logo from configuraciones", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Dim data As Byte() = New Byte(-1) {}
            data = CType((dt.Rows(0)("Logo")), Byte())
            Dim mem As MemoryStream = New MemoryStream(data)
            pLogo.Image = Image.FromStream(mem)
            Me.Empresa = dt.Rows(0).Item("Empresa")
            Me.Telefono = dt.Rows(0).Item("Tel_01")
            Me.Celular = dt.Rows(0).Item("Fax_02")
        End If
    End Sub
End Class