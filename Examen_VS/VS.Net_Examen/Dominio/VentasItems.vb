Public Class VentasItems
    Private _Id As Integer
    Private _Venta As Ventas
    Private _Producto As Productos
    Private _NombreProducto As String
    Private _PrecioUnitario As Double
    Private _Cantidad As Double
    Private _PrecioTotal As Double

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim otro As VentasItems = TryCast(obj, VentasItems)
        If otro Is Nothing Then
            Return False
        End If
        Return Me.Id = otro.Id
    End Function
    Public Sub New()
        _NombreProducto = ""
        _Id = 0
        _Venta = New Ventas
        _Producto = New Productos
        _PrecioUnitario = 0
        _Cantidad = 0
        _PrecioTotal = 0
    End Sub
    Public Sub New(id As Integer, npro As String, venta As Ventas, producto As Productos, precioUnitario As Double, cantidad As Double, precioTotal As Double)
        _Id = id
        _NombreProducto = npro
        _Venta = venta
        _Producto = producto
        _PrecioUnitario = precioUnitario
        _Cantidad = cantidad
        _PrecioTotal = precioTotal
    End Sub
    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property
    Public Property NombreProducto As String
        Get
            Return _NombreProducto
        End Get
        Set(value As String)
            _NombreProducto = value
        End Set
    End Property
    Public Property Ventas As Ventas
        Get
            Return _Venta
        End Get
        Set(value As Ventas)
            _Venta = value
        End Set
    End Property
    Public Property Producto As Productos
        Get
            Return _Producto
        End Get
        Set(value As Productos)
            _Producto = value
        End Set
    End Property
    Public Property PrecioUnitario As Double
        Get
            Return _PrecioUnitario
        End Get
        Set(value As Double)
            _PrecioUnitario = value
        End Set
    End Property
    Public Property Cantidad As Double
        Get
            Return _Cantidad
        End Get
        Set(value As Double)
            _Cantidad = value
        End Set
    End Property
    Public Property PrecioTotal As Double
        Get
            Return _PrecioTotal
        End Get
        Set(value As Double)
            _PrecioTotal = value
        End Set
    End Property
End Class
