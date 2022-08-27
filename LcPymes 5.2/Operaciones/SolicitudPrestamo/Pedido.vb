Namespace OBSoluciones
    Public Class Pedido
        Private Property Trans As MySql.Transaccion
        Public Property IdPedido As Integer
        Public Property CedulaEmisor As String
        Public Property CedulaReceptor As String
        Public Property UsuarioEmisor As String
        Public Property UsuarioReceptor As String
        Public Property Fecha As Date
        Public Property Observaciones As String

        Public Function GuardarPedido(_viewDetalle As DataGridView) As Boolean
            Trans = New MySql.Transaccion(CadenaConexionMySQL)
            Try
                Trans.ParametroSalida("pIdPedido", Me.IdPedido)
                Trans.ParametroEntrada("pCedulaEmisor", Me.CedulaEmisor)
                Trans.ParametroEntrada("pCedulaReceptor", Me.CedulaReceptor)
                Trans.ParametroEntrada("pUsuarioEmisor", Me.UsuarioEmisor)
                Trans.ParametroEntrada("pUsuarioReceptor", Me.UsuarioReceptor)
                Trans.ParametroEntrada("pFecha", Me.Fecha)
                Trans.ParametroEntrada("pObservaciones", Me.Observaciones)
                Trans.Ejecutar("GuardarPedido", Me.IdPedido, 0)
                For Each row As DataGridViewRow In _viewDetalle.Rows
                    Trans.ParametroEntrada("pIdPedidoDetalle", row.Cells("cIdPedidoDetalle").Value)
                    Trans.ParametroEntrada("pIdPedido", Me.IdPedido)
                    Trans.ParametroEntrada("pCodigo", row.Cells("cCodigo").Value)
                    Trans.ParametroEntrada("pDescripcion", row.Cells("cDescripcion").Value)
                    Trans.ParametroEntrada("pCantidad", row.Cells("cCantidad").Value)
                    Trans.Ejecutar("GuardarPedidoDetalle")
                Next
                Trans.Commit()
                Return True
            Catch ex As Exception
                Trans.Rollback()
                Return False
            End Try
        End Function

    End Class

End Namespace
