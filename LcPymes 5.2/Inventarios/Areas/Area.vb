Imports System.Data
Public Class Area

    Public IdArea As Integer
    Public Descripcion As String
    Public Observaciones As String

    Public Function ObtenerArea(_IdArea As Integer) As DataTable
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * From Area Where IdArea = " & _IdArea, dt, CadenaConexionSeePOS)
        Return dt
    End Function

    Public Function ObtenerAreaEncargado(_IdArea As Integer) As DataTable
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select a.*, u.Cedula, u.Nombre From AreaEncargado a inner join Usuarios u on a.IdUsuario = u.Cedula where IdArea = " & _IdArea, dt, CadenaConexionSeePOS)
        Return dt
    End Function

    Public Function ObtenerAreaArticulo(_IdArea As Integer) As DataTable
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select a.*, i.Cod_Articulo, i.Barras, i.Descripcion + ' ( ' + CAST(i.PresentaCant as nvarchar) + ' ' + p.Presentaciones + ' ) ' as Descripcion, i.Existencia From AreaArticulo a inner join Inventario i on a.Codigo = i.Codigo inner join Presentaciones p on i.CodPresentacion = p.CodPres where IdArea = " & _IdArea, dt, CadenaConexionSeePOS)
        Return dt
    End Function

    Public Function Guardar(_Encargados As DataGridView, _Articulos As DataGridView) As Boolean
        Dim db As OBSoluciones.SQL.Transaccion
        db = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
        Try

            'Registra o Actualiza el Area
            db.AddParametroSalida("@IdArea", Me.IdArea)
            db.SetParametro("@Descripcion", Me.Descripcion)
            db.SetParametro("@Observacion", Me.Observaciones)
            db.Ejecutar("GuardarArea", Me.IdArea, 0)

            'Elimina todos los encargados
            db.Ejecutar("Delete from AreaEncargado where IdArea = " & Me.IdArea, Data.CommandType.Text)
            For Each r As DataGridViewRow In _Encargados.Rows
                'Registra los encargados
                db.Ejecutar("Insert into AreaEncargado(IdArea,IdUsuario) Values(" & Me.IdArea & ",'" & r.Cells("cCedula").Value & "')", Data.CommandType.Text)
            Next

            'Elimina todos los articulos
            db.Ejecutar("Delete from AreaArticulo where IdArea = " & Me.IdArea, Data.CommandType.Text)
            For Each r As DataGridViewRow In _Articulos.Rows
                'Registra los articulos
                db.Ejecutar("Insert into AreaArticulo(IdArea,Codigo) Values(" & Me.IdArea & "," & r.Cells("cCodigo").Value & ")", Data.CommandType.Text)
            Next

            db.Commit()
            Return True
        Catch ex As Exception
            db.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

    Public Function EliminarArea(_IdArea As Integer) As Boolean
        Dim db As OBSoluciones.SQL.Transaccion
        db = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
        Try
            db.Ejecutar("Delete from Area where IdArea = " & _IdArea, Data.CommandType.Text)
            db.Ejecutar("Delete from AreaEncargado where IdArea = " & _IdArea, Data.CommandType.Text)
            db.Ejecutar("Delete from AreaArticulo where IdArea = " & _IdArea, Data.CommandType.Text)
            db.Commit()
            Return True
        Catch ex As Exception
            db.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

End Class
