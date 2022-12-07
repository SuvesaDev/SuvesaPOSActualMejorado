Imports System.Data

Namespace OBSoluciones

    Public Class Detalle_Prestamo
        Public Property ID As Long
        Public Property ID_Prestamo As Long
        Public Property Codigo As Long
        Public Property CodigoPrestamo As Long
        Public Property Descripcion As String
        Public Property Cantidad As Decimal
        Public Property Precio As Decimal
        Public Property Entregado As Boolean
        Public Property Devuelto As Decimal
        Public Property CantidadAceptada As Decimal

        Sub New(_ID As Long, _ID_Prestamo As Long, _Codigo As Long, _CodigoPrestamo As Long, _Descripcion As String, _Cantidad As Decimal, _Precio As Decimal, _Entregado As Boolean, _Devuelto As Decimal, _CantidadAceptada As Decimal)
            Me.ID = _ID
            Me.ID_Prestamo = _ID_Prestamo
            Me.Codigo = _Codigo
            Me.CodigoPrestamo = _CodigoPrestamo
            Me.Descripcion = _Descripcion
            Me.Cantidad = _Cantidad
            Me.Precio = _Precio
            Me.Entregado = _Entregado
            Me.Devuelto = _Devuelto
            Me.CantidadAceptada = _CantidadAceptada
        End Sub

    End Class
    Public Class Prestamo

        Public Property ID As Long
        Public Property IDReferencia As Long
        Public Property Fecha As Date
        Public Property Estado As Boolean
        Public Property Anulado As Boolean
        Public Property Entrada As Boolean
        Public Property Salida As Boolean
        Public Property Observacion As String
        Public Property Nombre_Destino As String
        Public Property Boleta As String
        Public Property Destinatario As Long
        Public Property Nombre_Destinatario As String
        Public Property Destino As Long
        Public Property Transportista As String
        Public Property Id_UsuarioCreo As String
        Public Property UsuariCreo As String
        Public Property BoletaProveedor As String
        Public Property Aceptado As Boolean
        Public Property Rechazado As Boolean
        Public Property Aplicado As Boolean
        Public Property CedulaEmisor As String
        Public Property CedulaReceptor As String
        Private vDetalle_Prestamo As New System.Collections.Generic.List(Of Detalle_Prestamo)
        Public ReadOnly Property Detalle_Prestamo As System.Collections.Generic.List(Of Detalle_Prestamo)
            Get
                Return Me.vDetalle_Prestamo
            End Get
        End Property
        Public Function GetEstado() As Integer
            Return IIf(Me.Estado = True, 1, 0)
        End Function

        Public Function GetAnulado() As Integer
            Return IIf(Me.Anulado = True, 1, 0)
        End Function

        Public Function GetEntrada() As Integer
            Return IIf(Me.Entrada = True, 1, 0)
        End Function

        Public Function GetSalida() As Integer
            Return IIf(Me.Salida = True, 1, 0)
        End Function

        Public Function GetAceptado() As Integer
            Return IIf(Me.Aceptado = True, 1, 0)
        End Function

        Public Function GetRechazado() As Integer
            Return IIf(Me.Rechazado = True, 1, 0)
        End Function

        Public Function GetAplicado() As Integer
            Return IIf(Me.Aplicado = True, 1, 0)
        End Function

        Public Function ObtenerIdEmpresa(_Cedula As String) As Integer
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select Id from empresa where Cedula = '" & _Cedula & "'", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item("Id")
            Else
                Return 0
            End If
        End Function

        Private Sub Limpiar()
            Me.ID = 0
            Me.IDReferencia = 0
            Me.Fecha = Date.Now
            Me.Estado = False
            Me.Anulado = False
            Me.Entrada = False
            Me.Salida = False
            Me.Observacion = ""
            Me.Nombre_Destino = ""
            Me.Boleta = ""
            Me.Destinatario = 0
            Me.Nombre_Destinatario = ""
            Me.Destino = 0
            Me.Transportista = ""
            Me.Id_UsuarioCreo = ""
            Me.BoletaProveedor = ""
            Me.Aceptado = False
            Me.Rechazado = False
            Me.Aplicado = False
            Me.CedulaEmisor = ""
            Me.CedulaReceptor = ""
        End Sub

        Public Sub PrepararSolicitud(_ID As String)
            If CDec(_ID) > 0 Then
                Me.Limpiar()
                Dim dtSPrestamo As New DataTable
                Dim dtSDetalle_prestamo As New DataTable

                cFunciones.Llenar_Tabla_Generico("Select p.*, u.Nombre as UsuarioCreo, r.Cedula as CedulaReceptor, e.Cedula as CedulaEmisor From sprestamo p inner join Usuarios u on p.Id_UsuariCreo = u.Id_Usuario inner join empresa r on r.id = p.destino inner join empresa e on e.id = p.destinatario Where p.ID = " & _ID, dtSPrestamo, CadenaConexionSeePOS)
                cFunciones.Llenar_Tabla_Generico("Select d.*, i.CodigoPrestamo From sdetalle_prestamo d inner join Inventario i on d.codigo = i.Codigo Where d.ID_Prestamo = " & _ID, dtSDetalle_prestamo, CadenaConexionSeePOS)

                Me.ID = 0
                Me.IDReferencia = dtSPrestamo.Rows(0).Item("ID")
                Me.Fecha = dtSPrestamo.Rows(0).Item("Fecha")
                Me.Estado = dtSPrestamo.Rows(0).Item("Estado")
                Me.Anulado = dtSPrestamo.Rows(0).Item("Anulado")
                Me.Entrada = dtSPrestamo.Rows(0).Item("Entrada")
                Me.Salida = dtSPrestamo.Rows(0).Item("Salida")
                Me.Observacion = dtSPrestamo.Rows(0).Item("Observacion")
                Me.Nombre_Destino = dtSPrestamo.Rows(0).Item("Nombre_Destino")
                Me.Boleta = dtSPrestamo.Rows(0).Item("Boleta")
                Me.Destinatario = dtSPrestamo.Rows(0).Item("Destinatario")
                Me.Nombre_Destinatario = dtSPrestamo.Rows(0).Item("Nombre_Destinatario")
                Me.Destino = dtSPrestamo.Rows(0).Item("Destino")
                Me.Transportista = dtSPrestamo.Rows(0).Item("Transportista")
                Me.Id_UsuarioCreo = dtSPrestamo.Rows(0).Item("Id_UsuariCreo")
                Me.BoletaProveedor = dtSPrestamo.Rows(0).Item("BoletaProveedor")
                Me.UsuariCreo = dtSPrestamo.Rows(0).Item("UsuarioCreo")
                Me.CedulaReceptor = dtSPrestamo.Rows(0).Item("CedulaReceptor")
                Me.CedulaEmisor = dtSPrestamo.Rows(0).Item("CedulaEmisor")
                Me.Aceptado = False
                Me.Rechazado = False
                Me.Aplicado = False

                For Each r As DataRow In dtSDetalle_prestamo.Rows
                    Me.vDetalle_Prestamo.Add(New Detalle_Prestamo(r.Item("ID"), r.Item("ID_Prestamo"), r.Item("Codigo"), r.Item("CodigoPrestamo"), r.Item("Descripcion"), r.Item("Cantidad"), r.Item("Precio"), r.Item("Entregado"), r.Item("Devuelto"), 0))
                Next

            End If
        End Sub

        Private Function GetEmpresa() As String
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select Identificacion from seguridad.dbo.emisor", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item("Identificacion")
            Else
                Return "0"
            End If
        End Function

        Public Sub MostrarSolicitud(_Id As Long)
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

            Dim dtPrestamo As New DataTable
            Dim dtDetalle As New DataTable
            'dtPrestamo = db.Ejecutar("SELECT * FROM prestamo p WHERE p.ID = " & _Id, CommandType.Text)
            'dtDetalle = db.Ejecutar("SELECT dp.ID, dp.ID_prestamo, dp.codigo, p." & CodigoEmpresa & " AS CodigoPrestamo, dp.descripcion, dp.cantidad, dp.precio, dp.entregado, dp.devuelto, dp.cantidadAceptada FROM detalle_prestamo dp INNER JOIN producto p ON dp.codigo = p.Codigo WHERE dp.ID_prestamo = " & _Id, CommandType.Text)

            Me.ID = _Id
            Me.IDReferencia = dtPrestamo.Rows(0).Item("IDReferencia")
            Me.Boleta = dtPrestamo.Rows(0).Item("Boleta")
            Me.Fecha = dtPrestamo.Rows(0).Item("Fecha")
            Me.Estado = dtPrestamo.Rows(0).Item("Estado")
            Me.Anulado = dtPrestamo.Rows(0).Item("Anulado")
            Me.Entrada = IIf(CBool(dtPrestamo.Rows(0).Item("Entrada")) = True, False, True)
            Me.Salida = IIf(CBool(dtPrestamo.Rows(0).Item("Salida")) = True, False, True)
            Me.Observacion = dtPrestamo.Rows(0).Item("Observacion")

            Me.CedulaEmisor = dtPrestamo.Rows(0).Item("Destino")
            Me.CedulaReceptor = dtPrestamo.Rows(0).Item("Destinatario")

            Me.Destinatario = Me.ObtenerIdEmpresa(CedulaEmisor) 'Destinatario
            Me.Destino = Me.ObtenerIdEmpresa(CedulaReceptor) 'Destino

            Me.Nombre_Destinatario = dtPrestamo.Rows(0).Item("Nombre_Destino") 'Nombre_Destinatario
            Me.Nombre_Destino = dtPrestamo.Rows(0).Item("Nombre_Destinatario") 'Nombre_Destino

            Me.Transportista = ""
            Me.Id_UsuarioCreo = "" 'Id_UsuariCreo
            Me.BoletaProveedor = dtPrestamo.Rows(0).Item("BoletaProveedor")
            Me.Aceptado = dtPrestamo.Rows(0).Item("Aceptado")
            Me.Rechazado = dtPrestamo.Rows(0).Item("Rechazado")
            Me.Aplicado = dtPrestamo.Rows(0).Item("Aplicado")


            For Each r As DataRow In dtDetalle.Rows
                Me.vDetalle_Prestamo.Add(New Detalle_Prestamo(r.Item("ID"), r.Item("ID_Prestamo"), r.Item("Codigo"), r.Item("CodigoPrestamo"), r.Item("Descripcion"), r.Item("Cantidad"), r.Item("Precio"), r.Item("Entregado"), r.Item("Devuelto"), 0))
            Next

        End Sub

    End Class
    Public Class LogisticaPrestamo

        Private Function ObtenerCodigo() As Long
            Dim dt As DataTable
            dt = db.Ejecutar("SELECT ifnull(MAX(ID),0) + 1 AS ID FROM prestamo", CommandType.Text)
            Return CLng(dt.Rows(0).Item("ID"))
        End Function

        ''' <summary>
        ''' envia una solicitud de prestamo de SQL a MySQL
        ''' </summary>
        ''' <param name="_Id">Clave primaria del prestamo</param>
        ''' <remarks></remarks>
        Public Sub EnviarSolicitud(_Id As String)
            Dim solicitud As New Prestamo
            solicitud.PrepararSolicitud(_Id)

            Dim ID As Long = Me.ObtenerCodigo
            Dim Trans As New OBSoluciones.MySql.Transaccion(CadenaConexionMySQL)
            Try
                Trans.Ejecutar("INSERT INTO Prestamo VALUES(" & ID & ", " & solicitud.IDReferencia & ", STR_TO_DATE('" & solicitud.Fecha.ToString("MM-dd-yyyy") & "','%m-%d-%Y'), " & solicitud.GetEstado & ", " & solicitud.GetAnulado & ", " & solicitud.GetEntrada & ", " & solicitud.GetSalida & ", '" & solicitud.Observacion & "', '" & solicitud.Nombre_Destino & "', '" & solicitud.Boleta & "', " & solicitud.CedulaEmisor & ", '" & solicitud.Nombre_Destinatario & "', " & solicitud.CedulaReceptor & ", '" & solicitud.Transportista & "', '" & solicitud.Id_UsuarioCreo & "', '" & solicitud.UsuariCreo & "', '" & solicitud.BoletaProveedor & "', 0, 0, 0);", CommandType.Text)
                For Each r As Detalle_Prestamo In solicitud.Detalle_Prestamo
                    Trans.Ejecutar("INSERT INTO Detalle_prestamo VALUES(NULL, " & ID & ", " & r.CodigoPrestamo & ", '" & r.Descripcion & "', " & r.Cantidad & ", " & r.Precio & ", 0,0,0);", CommandType.Text)
                Next
                Trans.Commit()
            Catch ex As Exception
                Trans.Rollback()
            End Try

        End Sub

        Public Function MostrarSolicitudesPendientes(_Cedula As String) As DataTable
            Dim dt As New DataTable
            dt = db.Ejecutar("SELECT p.ID, p.IDReferencia, p.Fecha, p.Nombre_Destino AS EmpresaSolicito, p.UsuariCreo AS UsuarioSolicito FROM prestamo p WHERE p.Entrada = 1 AND p.Aceptado = 0 AND p.Rechazado = 0 AND p.Destino = '" & _Cedula & "'", CommandType.Text)
            Return dt
        End Function

        Public Function MostrarPrestamosxRecibir(_Cedula As String) As DataTable
            Dim dt As New DataTable
            dt = db.Ejecutar("SELECT p.ID, p.IDReferencia, p.Fecha, p.Nombre_Destinatario AS EmpresaAcepto, p.UsuariCreo AS UsuarioSolicito FROM prestamo p WHERE p.Entrada = 1 AND p.Aceptado = 1 AND p.Rechazado = 0 AND p.Destinatario = '" & _Cedula & "'", CommandType.Text)
            Return dt
        End Function

        Public Function MostrarSolicitud(_Id As Long) As Prestamo
            Dim dt As New DataTable

            Dim Solicitud As New Prestamo
            Solicitud.MostrarSolicitud(_Id)

            Return Solicitud
        End Function

    End Class
    Module General

        Private Function GetServer() As String
            Dim Server As String = GetSetting("SeeSOFT", "MySQL", "Server")
            If Server = "" Then
                Server = "185.224.138.70"
                SaveSetting("SeeSOFT", "MySQL", "Server", Server)
            End If
            Return Server
        End Function

        Private Function GetDatabase() As String
            Dim Database As String = GetSetting("SeeSOFT", "MySQL", "Database")
            If Database = "" Then
                Database = "u879264965_suvesa"
                SaveSetting("SeeSOFT", "MySQL", "Database", Database)
            End If
            Return Database
        End Function

        Private Function GetUid() As String
            Dim Uid As String = GetSetting("SeeSOFT", "MySQL", "Uid")
            If Uid = "" Then
                Uid = "u879264965_suvesa"
                SaveSetting("SeeSOFT", "MySQL", "Uid", Uid)
            End If
            Return Uid
        End Function

        Private Function GetPwd() As String
            Dim Pwd As String = GetSetting("SeeSOFT", "MySQL", "Pwd")
            If Pwd = "" Then
                Pwd = "suvesa"
                SaveSetting("SeeSOFT", "MySQL", "Pwd", Pwd)
            End If
            Return Pwd
        End Function

        Public ReadOnly Property CadenaConexionMySQL As String
            Get
                Dim Uid As String = GetUid()
                Dim Pwd As String = GetPwd()
                Dim Servidor As String = GetServer()
                Dim DataBase As String = GetDatabase()
                '                       Server=localhost;Port=3306;Database=jeanca;Uid=root;Pwd=14121988
                Dim cadena As String = "Server=" & Servidor & ";Port=3306;Database=" & DataBase & ";Uid=" & Uid & ";Pwd=" & Pwd & ""
                Return cadena
            End Get
        End Property

        Public Property db As New MySql.Sentencias(CadenaConexionMySQL)


    End Module



End Namespace

