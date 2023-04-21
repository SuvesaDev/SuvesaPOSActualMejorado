Public Class ArticulosSugeridos

    Private Trans As OBSoluciones.SQL.Transaccion

    Public Function GetSugeridos(_CodigoPrincipal As String) As System.Data.DataTable
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        Return db.Ejecutar("Select * from viewArticuloSugerido where CodigoPrincipal = " & _CodigoPrincipal, Data.CommandType.Text)
    End Function

    Public Function GetPrincipal(_CodigoSugerido As String) As System.Data.DataTable
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        Return db.Ejecutar("Select * from viewArticuloSugerido where Codigo = " & _CodigoSugerido, Data.CommandType.Text)
    End Function

    Public Function GuardarSugerido(_CodigoPrincipal As String, _CodigoSugerido As String) As Boolean        
        Me.Trans = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
        Try
            Me.Trans.Ejecutar("Insert into ArticuloSugerido(CodigoPrincipal, CodigoSugerido) Values(" & _CodigoPrincipal & "," & _CodigoSugerido & ")", Data.CommandType.Text)
            Me.Trans.Commit()
            Return True
        Catch ex As Exception
            Me.Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al registrar")
            Return False
        End Try
    End Function

    Public Function GuardarVentasSugeridas(_Id_Venta_Detalle As String, _Codigo As String, _Preventa As Boolean)
        Me.Trans = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
        Try
            Me.Trans.Ejecutar("Insert into " & IIf(_Preventa = True, "PreVentas_Sugerida", "Ventas_Sugerida") & "(Id_Venta_Detalle, Codigo) Values(" & _Id_Venta_Detalle & ", " & _Codigo & ")", Data.CommandType.Text)
            Me.Trans.Commit()
            Return True
        Catch ex As Exception
            Me.Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al registrar")
            Return False
        End Try
    End Function

    Public Function EliminarSugerido(_Id As String) As Boolean
        Me.Trans = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
        Try
            Me.Trans.Ejecutar("Delete from ArticuloSugerido Where Id = " & _Id, Data.CommandType.Text)
            Me.Trans.Commit()
            Return True
        Catch ex As Exception
            Me.Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al Eliminar")
            Return False
        End Try
    End Function

End Class
