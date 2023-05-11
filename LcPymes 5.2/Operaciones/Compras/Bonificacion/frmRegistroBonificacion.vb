Public Class frmRegistroBonificacion

    Private codProveedor As String = "0"

    Private Sub BuscarProveedor()
        Dim Fx As New cFunciones
        Dim valor As String
        valor = Fx.BuscarDatos("Select CodigoProv,Nombre from Proveedores", "Nombre", "Buscar Proveedor...", CadenaConexionSeePOS)
        If valor = "" Then
            Exit Sub
        Else
            Dim dt As New System.Data.DataTable
            cFunciones.Llenar_Tabla_Generico("Select CodigoProv,Nombre from Proveedores Where CodigoProv = " & valor, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Me.codProveedor = valor
                Me.txtProveedor.Text = dt.Rows(0).Item("Nombre")
            Else
                Me.codProveedor = "0"
                Me.txtProveedor.Text = ""
            End If
        End If
    End Sub

    Private Sub CargarDatos()
        Dim dt As New System.Data.DataTable
        cFunciones.Llenar_Tabla_Generico("select CodigoProv, Nombre, MensajeBonificacion from Proveedores where Bonificacion = 1", dt, CadenaConexionSeePOS)
        Me.viewDatos.Rows.Clear()
        Dim index As Integer = 0
        For Each row As Data.DataRow In dt.Rows
            Me.viewDatos.Rows.Add()
            Me.viewDatos.Item("cCodigo", index).Value = row.Item("CodigoProv")
            Me.viewDatos.Item("cProveedor", index).Value = row.Item("Nombre")
            Me.viewDatos.Item("cBonificacion", index).Value = row.Item("MensajeBonificacion")
            index += 1
        Next

    End Sub

    Private Sub RegistrarDatos(_Mensaje As String, _Codigo As String)
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        If _Mensaje = "" Then
            'quitar
            db.Ejecutar("Update Proveedores set Bonificacion = 0, MensajeBonificacion = '' where CodigoProv = " & _Codigo, Data.CommandType.Text)
        Else
            'agregar
            db.Ejecutar("Update Proveedores set Bonificacion = 1, MensajeBonificacion = '" & _Mensaje & "' where CodigoProv = " & _Codigo, Data.CommandType.Text)
        End If
        Me.codProveedor = "0"
        Me.txtProveedor.Text = ""
        Me.txtMensaje.Text = ""
        Me.CargarDatos()
    End Sub

    Private Sub frmRegistroBonificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarDatos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Me.txtMensaje.Text <> "" And Me.codProveedor <> "0" Then
            Me.RegistrarDatos(Me.txtMensaje.Text, Me.codProveedor)
        Else
            MsgBox("Debe seleccionar un proveedor y ingresar un detalle de la bonificacion")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Me.codProveedor <> "0" Then
            If MsgBox("Desea quitar el proveedor de las bonificacciones.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion!!!") = MsgBoxResult.Yes Then
                Me.RegistrarDatos("", Me.codProveedor)
            End If
        End If
    End Sub

    Private Sub btnBuscarSugerido_Click(sender As Object, e As EventArgs) Handles btnBuscarSugerido.Click
        Me.BuscarProveedor()
    End Sub

    Private Sub viewDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellDoubleClick
        If Me.viewDatos.Rows.Count > 0 Then
            Me.codProveedor = Me.viewDatos.Item("cCodigo", Me.viewDatos.CurrentRow.Index).Value
            Me.txtProveedor.Text = Me.viewDatos.Item("cProveedor", Me.viewDatos.CurrentRow.Index).Value
            Me.txtMensaje.Text = Me.viewDatos.Item("cBonificacion", Me.viewDatos.CurrentRow.Index).Value
        End If
    End Sub
End Class