Public Class VentasItemNegocio
    Public Function Listar() As List(Of VentasItems)
        Dim datos As New AccesoDatos
        Dim lista As New List(Of VentasItems)
        Try
            datos.SetearConsulta("select ID, IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal from ventasitems")
            datos.EjecutarLectura()

            While datos.Lector.Read()
                Dim ven As New VentasItems
                ven.Ventas = New Ventas
                ven.Producto = New Productos
                ven.Id = Convert.ToInt32(datos.Lector("ID"))
                ven.Ventas.Id = Convert.ToInt32(datos.Lector("IDVenta"))
                ven.Producto.Id = Convert.ToInt32(datos.Lector("IDProducto"))
                ven.PrecioUnitario = Convert.ToDouble(datos.Lector("PrecioUnitario"))
                ven.Cantidad = Convert.ToInt32(datos.Lector("Cantidad"))
                ven.PrecioTotal = Convert.ToDouble(datos.Lector("PrecioTotal"))

                lista.Add(ven)
            End While

            Return lista
        Catch ex As Exception
            Throw ex
        Finally
            datos.CerrarConexion()
        End Try
    End Function

    Public Sub Agregar(ven As VentasItems)
        Dim datos As New AccesoDatos
        Try
            datos.LimpiarParametros()
            datos.SetearConsulta("Insert ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES (@idventa, @idproducto, @preciouni, @cantidad, @preciototal)")
            datos.SeterParametros("@idventa", ven.Ventas.Id)
            datos.SeterParametros("@idproducto", ven.Producto.Id)
            datos.SeterParametros("@preciouni", ven.PrecioUnitario)
            datos.SeterParametros("@cantidad", ven.Cantidad)
            datos.SeterParametros("@preciototal", ven.PrecioTotal)
            datos.EjecutarAccion()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            datos.CerrarConexion()
        End Try
    End Sub

End Class
