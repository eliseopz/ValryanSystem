Public Class Categoria
    'Atributos'
    Dim _idCategoria As Integer
    Dim _nombreCategoria As String
    Dim _descripcionCategoria As String

    'Constructor vacio'
    Public Sub New()

    End Sub

    'Constructor'
    Public Sub New(idCategoria As Integer, nombreCategoria As String, descripcionCategoria As String)
        _idCategoria = idCategoria
        _nombreCategoria = nombreCategoria
        _descripcionCategoria = descripcionCategoria
    End Sub

    Public Property IdCategoria As Integer
        Get
            Return _idCategoria
        End Get
        Set(value As Integer)
            _idCategoria = value
        End Set
    End Property

    Public Property NombreCategoria As String
        Get
            Return _nombreCategoria
        End Get
        Set(value As String)
            _nombreCategoria = value
        End Set
    End Property

    Public Property DescripcionCategoria As String
        Get
            Return _descripcionCategoria
        End Get
        Set(value As String)
            _descripcionCategoria = value
        End Set
    End Property


End Class
