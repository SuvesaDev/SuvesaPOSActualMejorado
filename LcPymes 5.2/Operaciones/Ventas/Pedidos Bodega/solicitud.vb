Imports System.Windows.Forms

Namespace OBSoluciones
    Namespace Inventario
        Public Class Solicitud
            Public IdSolicitud As Long
            Public Fecha As Date
            Public descripcion As String
            Public Anulado As Boolean
            Public Id_UsuarioCreo As String
            Public Event Guardado(_Id As Long)
            Public Event TraladoAnulado(_Id As Long)
            Public Event setError(_msg As String)

            Sub New()
                Me.IdSolicitud = 0
                Me.Fecha = Date.Now
                Me.descripcion = ""
                Me.Anulado = False
                Me.Id_UsuarioCreo = ""
            End Sub

            Public Function Guardar(_View As DataGridView) As Boolean
                Dim resultado As Boolean = False
                Dim trans As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
                Try
                    trans.AddParametrosSalidaInt("@IdSolicitud", Me.IdSolicitud)
                    trans.SetParametro("@Fecha", Me.Fecha)
                    trans.SetParametro("@Observaciones", Me.descripcion)
                    trans.SetParametro("@Anulado", Me.Anulado)
                    trans.SetParametro("@Id_UsuarioCreo", Me.Id_UsuarioCreo)
                    trans.Ejecutar("Guardar_Solicitud", Me.IdSolicitud, 0)

                    For Each fila As DataGridViewRow In _View.Rows
                        trans.SetParametro("@idsolicituddetalle", 0)
                        trans.SetParametro("@idsolicitud", Me.IdSolicitud)
                        trans.SetParametro("@Codigo", fila.Cells("codigo").Value)
                        trans.SetParametro("@cod_articulo", fila.Cells("cod_articulo").Value)
                        trans.SetParametro("@Descripcion", fila.Cells("descripcion").Value)
                        trans.SetParametro("@Cantidad", fila.Cells("cantidad").Value)
                        trans.SetParametro("@Nota", fila.Cells("cnota").Value)
                        trans.Ejecutar("Guardar_SolicitudDetalle")
                    Next

                    trans.Commit()
                    resultado = True
                    RaiseEvent Guardado(Me.IdSolicitud)
                Catch ex As Exception
                    trans.Rollback()
                    resultado = False
                    RaiseEvent setError(ex.Message)
                End Try
                Return resultado
            End Function

            Public Sub Anular(_IdSolicitud As Long)
                Dim db As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
                Try
                    db.SetParametro("@IdSolicitud", _IdSolicitud)
                    db.Ejecutar("Anular_TrasladoPuntoVenta")
                    db.Commit()
                    RaiseEvent TraladoAnulado(_IdSolicitud)
                Catch ex As Exception
                    db.Rollback()
                    RaiseEvent setError(ex.Message)
                End Try
            End Sub

        End Class
    End Namespace
End Namespace
