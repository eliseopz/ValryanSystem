Public Class Producto
    Dim _idProducto As Integer
    Dim _nombreProducto As String
    Dim _precioProducto As Double
    Dim _unidadesProducto As Integer
    Dim _unidadMedidaProducto As String
    Dim _descripcionProducto As String
    Dim _idCategoria As String

    Public Sub New()

    End Sub

    Public Sub New(idProducto As Integer, nombreProducto As String, precioProducto As Double, unidadesProducto As Integer, unidadMedidaProducto As String, descripcionProducto As String, idCategoria As Integer)
        _idCategoria = idProducto
        _nombreProducto = nombreProducto
        _precioProducto = precioProducto
        _unidadesProducto = unidadesProducto
        _unidadMedidaProducto = unidadMedidaProducto
        _descripcionProducto = descripcionProducto
        _idCategoria = idCategoria
    End Sub

    Public Property IdProducto As Integer
        Get
            Return _idProducto
        End Get
        Set(value As Integer)
            _idProducto = value
        End Set
    End Property

    Public Property NombreProducto As String
        Get
            Return _nombreProducto
        End Get
        Set(value As String)
            _nombreProducto = value
        End Set
    End Property

    Public Property PrecioProducto As Double
        Get
            Return _precioProducto
        End Get
        Set(value As Double)
            _precioProducto = value

        End Set
    End Property

    Public Property UnidadesProducto As Integer
        Get
            Return _unidadesProducto
        End Get
        Set(value As Integer)
            _unidadesProducto = value
        End Set
    End Property

    Public Property UnidadMedidaProducto As String
        Get
            Return _unidadMedidaProducto
        End Get
        Set(value As String)
            _unidadMedidaProducto = value
        End Set
    End Property

    Public Property DescripcionProducto As String
        Get
            Return _descripcionProducto
        End Get
        Set(value As String)
            _descripcionProducto = value
        End Set
    End Property

    Public Property IdCategoria As Integer
        Get
            Return _idCategoria
        End Get
        Set(value As Integer)
            _idCategoria = value
        End Set
    End Property
End Class
