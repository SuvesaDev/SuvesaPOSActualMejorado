Public Class frmArticulosSugeridos
    Private cls As New ArticulosSugeridos
    Private CodigoPrincipal As Long = 0
    Private CodigoSugerido As Long = 0

    Private Function BuscarF1() As String
        Dim Codigo As String = ""
        Dim BuscarArt As New FrmBuscarArticulo2
        BuscarArt.SoloSinBarras = False
        BuscarArt.StartPosition = FormStartPosition.CenterParent
        BuscarArt.Codigo = ""
        BuscarArt.Cod_Articulo = True
        BuscarArt.ShowDialog()
        If BuscarArt.Cancelado Then
            Codigo = BuscarArt.Codigo
            Return Codigo
        End If
        Codigo = BuscarArt.Codigo
        BuscarArt.Close()
        BuscarArt.Dispose()
        BuscarArt = Nothing
        Return Codigo
    End Function

    Private Sub BuscarCodigo(ByRef txt As TextBox)
        Dim codigo As String = BuscarF1()

        Dim dt As New Data.DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT Codigo, dbo.Inventario.Descripcion + '( ' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + dbo.Presentaciones.Presentaciones + ') ' AS Descripcion, Cod_Articulo from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE Inhabilitado = 0 and (Cod_Articulo ='" & codigo & "' or Barras = '" & codigo & "' or barras2 = '" & codigo & "' or barras3 = '" & codigo & "')", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then

            Select Case txt.Name
                Case Me.txtDescripccionPrincipal.Name
                    Me.CodigoPrincipal = dt.Rows(0).Item("Codigo")
                    Me.txtDescripccionPrincipal.Text = dt.Rows(0).Item("Descripcion")
                    Me.CargarSugeridos(Me.CodigoPrincipal)

                Case Me.txtDescripccionSugerido.Name
                    Me.CodigoSugerido = dt.Rows(0).Item("Codigo")
                    Me.txtDescripccionSugerido.Text = dt.Rows(0).Item("Descripcion")

            End Select

        End If
    End Sub

    Private Sub AgregarSugerido()
        If Me.CodigoPrincipal > 0 And Me.CodigoSugerido > 0 Then
            Dim resultado As Boolean = Me.cls.GuardarSugerido(Me.CodigoPrincipal, Me.CodigoSugerido)
            If resultado = True Then
                MsgBox("Datos registrados Correctamente", MsgBoxStyle.Information, Me.Text)
                Me.CodigoSugerido = 0
                Me.txtDescripccionSugerido.Text = ""
                Me.CargarSugeridos(Me.CodigoPrincipal)
            End If
        Else
            MsgBox("Debe seleccionar el articulo principal y el sugerido.", MsgBoxStyle.Exclamation, Me.Text)
        End If
    End Sub

    Private Sub EliminarSugerido()
        If Me.viewDatos.RowCount > 0 Then
            Dim Id As String = Me.viewDatos.Item("cId", Me.viewDatos.CurrentRow.Index).Value
            Dim resultado As Boolean = Me.cls.EliminarSugerido(Id)
            If resultado = True Then
                MsgBox("Datos Eliminados Correctamente", MsgBoxStyle.Information, Me.Text)
                Me.CargarSugeridos(Me.CodigoPrincipal)
            End If
        End If
    End Sub

    Private Sub CargarSugeridos(_CodigoPrincipal As String)
        Dim dt As New System.Data.DataTable
        dt = cls.GetSugeridos(_CodigoPrincipal)

        Try
            Me.viewDatos.Rows.Clear()
            Dim Index As Integer = 0
            For Each row As System.Data.DataRow In dt.Rows
                Me.viewDatos.Rows.Add()
                Me.viewDatos.Item("cId", Index).Value = row.Item("Id")
                Me.viewDatos.Item("cCodigo", Index).Value = row.Item("Cod_Articulo")
                Me.viewDatos.Item("cDescripccion", Index).Value = row.Item("Descripcion")
                Index += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnBuscarPrincipal_Click(sender As Object, e As EventArgs) Handles btnBuscarPrincipal.Click
        Me.BuscarCodigo(Me.txtDescripccionPrincipal)
    End Sub

    Private Sub btnBuscarSugerido_Click(sender As Object, e As EventArgs) Handles btnBuscarSugerido.Click
        Me.BuscarCodigo(Me.txtDescripccionSugerido)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.AgregarSugerido()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.EliminarSugerido()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.CodigoPrincipal = 0
        Me.CodigoSugerido = 0
        Me.txtDescripccionPrincipal.Text = ""
        Me.txtDescripccionSugerido.Text = ""

    End Sub
End Class