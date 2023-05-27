Public Class Salidas
    Dim _idSalida As Integer
    Dim _unidadesSalida As Integer
    Dim _fechaSalida As String
    Dim _precioSalida As Double
    Dim _observacionesSalida As String
    Dim _idProducto As Integer
    Dim _idUsuario As Integer

    Public Sub New()

    End Sub

    Public Sub New(idSalida As Integer, unidadesSalida As Integer, fechaSalida As String, precioSalida As Double, observacionesSalida As String, idProducto As Integer, idUsuario As Integer)
        _idSalida = idSalida
        _unidadesSalida = unidadesSalida
        _fechaSalida = fechaSalida
        _precioSalida = precioSalida
        _observacionesSalida = observacionesSalida
        _idProducto = idProducto
        _idUsuario = idUsuario
    End Sub

    Public Property IdSalida As Integer
        Get
            Return _idSalida
        End Get
        Set(value As Integer)
            _idSalida = value
        End Set
    End Property

    Public Property UnidadesSalida As Integer
        Get
            Return _unidadesSalida
        End Get
        Set(value As Integer)
            _unidadesSalida = value
        End Set
    End Property

    Public Property FechaSalida As String
        Get
            Return _fechaSalida
        End Get
        Set(value As String)
            _fechaSalida = value
        End Set
    End Property

    Public Property PrecioSalida As Double
        Get
            Return _precioSalida
        End Get
        Set(value As Double)
            _precioSalida = value
        End Set
    End Property

    Public Property ObservacionesSalida As String
        Get
            Return _observacionesSalida
        End Get
        Set(value As String)
            _observacionesSalida = value
        End Set
    End Property

    Public Property IdProducto As Integer
        Get
            Return _idProducto
        End Get
        Set(value As Integer)
            _idProducto = value
        End Set
    End Property

    Public Property IdUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(value As Integer)
            _idUsuario = value
        End Set
    End Property
End Class
