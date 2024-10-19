Public Class ClientesNegocio
    Public Function Listar() As List(Of Clientes)
        Dim datos As New AccesoDatos
        Dim lista As New List(Of Clientes)
        Try
            datos.SetearConsulta("select ID, Cliente, Telefono, Correo from clientes")
            datos.EjecutarLectura()

            While datos.Lector.Read()
                Dim clien As New Clientes
                clien.Id = Convert.ToInt32(datos.Lector("ID"))
                clien.Cliente = datos.Lector("Cliente").ToString()
                clien.Telefono = datos.Lector("Telefono").ToString()
                clien.Correo = datos.Lector("Correo").ToString()

                lista.Add(clien)
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
            datos.SetearConsulta("delete Clientes where ID = @id")
            datos.SeterParametros("@id", id)
            datos.EjecutarAccion()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            datos.CerrarConexion()
        End Try
    End Sub

    Public Sub Modificar(clien As Clientes)
        Dim datos As New AccesoDatos
        Try
            datos.LimpiarParametros()
            datos.SetearConsulta("update Clientes set Cliente = @clientee, Telefono = @telefonoo, Correo = @correoo where ID = @idd")
            datos.SeterParametros("@clientee", clien.Cliente)
            datos.SeterParametros("@telefonoo", clien.Telefono)
            datos.SeterParametros("@correoo", clien.Correo)
            datos.SeterParametros("@idd", clien.Id)
            datos.EjecutarAccion()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            datos.CerrarConexion()
        End Try
    End Sub

    Public Sub Agregar(clien As Clientes)
        Dim datos As New AccesoDatos
        Try
            datos.LimpiarParametros()
            datos.SetearConsulta("insert clientes (Cliente, Telefono, Correo) VALUES (@cliente, @telefono, @correo)")
            datos.SeterParametros("@cliente", clien.Cliente)
            datos.SeterParametros("@telefono", clien.Telefono)
            datos.SeterParametros("@correo", clien.Correo)
            datos.EjecutarAccion()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            datos.CerrarConexion()
        End Try
    End Sub

End Class
