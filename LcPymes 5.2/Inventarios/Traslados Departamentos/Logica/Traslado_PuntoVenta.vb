Imports System.Windows.Forms

Namespace OBSoluciones
    Namespace Inventario
        Public Class Traslado_PuntoVenta
            Public Id As Long
            Public Fecha As Date
            Public Id_PuntoVentaOrigen As Integer
            Public Id_PuntoVentaDestino As Integer
            Public Observaciones As String
            Public Anulado As Boolean
            Public Id_UsuarioCreo As String
            Public Event Guardado(_Id As Long)
            Public Event TraladoAnulado(_Id As Long)
            Public Event setError(_msg As String)

            Sub New()
                Me.Id = 0
                Me.Fecha = Date.Now
                Me.Id_PuntoVentaOrigen = 0
                Me.Id_PuntoVentaDestino = 0
                Me.Observaciones = ""
                Me.Anulado = False
                Me.Id_UsuarioCreo = ""
            End Sub

            Public Function Guardar(_View As DataGridView) As Boolean
                Dim resultado As Boolean = False
                Dim trans As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
                Try
                    trans.AddParametrosSalidaInt("@Id", Me.Id)
                    trans.SetParametro("@Fecha", Me.Fecha)
                    trans.SetParametro("@Id_PuntoVentaOrigen", Me.Id_PuntoVentaOrigen)
                    trans.SetParametro("@Id_PuentoVentaDestino", Me.Id_PuntoVentaDestino)
                    trans.SetParametro("@Observaciones", Me.Observaciones)
                    trans.SetParametro("@Anulado", Me.Anulado)
                    trans.SetParametro("@Id_UsuarioCreo", Me.Id_UsuarioCreo)
                    trans.Ejecutar("Guardar_TrasladoPuntoVenta", Me.Id, 0)

                    For Each fila As DataGridViewRow In _View.Rows
                        trans.SetParametro("@Id", 0)
                        trans.SetParametro("@Id_TrasladoPuntoVenta", Me.Id)
                        trans.SetParametro("@Codigo", fila.Cells("codigo").Value)
                        trans.SetParametro("@Descripcion   ", fila.Cells("descripcion").Value)
                        trans.SetParametro("@Cantidad", fila.Cells("cantidad").Value)
                        trans.Ejecutar("Guardar_TrasladoPuntoVenta_Detalle")
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
                    db.Ejecutar("Anular_TrasladoPuntoVenta")
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
