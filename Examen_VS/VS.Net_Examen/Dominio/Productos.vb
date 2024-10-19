Public Class Productos
    Private _Id As Integer
    Private _Nombre As String
    Private _Precio As Double
    Private _Categoria As String
    Public Sub New()
        _Id = 0
        _Nombre = ""
        _Precio = 0
        _Categoria = ""
    End Sub
    Public Sub New(id As Integer, nombre As String, precio As Double, categoria As String)
        _Id = id
        _Nombre = nombre
        _Precio = precio
        _Categoria = categoria
    End Sub
    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property
    Public Property Precio As Double
        Get
            Return _Precio
        End Get
        Set(value As Double)
            _Precio = value
        End Set
    End Property
    Public Property Categoria As String
        Get
            Return _Categoria
        End Get
        Set(value As String)
            _Categoria = value
        End Set
    End Property
End Class
