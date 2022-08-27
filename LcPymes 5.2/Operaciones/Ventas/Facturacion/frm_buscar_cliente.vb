Imports System.Data
Imports System.Windows.Forms

Public Class frm_buscar_cliente
    Public id As String
    Public cedula As String
    Public nombre As String
    Dim t As String = ""

    Private Sub frm_buscar_cliente_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim cfunc As New cFunciones
        Dim dts As New DataTable
        cfunc.Llenar_Tabla_Generico("select identificacion,cedula,nombre,tipo_cedula as Tipo from clientes", dts, CadenaConexionSeePOS)
        datos.DataSource = dts
        txt_nombre.Text = ""
        txt_nombre.Focus()
    End Sub
    Sub filtro()

        Dim cfunc As New cFunciones
        Dim itemChecked As Object
        Dim t As String = ""

        For Each itemChecked In ck_tipo.CheckedItems
            If t = "" Then
                t = "tipo = '" & itemChecked.ToString() & "'"
            Else
                t += "or tipo = '" & itemChecked.ToString() & "'"
            End If

        Next
        Dim dts As New DataTable
        dts = New DataTable
        cfunc.Llenar_Tabla_Generico("select identificacion,cedula,nombre, tipo_cedula astipo from clientes where (" & t & ")", dts, CadenaConexionSeePOS)
        datos.DataSource = dts
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_aceptar.Click
        Me.id = Me.datos.Item("col_id", Me.datos.CurrentRow.Index).Value
        Me.cedula = Me.datos.Item("col_cedula", Me.datos.CurrentRow.Index).Value
        Me.nombre = Me.datos.Item("col_nombre", Me.datos.CurrentRow.Index).Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub ck_tipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ck_tipo.SelectedIndexChanged
        Dim cfunc As New cFunciones
        Dim itemChecked As Object
        t = ""

        For Each itemChecked In ck_tipo.CheckedItems
            If t = "" Then
                t = "tipo_cedula = '" & itemChecked.ToString() & "'"
            Else
                t += "or tipo_cedula = '" & itemChecked.ToString() & "'"
            End If
        Next

        Dim dts As New DataTable
        dts = New DataTable
        If t = "" Then
            cfunc.Llenar_Tabla_Generico("select identificacion,cedula,nombre, tipo_cedula as tipo from clientes", dts, CadenaConexionSeePOS)
        Else
            cfunc.Llenar_Tabla_Generico("select identificacion,cedula,nombre,tipo_cedula as tipo from clientes where " & t, dts, CadenaConexionSeePOS)
        End If
        datos.DataSource = dts
    End Sub

    Private Sub txt_nombre_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txt_nombre.TextChanged
        Dim cfunc As New cFunciones
        If rb_nombre.Checked = True Then
            If t = "" Then
                Dim dts As New DataTable
                cfunc.Llenar_Tabla_Generico("select identificacion,cedula,nombre,tipo_cedula from clientes where nombre like '%" & txt_nombre.Text & "%'", dts, CadenaConexionSeePOS)
                datos.DataSource = dts
            Else
                Dim dts As New DataTable
                cfunc.Llenar_Tabla_Generico("select identificacion,cedula,nombre,tipo_cedula from clientes where nombre like '%" & txt_nombre.Text & "%' and  anulado = 0 and " & t, dts, CadenaConexionSeePOS)
                datos.DataSource = dts
            End If
        Else
            If t = "" Then
                Dim dts As New DataTable
                cfunc.Llenar_Tabla_Generico("select identificacion,cedula,nombre,tipo_cedula from clientes where cedula like '%" & txt_nombre.Text & "%'", dts, CadenaConexionSeePOS)
                datos.DataSource = dts
            Else
                Dim dts As New DataTable
                cfunc.Llenar_Tabla_Generico("select identificacion,cedula,nombre,tipo_cedula from clientes where cedula like '%" & txt_nombre.Text & "%' and  anulado = 0 and " & t, dts, CadenaConexionSeePOS)
                datos.DataSource = dts
            End If
        End If

    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_cancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub datos_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles datos.CellDoubleClick
        Me.id = Me.datos.Item("col_id", Me.datos.CurrentRow.Index).Value
        Me.cedula = Me.datos.Item("col_cedula", Me.datos.CurrentRow.Index).Value
        Me.nombre = Me.datos.Item("col_nombre", Me.datos.CurrentRow.Index).Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub txt_nombre_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_nombre.KeyDown
        If datos.RowCount > 0 Then
            If e.KeyCode = Keys.Enter Then
                Me.datos.Focus()
            End If
        End If
    End Sub

    Private Sub datos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles datos.KeyDown
        If datos.RowCount > 0 Then
            If e.KeyCode = Keys.Enter Then
                Me.id = Me.datos.Item("col_id", Me.datos.CurrentRow.Index).Value
                Me.cedula = Me.datos.Item("col_cedula", Me.datos.CurrentRow.Index).Value
                Me.nombre = Me.datos.Item("col_nombre", Me.datos.CurrentRow.Index).Value
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If            
        End If
    End Sub

    Private Sub frm_buscar_cliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

End Class