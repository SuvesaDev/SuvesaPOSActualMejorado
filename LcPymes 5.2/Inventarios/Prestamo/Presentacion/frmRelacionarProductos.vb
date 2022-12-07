Imports System.Data
Public Class frmRelacionarProductos

    Private Function GetEmpresa() As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select Identificacion from seguridad.dbo.emisor", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("Identificacion")
        Else
            Return "0"
        End If
    End Function

    Private Sub CargarDatos(Optional ByVal _SoloPendientes As Boolean = False)
        Dim Cedula As String = Me.GetEmpresa
        Dim CodigoEmpresa As String = ""
        Select Case Cedula
            Case "3101105432" : CodigoEmpresa = "CodigoLiberia" 'liberia
            Case "3101340440" : CodigoEmpresa = "CodigoCanas" 'cañas
            Case "3101353624" : CodigoEmpresa = "CodigoSanta" 'sta cruz
            Case "3101610242" : CodigoEmpresa = "CodigoCamara" 'campanadas
            Case "3101696098" : CodigoEmpresa = "CodigoGuanavet" 'guanavet
            Case Else : Exit Sub
        End Select

        Dim dt As New DataTable
        If _SoloPendientes = False Then
            'dt = OBSoluciones.db.Ejecutar("Select * from Producto", CommandType.Text)
        Else
            'dt = OBSoluciones.db.Ejecutar("Select * from Producto Where " & CodigoEmpresa & " = 0", CommandType.Text)
        End If

        Me.viewDatos.Rows.Clear()        
        Dim Index As Integer = 0
        For Each r As DataRow In dt.Rows
            Me.viewDatos.Rows.Add()
            Me.viewDatos.Item("cCodigoPrestamo", Index).Value = r.Item("Codigo")
            Me.viewDatos.Item("cDescripcionPrestamo", Index).Value = r.Item("Descripcion")
            If r.Item(CodigoEmpresa) <> "0" Then
                Dim dtInventario As New DataTable
                cFunciones.Llenar_Tabla_Generico("Select * from inventario where Codigo = " & r.Item(CodigoEmpresa), dtInventario, CadenaConexionSeePOS)
                If dtInventario.Rows.Count > 0 Then
                    Me.viewDatos.Item("cCodigoInterno", Index).Value = dtInventario.Rows(0).Item("Codigo")
                    Me.viewDatos.Item("cCodArticuloInterno", Index).Value = dtInventario.Rows(0).Item("Cod_Articulo")
                    Me.viewDatos.Item("cDescripcionInterna", Index).Value = dtInventario.Rows(0).Item("Descripcion")
                End If
            Else
                Me.viewDatos.Item("cCodigoInterno", Index).Value = 0
                Me.viewDatos.Item("cCodArticuloInterno", Index).Value = ""
                Me.viewDatos.Item("cDescripcionInterna", Index).Value = ""
            End If
            Index += 1
        Next
    End Sub

    Private Sub AplicarCambios()

        If MsgBox("Desea aplicar los cambios ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar accion") = MsgBoxResult.Yes Then
            Dim dbSQL As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            'Dim dbMySQL As New OBSoluciones.MySql.Sentencias(OBSoluciones.CadenaConexionMySQL)
            Dim Cedula As String = Me.GetEmpresa
            Dim CodigoEmpresa As String = ""
            Select Case Cedula
                Case "3101105432" : CodigoEmpresa = "CodigoLiberia" 'liberia
                Case "3101340440" : CodigoEmpresa = "CodigoCanas" 'cañas
                Case "3101353624" : CodigoEmpresa = "CodigoSanta" 'sta cruz
                Case "3101610242" : CodigoEmpresa = "CodigoCamara" 'campanadas
                Case "3101696098" : CodigoEmpresa = "CodigoGuanavet" 'guanavet
                Case Else : Exit Sub
            End Select

            dbSQL.Ejecutar("Update Inventario Set CodigoPrestamo = 0 Where CodigoPrestamo <> 0", CommandType.Text)
            For Each r As DataGridViewRow In Me.viewDatos.Rows
                dbSQL.Ejecutar("Update Inventario Set CodigoPrestamo = " & r.Cells("cCodigoPrestamo").Value & " Where Codigo = " & r.Cells("cCodigoInterno").Value, CommandType.Text)
                'dbMySQL.Ejecutar("Update producto Set " & CodigoEmpresa & " = " & r.Cells("cCodigoInterno").Value & " Where Codigo = " & r.Cells("cCodigoPrestamo").Value, CommandType.Text)
            Next
        End If

    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        Me.AplicarCambios()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CargarDatos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.CargarDatos(True)
    End Sub
End Class