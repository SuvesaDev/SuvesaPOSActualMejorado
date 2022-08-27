Imports System.Data

Public Class CierreOrdenTrabajo
    Public Property IdCierre As Integer
    Public Property IdOrden As Integer
    Public Property Fecha As DateTime
    Public Property IdUsuario As String
    Public Property Observaciones As String
    Public Property Anulado As Boolean

    Private Function GetIdCierre() As Integer
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select Max(IdCierre) As Id From CierreOrdenTrabajo", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("Id")
        Else
            Return 0
        End If
    End Function

    Public Function Registrar() As Boolean
        Dim db As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
        Dim strSQL As String = ""
        Try
            strSQL = "Insert Into CierreOrdenTrabajo(IdOrden, Fecha, IdUsuario, Observaciones, Anulado) Values(@IdOrden, @Fecha, @IdUsuario, @Observaciones, @Anulado);"
            db.SetParametro("@IdOrden", Me.IdOrden)
            db.SetParametro("@Fecha", Me.Fecha)
            db.SetParametro("@IdUsuario", Me.IdUsuario)
            db.SetParametro("@Observaciones", Me.Observaciones)
            db.SetParametro("@Anulado", Me.Anulado)
            db.Ejecutar(strSQL, Data.CommandType.Text)

            strSQL = "Update OrdenTrabajo set Estado = 'CERRADA' Where IdOrden = @IdOrden"
            db.SetParametro("@IdOrden", Me.IdOrden)
            db.Ejecutar(strSQL, Data.CommandType.Text)

            db.Commit()

            Me.IdCierre = Me.GetIdCierre
            Return True
        Catch ex As Exception
            db.Rollback()
            Return False
        End Try
    End Function

    Public Function OrdenesTrabajoAbiertas() As DataTable
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select IdOrden, FechaIngreso, Serie, Nombre, TrabajoSolicitados From OrdenTrabajo Where Estado Not In('CERRADA')", dt, CadenaConexionSeePOS)
        Return dt
    End Function

    Public Function CierreOrden(_Texto As String) As DataTable
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select c.IdCierre, c.IdOrden, ot.Serie, c.Fecha, ot.Nombre as Cliente, c.Anulado from CierreOrdenTrabajo c inner join OrdenTrabajo ot on ot.IdOrden = c.IdOrden Where ot.Nombre like '%" & _Texto & "%' or ot.Serie like '%" & _Texto & "%'", dt, CadenaConexionSeePOS)
        Return dt
    End Function

End Class
