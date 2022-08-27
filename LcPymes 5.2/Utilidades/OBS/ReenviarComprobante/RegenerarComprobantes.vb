Imports LcPymes_5._2.OBSoluciones.SQL.Transaccion
Imports System.Data

Namespace OBSoluciones
    Namespace Utilidades
        Public Class RegenerarComprobantes

            Private TipoComprobante As TipoComprobante
            Private IdComprobante As String = ""
            Private NumCaja As String = ""
            Private CadenaConexion As String = CadenaConexionSeePOS
            Private Trans As SQL.Transaccion
            Public Event SetError(_msg As String)
            Public Event SetEcho()

            Public Sub New(_Tipo As TipoComprobante, _Id As String, _Caja As String)
                Me.TipoComprobante = _Tipo
                Me.IdComprobante = _Id
                Me.NumCaja = _Caja
            End Sub

            Public Sub Regenerar(_IdUsuarioEncargado As String, _NotaDevolucion As String)
                Select Case Me.TipoComprobante
                    Case OBSoluciones.TipoComprobante.Factura
                        Me.ReenviarFactura(_IdUsuarioEncargado, _NotaDevolucion)
                    Case OBSoluciones.TipoComprobante.NotaCredito
                        Me.ReenviarNotaCredito()
                End Select
            End Sub

            Private Sub ReenviarFactura(_IdUsuarioEncargado As String, _NotaDevolucion As String)
                Try
                    Me.Trans = New SQL.Transaccion(Me.CadenaConexion)
                    'Registra Nota de Credito para anular el documento
                    Me.GenerarNotaCredito_Factura(_IdUsuarioEncargado, _NotaDevolucion)
                    'Vuelve a generar el docuento
                    Me.RegenerarFactura()
                    Me.Trans.Commit()
                Catch ex As Exception
                    Me.Trans.Rollback()
                End Try
            End Sub

            Public Function NotaCredito(_IdUsuarioEncargado As String, _NotasDevolucion As String) As String
                Try
                    Me.Trans = New SQL.Transaccion(Me.CadenaConexion)
                    'Registra Nota de Credito para anular el documento
                    Dim Devolucion As String = Me.GenerarNotaCredito_Factura(_IdUsuarioEncargado, _NotasDevolucion)
                    Me.Trans.Commit()
                    Return Devolucion
                Catch ex As Exception
                    Me.Trans.Rollback()
                End Try
                Return "0"
            End Function
            '140077-9
            Private Function GenerarNotaCredito_Factura(_UsuarioEncargado As String, _NotasDevolucion As String) As String
                'llama procedimieto almacenado que genera la nota de credito
                Dim dev As Long = 0
                Dim dt As New DataTable
                Me.Trans.SetParametro("@Id", Me.IdComprobante)
                Me.Trans.SetParametro("@NumCaja", Me.NumCaja)
                Me.Trans.SetParametro("@IdUsuarioEncargado", _UsuarioEncargado)
                Me.Trans.SetParametro("@NotaDevolucion", _NotasDevolucion)
                Me.Trans.AddParametrosSalidaInt("@Dev", dev)
                Me.Trans.Ejecutar("Genera_NotaCredito", dev, 4)
                Return dev
            End Function

            Private Function RegenerarFactura() As Boolean
                'llama procedimiento almacenado que regenera factura
                'Me.Trans.SetParametro("@Id", Me.IdComprobante)
                'Me.Trans.SetParametro("@NumCaja", Me.NumCaja)
                'Me.Trans.Ejecutar("")
            End Function

            Private Sub ReenviarNotaCredito()
                Try
                    Me.Trans = New SQL.Transaccion(Me.CadenaConexion)
                    'Registra nota de debito para anular el documento
                    Me.GeneraNotaDebito_NotaCredito()
                    'Vuelve a generar el documento
                    Me.RegeneraNotaCredito()
                    Me.Trans.Commit()
                Catch ex As Exception
                    Me.Trans.Rollback()
                End Try
            End Sub

            Private Function GeneraNotaDebito_NotaCredito() As Boolean
                'llama procedimieto almacenado que genera la nota de debito
                'Me.Trans.SetParametro("", "")
                'Me.Trans.Ejecutar("")
            End Function

            Private Function RegeneraNotaCredito() As Boolean
                'llama procedimiento almacenado que regenera la nota de credito
                'Me.Trans.SetParametro("", "")
                'Me.Trans.Ejecutar("")
            End Function

        End Class
    End Namespace

    Public Enum TipoComprobante
        Factura
        NotaCredito
    End Enum

End Namespace
