Public Class ProductosNegocio
    Public Function Listar() As List(Of Productos)
        Dim datos As New AccesoDatos
        Dim lista As New List(Of Productos)
        Try
            datos.SetearConsulta("select ID, Nombre, Precio, Categoria from productos")
            datos.EjecutarLectura()

            While datos.Lector.Read()
                Dim pro As New Productos
                pro.Id = Convert.ToInt32(datos.Lector("ID"))
                pro.Nombre = datos.Lector("Nombre").ToString()
                pro.Precio = Convert.ToDouble(datos.Lector("Precio"))
                pro.Categoria = datos.Lector("Categoria").ToString()

                lista.Add(pro)
            End While

            Return lista
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            datos.CerrarConexion()
        End Try
    End Function

    Public Sub Eliminar(id As Integer)
        Dim datos As New AccesoDatos
        Try
            datos.SetearConsulta("delete productos where ID = @id")
            datos.SeterParametros("@id", id)
            datos.EjecutarAccion()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            datos.CerrarConexion()
        End Try
    End Sub

    Public Sub Modificar(pro As Productos)
        Dim datos As New AccesoDatos
        Try
            datos.LimpiarParametros()
            datos.SetearConsulta("update Productos set Nombre = @nombre, Precio = @precio, Categoria = @categoria where ID = @id")
            datos.SeterParametros("@nombre", pro.Nombre)
            datos.SeterParametros("@precio", pro.Precio)
            datos.SeterParametros("@categoria", pro.Categoria)
            datos.SeterParametros("@id", pro.Id)
            datos.EjecutarAccion()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            datos.CerrarConexion()
        End Try
    End Sub

    Public Sub Agregar(pro As Productos)
        Dim datos As New AccesoDatos
        Try
            datos.LimpiarParametros()
            datos.SetearConsulta("insert productos (Nombre, Precio, Categoria) VALUES (@nombre, @precio, @categoria)")
            datos.SeterParametros("@nombre", pro.Nombre)
            datos.SeterParametros("@precio", pro.Precio)
            datos.SeterParametros("@categoria", pro.Categoria)
            datos.EjecutarAccion()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            datos.CerrarConexion()
        End Try
    End Sub

End Class
