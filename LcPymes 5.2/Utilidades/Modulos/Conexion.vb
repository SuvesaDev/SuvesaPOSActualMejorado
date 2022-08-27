Imports System.Data.SqlClient
Imports System.Data
Public Class Conexion
    Public sQlconexion As New SqlConnection
    Public SQLStringConexion As String

    Public Function ConectarUnicoParaDevoluciones(Optional ByVal Modulo As String = "SeePOS") As SqlConnection
        'Dim strConexion As String
        If sQlconexion.State <> ConnectionState.Open Then
            SQLStringConexion = GetSetting("SeeSOFT", Modulo, "Conexion")
            sQlconexion.ConnectionString = SQLStringConexion.ToLower
            sQlconexion.ConnectionString = sQlconexion.ConnectionString.Replace("taller", "seepos")
            If sQlconexion.ConnectionString <> "" Then sQlconexion.Open()
        Else
        End If
        Return sQlconexion
    End Function

    Public Function Conectar(Optional ByVal Modulo As String = "SeePOS") As SqlConnection
        'Dim strConexion As String
        If sQlconexion.State <> ConnectionState.Open Then
            SQLStringConexion = GetSetting("SeeSOFT", Modulo, "Conexion")
            sQlconexion.ConnectionString = SQLStringConexion
            If sQlconexion.ConnectionString <> "" Then sQlconexion.Open()
        Else
        End If
        Return sQlconexion
    End Function
    Public Function desconectado()
        Try
            If sQlconexion.State = ConnectionState.Open Then
                sQlconexion.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Sub DesConectar(ByRef sqlConexion As SqlConnection)
        sqlConexion.Close()
        sqlConexion.Dispose()
    End Sub

    ' DEVUELVE EL DataReader DE LA CONSULTA
    Public Function GetRecorset(ByRef conexion As SqlConnection, ByVal StrQuery As String) As SqlDataReader
        Dim Command As SqlCommand
        Dim SqlDatos As SqlDataReader
        Dim Mensaje As String
        Try
            Command = New SqlCommand(StrQuery, conexion)
            SqlDatos = Command.ExecuteReader
        Catch ex As Exception
            Mensaje = ex.Message
            MsgBox("Favor Comunicar el siguiente Error a su Empresa Proveedora de Software.:" & vbCrLf & Mensaje, MsgBoxStyle.Critical, "Alerta...")
        Finally
            Command.Dispose()
            Command = Nothing
        End Try
        Return SqlDatos
    End Function

    'DEVUELVE  EL RESULTADO DE LA CONSULTA
    Public Function SlqExecuteScalar(ByRef Conexion As SqlConnection, ByVal StrQuery As String) As String
        Dim Command As SqlCommand
        Dim Dato As String
        Dim Mensaje As String
        Command = New SqlCommand(StrQuery, Conexion)
        Try
            Dato = Command.ExecuteScalar()
        Catch ex As Exception
            Mensaje = ex.Message
            MsgBox("Favor Comunicar el siguiente Error a su Empresa Proveedora de Software.:" & vbCrLf & Mensaje, MsgBoxStyle.Critical, "Alerta...")
        Finally
            Command.Dispose()
            Command = Nothing

        End Try
        Return Dato
    End Function

    Public Function SQLExeScalar(ByVal StrQuery As String, Optional ByVal SubSistema As String = "") As String
        Dim Command As SqlCommand
        Dim Dato As String
        Dim Mensaje As String
        Dim Conexion As SqlConnection
        If SubSistema = "" Then Conexion = Conectar() Else Conexion = Conectar(SubSistema)

        Command = New SqlCommand(StrQuery, Conexion)
        Try
            Dato = Command.ExecuteScalar()
        Catch ex As Exception
            Mensaje = ex.Message
            MsgBox("Saldo no encontrado " & vbCrLf & " Favor Comunicar el siguiente Error a su Empresa Proveedora de Software.:" & vbCrLf & Mensaje, MsgBoxStyle.Critical, "Alerta...")
        Finally
            Command.Dispose()
            Command = Nothing
            Conexion.Close()
            Conexion.Dispose()
        End Try
        Return Dato
    End Function

    Public Function SlqExecute(ByRef conexion As SqlConnection, ByVal strQuery As String) As String
        Dim Command As SqlCommand
        Dim Mensaje As String
        Command = New SqlCommand(strQuery, conexion)
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Mensaje = ex.Message
        Finally
            Command.Dispose()
            Command = Nothing
        End Try
        Return Mensaje
    End Function

    Public Function AddNewRecord(ByRef Table As Object, ByRef Campos As Object, ByRef Datos As Object, Optional ByVal SubSistema As String = "") As String

        Dim Command As SqlCommand
        Dim Mensaje As String
        Dim Conexion As SqlConnection

        If SubSistema = "" Then
            Conexion = Conectar()
        Else
            Conexion = Conectar(SubSistema)
        End If

        Command = New SqlCommand("INSERT INTO " & Table & " (" & Campos & ") VALUES (" & Datos & ")", Conexion)
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Mensaje = ex.Message
        Finally
            Command.Dispose()
            Command = Nothing
            Conexion.Close()
            Conexion.Dispose()

        End Try
        Return Mensaje
    End Function
    '*******************************************************************
    'FUNCION QUE PERMITE LA ACTUALIZACION DE REGISTROS SEGUN DETERMINADA
    '*******************************************************************
    Public Function UpdateRecords(ByRef Table As String, ByRef Datos As String, ByRef Condicion As String, Optional ByVal SubSistema As String = "") As String
        Dim Command As SqlCommand
        Dim Mensaje As String
        Dim Conexion As SqlConnection
        If SubSistema = "" Then Conexion = Conectar() Else Conexion = Conectar(SubSistema)

        If Condicion <> "" Then
            Command = New SqlCommand("UPDATE " & Table & " SET " & Datos & " WHERE " & Condicion, Conexion)
        Else
            Command = New SqlCommand("UPDATE " & Table & " SET " & Datos, Conexion)
        End If
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Mensaje = ex.Message
            MsgBox("Favor Comunicar el siguiente Error a su Empresa Proveedora de Software.:" & vbCrLf & Mensaje, MsgBoxStyle.Critical, "Alerta...")
        Finally
            Command.Dispose()
            Command = Nothing
            Conexion.Close()
            Conexion.Dispose()
        End Try
        Return Mensaje
    End Function
    '*******************************************************************
    'FUNCION DEFINIDA PARA LA ELIMINACION DE UNO O VARIOS REGISTROS 
    '*******************************************************************
    Public Function DeleteRecords(ByRef Table As String, ByRef Condicion As Object, Optional ByVal SubSistema As String = "") As String
        Dim Command As SqlCommand
        Dim Mensaje As String
        Dim Conexion As SqlConnection
        If SubSistema = "" Then Conexion = Conectar() Else Conexion = Conectar(SubSistema)


        If Condicion = "" Then
            Command = New SqlCommand("DELETE FROM " & Table, Conexion)
        Else
            Command = New SqlCommand("DELETE FROM " & Table & " WHERE " & Condicion, Conexion)
        End If
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Mensaje = ex.Message
            MsgBox("Favor Comunicar el siguiente Error a su Empresa Proveedora de Software.:" & vbCrLf & Mensaje, MsgBoxStyle.Critical, "Alerta...")
        Finally
            Command.Dispose()
            Command = Nothing
            Conexion.Close()
            Conexion.Dispose()
        End Try
        Return Mensaje
    End Function

    Public Function FacturaCancelada(ByVal NumFactura As String)

        '¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡
        'ESTE CODIGO FUE ESCRITO DEBIDO A QUE EN UN NEGOCIO NO DABA COMO CANCELADA UNA FACTURA POR LO QUE NO LA QUITABA DE LA LISTA DE 
        'FACTURAS EN EL FORMULARIO DE OPCIONES DE PAGO POR LO QUE CON ESTE LA PONGO COMO CANCELADA LA VENTA.
        'Eligo el id de la venta que debera modificarse
        Dim strquery2 As String = "SELECT id FROM Ventas WHERE Num_Factura = '" & NumFactura & "' AND Tipo = 'CON' AND FacturaCancelado = 0"
        Dim id As String = ""
        Dim strCAncelado As String = ""
        'Asigno el id de la venta
        id = SlqExecuteScalar(Conectar, strquery2)
        'verifico que la variable traiga un id
        If id <> "" Then
            'Creo la instruccion que me ayudara a verificar si esta esta cancelada 
            strquery2 = "SELECT FacturaCancelado FROM Ventas WHERE id = '" & id & "'"
            'Obtengo el valor de la variable FacturaCancelado
            Dim strCancel As String = SlqExecuteScalar(Conectar, strquery2)
            'Si la variable FacturaCancelado es False debera esta pasarse a True
            If strCancel = "False" Then
                'Instruccion que actualizara el valor de FacturaCancelado y lo pondra en true
                strquery2 = "Update Ventas set FacturaCancelado = 1 WHERE id = '" & id & "'"
                'Llevo a cabo la actualizacion
                Dim mensa As String = SlqExecute(Conectar, strquery2)
            End If
        End If
        '¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡

    End Function

End Class