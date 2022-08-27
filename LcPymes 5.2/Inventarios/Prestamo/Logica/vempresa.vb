Namespace Prestamos
    Public Class vempresa
        Dim id, descripcion As String

        Public Property gid
            Get
                Return id
            End Get
            Set(ByVal value)
                id = value
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

        Public Sub New(ByVal id As String, ByVal descripcion As String)
            gid = id
            gdescripcion = descripcion
        End Sub
        Public Sub New()

        End Sub
    End Class

End Namespace
