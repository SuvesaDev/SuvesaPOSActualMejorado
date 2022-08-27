Imports System.Windows.Forms
Namespace OBSoluciones
    Namespace Inventario
        Public Class PreTomaProveedor
            Public Id As Long
            Public Id_UsuarioCreo As String
            Public CodigoProv As Integer
            Public Fecha As Date
            Public Anulado As Boolean
            Public Usado As Boolean

            Public Event Guardado(_Id As Long)
            Public Event TraladoAnulado(_Id As Long)
            Public Event setError(_msg As String)

            Sub New()
                Me.Id = 0
                Me.Id_UsuarioCreo = ""
                Me.CodigoProv = 0
                Me.Fecha = Date.Now
                Me.Anulado = False
                Me.Usado = False
            End Sub

            Public Function Guardar(_View As DataGridView) As Boolean
                Dim resultado As Boolean = False
                Dim trans As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
                Try
                    trans.AddParametrosSalidaInt("@Id", Me.Id)
                    trans.SetParametro("@Id_UsuarioCreo", Me.Id_UsuarioCreo)
                    trans.SetParametro("@CodigoProv", Me.CodigoProv)
                    trans.SetParametro("@Fecha", Me.Fecha)
                    trans.SetParametro("@Anulado", Me.Anulado)
                    trans.SetParametro("@Usado", Me.Usado)
                    trans.Ejecutar("Guardar_PreTomaProveedor", Me.Id, 0)

                    For Each fila As DataGridViewRow In _View.Rows
                        trans.SetParametro("@Id", fila.Cells("Id").Value)
                        trans.SetParametro("@Id_PreTomaProveedor", Me.Id)
                        trans.SetParametro("@Codigo", fila.Cells("codigo").Value)
                        trans.SetParametro("@CodArticulo", fila.Cells("cCodigo").Value)
                        trans.SetParametro("@Descripcion   ", fila.Cells("descripcion").Value)
                        trans.SetParametro("@Cantidad", fila.Cells("cantidad").Value)
                        trans.Ejecutar("Guardar_PreTomaProveedorDetalle")
                    Next

                    trans.Commit()
                    resultado = True
                    RaiseEvent Guardado(Me.Id)
                Catch ex As Exception
                    trans.Rollback()
                    resultado = False
                    RaiseEvent setError(ex.Message)
                End Try
                Return resultado
            End Function

            Public Sub Anular(_Id As Long)
                Dim db As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
                Try
                    db.SetParametro("@Id", _Id)
                    db.Ejecutar("Anular_PreTomaProveedor")
                    db.Commit()
                    RaiseEvent TraladoAnulado(_Id)
                Catch ex As Exception
                    db.Rollback()
                    RaiseEvent setError(ex.Message)
                End Try
            End Sub

            Public Sub Usar(_Id As Long)
                Dim db As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
                Try
                    db.SetParametro("@Id", _Id)
                    db.Ejecutar("Usar_PreTomaProveedor")
                    db.Commit()
                    RaiseEvent TraladoAnulado(_Id)
                Catch ex As Exception
                    db.Rollback()
                    RaiseEvent setError(ex.Message)
                End Try
            End Sub

        End Class
        Public Class TomaProveedor
            Public Id As Long
            Public Id_UsuarioCreo As String
            Public CodigoProv As Integer
            Public Fecha As Date
            Public Anulado As Boolean
            Public Aplicado As Boolean

            Public Event Guardado(_Id As Long)
            Public Event setAplicado(_Id As Long)
            Public Event TraladoAnulado(_Id As Long)
            Public Event setError(_msg As String)

            Sub New()
                Me.Id = 0
                Me.Id_UsuarioCreo = ""
                Me.CodigoProv = 0
                Me.Fecha = Date.Now
                Me.Anulado = False
                Me.Aplicado = False
            End Sub

            Public Function Guardar(_View As DataGridView, _Pretoma As System.Collections.Generic.List(Of Integer)) As Boolean
                Dim resultado As Boolean = False
                Dim trans As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
                Try
                    trans.AddParametrosSalidaInt("@Id", Me.Id)
                    trans.SetParametro("@Id_UsuarioCreo", Me.Id_UsuarioCreo)
                    trans.SetParametro("@CodigoProv", Me.CodigoProv)
                    trans.SetParametro("@Fecha", Me.Fecha)
                    trans.SetParametro("@Anulado", Me.Anulado)
                    trans.SetParametro("@Aplicado", Me.Aplicado)
                    trans.Ejecutar("Guardar_TomaProveedor", Me.Id, 0)

                    For Each fila As DataGridViewRow In _View.Rows
                        trans.SetParametro("@Id", fila.Cells("id").Value)
                        trans.SetParametro("@Id_TomaProveedor", Me.Id)
                        trans.SetParametro("@Codigo", fila.Cells("codigo").Value)
                        trans.SetParametro("@CodArticulo", fila.Cells("cCodigo").Value)
                        trans.SetParametro("@Descripcion   ", fila.Cells("descripcion").Value)
                        trans.SetParametro("@Existencia", fila.Cells("existencia").Value)
                        trans.SetParametro("@Toma", fila.Cells("toma").Value)
                        trans.SetParametro("@Diferencia", fila.Cells("cDiferencia").Value)
                        trans.Ejecutar("Guardar_TomaProveedorDetalle")
                    Next

                    For Each fila As Integer In _Pretoma
                        trans.SetParametro("@Id", fila)
                        trans.Ejecutar("Usar_PreTomaProveedor")
                    Next

                    If Aplicado = True Then
                        trans.SetParametro("@Id", Id)
                        trans.Ejecutar("Aplicar_TomaProveedor")
                    End If

                    trans.Commit()
                    resultado = True
                    If Aplicado = True Then
                        RaiseEvent setAplicado(Me.Id)
                    Else
                        RaiseEvent Guardado(Me.Id)
                    End If

                Catch ex As Exception
                    trans.Rollback()
                    resultado = False
                    RaiseEvent setError(ex.Message)
                End Try
                Return resultado
            End Function

            Public Sub Anular(_Id As Long)
                Dim db As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
                Try
                    db.SetParametro("@Id", _Id)
                    db.Ejecutar("Anular_TomaProveedor")
                    db.Commit()
                    RaiseEvent TraladoAnulado(_Id)
                Catch ex As Exception
                    db.Rollback()
                    RaiseEvent setError(ex.Message)
                End Try
            End Sub

        End Class
    End Namespace
End Namespace
