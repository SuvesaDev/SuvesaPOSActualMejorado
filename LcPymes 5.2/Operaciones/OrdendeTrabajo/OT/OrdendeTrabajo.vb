Imports System.Data
Public Class OrdendeTrabajo

    Public Property IdOrden As Integer
    Public Property IdUsuario As String
    Public Property FechaIngreso As Date
    Public Property Serie As Integer
    Public Property Identificacion As String
    Public Property Nombre As String
    Public Property Telefono As String
    Public Property Direccion As String
    Public Property Correo As String
    Public Property Estado As String
    Public Property Observaciones As String
    Public Property TrabajoSolicitados As String

    Private Function GetIdOrden() As Integer
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select Max(IdOrden) As Id From OrdenTrabajo", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("Id")
        Else
            Return 0
        End If
    End Function

    Public Function Registrar() As Boolean
        Try
            If Me.IdOrden = 0 Then
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                Dim strSQL As String = "Insert Into OrdenTrabajo(IdUsuario, FechaIngreso, Serie, Identificacion, Nombre, Telefono, Direccion, Correo, Estado, Observaciones, TrabajoSolicitados) Values(@IdUsuario, @FechaIngreso, @Serie, @Identificacion, @Nombre, @Telefono, @Direccion, @Correo, @Estado, @Observaciones, @TrabajoSolicitados);"
                db.AddParametro("@IdUsuario", Me.IdUsuario)
                db.AddParametro("@FechaIngreso", Me.FechaIngreso)
                db.AddParametro("@Serie", Me.Serie)
                db.AddParametro("@Identificacion", Me.Identificacion)
                db.AddParametro("@Nombre", Me.Nombre)
                db.AddParametro("@Telefono", Me.Telefono)
                db.AddParametro("@Direccion", Me.Direccion)
                db.AddParametro("@Correo", Me.Correo)
                db.AddParametro("@Estado", Me.Estado)
                db.AddParametro("@Observaciones", Me.Observaciones)
                db.AddParametro("@TrabajoSolicitados", Me.TrabajoSolicitados)
                db.Ejecutar(strSQL, Data.CommandType.Text)
                Me.IdOrden = Me.GetIdOrden
                Return True
            Else
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                Dim strSQL As String = "Udate OrdenTrabajo Set Serie = @Serie, Identificacion = @Identificacion, Nombre = @Nombre, Telefono = @Telefono, Direccion = @Direccion, Correo = @Correo, Estado = @EStado, Observaciones = @Observaciones, TrabajoSolicitados = @TrabajoSolicitados Where IdOrden = @IdOrden"
                db.AddParametro("@IdOrden", Me.IdOrden)
                db.AddParametro("@IdUsuario", Me.IdUsuario)
                db.AddParametro("@FechaIngreso", Me.FechaIngreso)
                db.AddParametro("@Serie", Me.Serie)
                db.AddParametro("@Identificacion", Me.Identificacion)
                db.AddParametro("@Nombre", Me.Nombre)
                db.AddParametro("@Telefono", Me.Telefono)
                db.AddParametro("@Direccion", Me.Direccion)
                db.AddParametro("@Correo", Me.Correo)
                db.AddParametro("@Estado", Me.Estado)
                db.AddParametro("@Observaciones", Me.Observaciones)
                db.AddParametro("@TrabajoSolicitados", Me.TrabajoSolicitados)
                db.Ejecutar(strSQL, Data.CommandType.Text)
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function CambiarEstado(_IdOrden As Integer, _Estado As String) As Boolean
        Try
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            Dim strSQL As String = "Udate OrdenTrabajo Set Estado = @Estado Where IdOrden = @IdOrden"
            db.AddParametro("@IdOrden", _IdOrden)
            db.AddParametro("@Estado", _Estado)
            db.Ejecutar(strSQL, Data.CommandType.Text)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function AllOrdendeTrabajo(_Texto As String) As DataTable
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        Dim strSQL As String = "Select * from OrdenTrabajo Where Serie like '%" & _Texto & "%' or Nombre like '%" & _Texto & "%'"
        Return db.Ejecutar(strSQL, Data.CommandType.Text)
    End Function

End Class
