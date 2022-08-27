Imports System.Data
Imports System.Drawing

Public Class frmBuscadorCodigoCabys

    Private FontNormal As System.Drawing.Font = New System.Drawing.Font("Segoe UI", 11)
    Private FontSeleccionado As System.Drawing.Font = New System.Drawing.Font("Segoe UI", 11, FontStyle.Bold)

    Private Sub CargarCategoria0()
        Dim cls As New Modulos.FE.Cabys
        Dim dt As New DataTable
        dt = cls.GetCabys("", 0, Me.txtBuscar.Text)
        Me.tvDatos.Nodes.Clear()
        For Each r As DataRow In dt.Rows
            Me.tvDatos.Nodes.Add(r.Item("ID"), r.Item("DESCRIPCION"))
        Next

        If Me.txtBuscar.Text <> "" Then
            For Each item As TreeNode In tvDatos.Nodes
                Me.BuscarDetallado(item)
            Next
            Me.PoneColorBuscadoDetallado()
        End If

    End Sub

    Private Sub PoneColorBuscadoDetallado()
        For Each nodo As TreeNode In Me.tvDatos.Nodes
            Me.PoneColorSeleccionado(nodo)
        Next
    End Sub

    Private Sub PoneColorSeleccionado(nodo As TreeNode)
        Dim Key As String = nodo.Name.Replace("C", "")
        Dim Nivel As Integer = 0
        Nivel = Key.Split("_")(1)

        If Nivel = 9 Then
            nodo.NodeFont = FontSeleccionado
        Else
            nodo.NodeFont = FontNormal
        End If

        For Each item As TreeNode In nodo.Nodes
            Me.PoneColorSeleccionado(item)
        Next
    End Sub

    Private Sub BuscarDetallado(node As TreeNode)
        Me.CargarCategoria(node.Name, False)

        For Each item As TreeNode In node.Nodes
            Me.BuscarDetallado(item)
        Next
    End Sub

    Private Sub ObtenerCodigoCabys(_node As System.Windows.Forms.TreeNode)
        Dim Key As String = _node.Name.Replace("C", "")
        Dim Nivel As Integer = 0
        Nivel = Key.Split("_")(1)
        If Nivel = 9 Then
            _node.NodeFont = FontSeleccionado
            Me.txtCodigo.Text = _node.Text.Split("-")(0)
            Me.txtDescripcion.Text = _node.Text.Split("-")(1)
            Me.btnAceptar.Enabled = True
        Else
            Me.txtCodigo.Text = ""
            Me.txtDescripcion.Text = ""
            Me.btnAceptar.Enabled = False
        End If
    End Sub

    Private Sub CargarCategoria(_Id As String, Optional ByVal _CambioFont As Boolean = True)
        Dim Key As String = _Id.Replace("C", "")
        Dim Codigo As String = ""
        Dim Nivel As Integer = 0

        Codigo = Key.Split("_")(0)
        Nivel = Key.Split("_")(1)

        Me.RecorrerNodos(Me.tvDatos.Nodes, _Id, Codigo, Nivel, _CambioFont)
    End Sub

    Private Sub RecorrerNodos(_nodos As System.Windows.Forms.TreeNodeCollection, _key As String, _codigo As String, _nivel As String, Optional ByVal _CambiaFont As Boolean = True)
        For Each node As System.Windows.Forms.TreeNode In _nodos
            If node.Name = _key Then
                If _CambiaFont = True Then node.NodeFont = FontNormal
                Dim cls As New Modulos.FE.Cabys
                Dim dt As New DataTable
                dt = cls.GetCabys(_codigo, _nivel, Me.txtBuscar.Text)
                node.Nodes.Clear()
                For Each r As DataRow In dt.Rows
                    node.Nodes.Add(r.Item("ID"), r.Item("DESCRIPCION"))
                    node.Nodes(r.Item("ID")).NodeFont = FontSeleccionado
                Next
                node.Expand()
            Else
                If _CambiaFont = True Then node.NodeFont = FontNormal
                If node.Nodes.Count > 0 Then
                    Me.RecorrerNodos(node.Nodes, _key, _codigo, _nivel)
                End If
            End If
        Next
    End Sub

    Private Sub frmBuscadorCodigoCabys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.CargarCategoria0()
    End Sub

    Private Sub tvDatos_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvDatos.NodeMouseDoubleClick
        Me.CargarCategoria(e.Node.Name)
    End Sub


    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.txtBuscar.Text = ""
        Me.CargarCategoria0()
        Me.txtCodigo.Text = ""
        Me.txtDescripcion.Text = ""
        Me.txtImpuesto.Text = ""
    End Sub

    Private Sub tvDatos_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvDatos.AfterSelect
        Me.ObtenerCodigoCabys(e.Node)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.CargarCategoria0()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.CargarCategoria0()
        End If        
    End Sub
End Class