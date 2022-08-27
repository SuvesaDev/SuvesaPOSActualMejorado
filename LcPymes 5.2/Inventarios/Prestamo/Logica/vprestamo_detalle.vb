Namespace Prestamos
    Public Class vprestamo_detalle
        Dim id, id_prestamo, codigo, descripcion As String
        Dim cantidad, precio, devueltos As Double
        Dim entregado As Boolean
        Public Property gid
            Get
                Return id
            End Get
            Set(ByVal value)
                id = value
            End Set
        End Property
        Public Property gid_prestamo
            Get
                Return id_prestamo
            End Get
            Set(ByVal value)
                id_prestamo = value
            End Set
        End Property
        Public Property gcodigo
            Get
                Return codigo
            End Get
            Set(ByVal value)
                codigo = value
            End Set
        End Property
        Public Property gdescripcion
            Get
                Return descripcion
            End Get
            Set(ByVal value)
                descripcion = value
            End Set
        End Property
        Public Property gcantidad
            Get
                Return cantidad
            End Get
            Set(ByVal value)
                cantidad = value
            End Set
        End Property
        Public Property gprecio
            Get
                Return precio
            End Get
            Set(ByVal value)
                precio = value
            End Set
        End Property
        Public Property gentregado
            Get
                Return entregado
            End Get
            Set(ByVal value)
                entregado = value
            End Set
        End Property
        Public Property gdevuelto
            Get
                Return devueltos
            End Get
            Set(ByVal value)
                devueltos = value
            End Set
        End Property
        Public Sub New(ByVal entregado As Boolean, ByVal precio As Double, ByVal id As String, ByVal id_prestamo As String, ByVal codigo As String, ByVal descripcion As String, ByVal cantidad As Double, ByVal devueltos As Double)
            gid = id
            gid_prestamo = id_prestamo
            gcodigo = codigo
            gdescripcion = descripcion
            gcantidad = cantidad
            gprecio = precio
            gentregado = entregado
            gdevuelto = devueltos
        End Sub
        Public Sub New()

        End Sub
    End Class

End Namespace
