Public Class AgregarVentas
    Private identificador As Integer
    Private listaItems As New List(Of VentasItems)
    Private totalVenta As Integer

    Public Sub New(iden As Integer)
        InitializeComponent()
        identificador = iden
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdministrarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pro As New Productos
        Dim negoPro As New ProductosNegocio

        dgvProductos.DataSource = negoPro.Listar()
        Globales.DiseñoDtv(dgvProductos)
        dgvProductos.Columns("ID").Visible = False
    End Sub
    Private Sub CargarDgvAgregar(lista As List(Of VentasItems))
        CalcularTotal()
        dgvAgregar.DataSource = Nothing
        dgvAgregar.DataSource = lista

        dgvAgregar.Columns("ID").Visible = False
        dgvAgregar.Columns("Producto").Visible = False
        dgvAgregar.Columns("Ventas").Visible = False

        Globales.DiseñoDtv(dgvAgregar)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim item As New VentasItems
        Dim pro As New Productos
        If listaItems Is Nothing Then
            listaItems = New List(Of VentasItems)
        End If
        If dgvProductos.CurrentRow IsNot Nothing Then

            pro = dgvProductos.CurrentRow.DataBoundItem
            item.Producto.Nombre = pro.Nombre
            item.NombreProducto = pro.Nombre
            item.Producto.Id = pro.Id
            item.PrecioUnitario = pro.Precio
            item.Cantidad = 1
            item.PrecioTotal = pro.Precio
            item.PrecioTotal = pro.Precio

            Dim itemExistente As VentasItems = listaItems.FirstOrDefault(Function(i) i.Producto.Id = item.Producto.Id)
            If itemExistente IsNot Nothing Then
                itemExistente.Cantidad += 1
                itemExistente.PrecioTotal += pro.Precio
            Else
                listaItems.Add(item)
            End If


            CargarDgvAgregar(listaItems)
        Else
            MessageBox.Show("Porfavor seleccione una fila", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click
        If dgvAgregar.CurrentRow IsNot Nothing Then

            Dim itemSeleccionado As VentasItems = dgvAgregar.CurrentRow.DataBoundItem

            Dim itemExistente As VentasItems = DirectCast(dgvAgregar.CurrentRow.DataBoundItem, VentasItems)
            itemExistente.Cantidad += 1
            itemExistente.PrecioTotal += itemSeleccionado.PrecioUnitario

            CargarDgvAgregar(listaItems)
        Else
            MessageBox.Show("Porfavor seleccione una fila", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        If dgvAgregar.CurrentRow IsNot Nothing Then

            Dim itemSeleccionado As VentasItems = dgvAgregar.CurrentRow.DataBoundItem
            Dim Listafiltrada As New List(Of VentasItems)
            Dim itemfiltrado As New VentasItems

            If itemSeleccionado.Cantidad > 1 Then
                Dim itemExistente As VentasItems = listaItems.FirstOrDefault(Function(i) i.Producto.Id = itemSeleccionado.Producto.Id)
                itemExistente.Cantidad -= 1
                itemExistente.PrecioTotal -= itemSeleccionado.PrecioUnitario

                CargarDgvAgregar(listaItems)
            Else
                MessageBox.Show("No se puede tener un producto con cantidad menor a 1", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Porfavor seleccione una fila", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvAgregar.CurrentRow IsNot Nothing Then
                Dim itemSeleccionado As VentasItems = DirectCast(dgvAgregar.CurrentRow.DataBoundItem, VentasItems)
                listaItems.RemoveAll(Function(i) i.Producto.Id = itemSeleccionado.Producto.Id)
                CargarDgvAgregar(listaItems)
            Else
                MessageBox.Show("Porfavor seleccione una fila", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub CalcularTotal()
        Dim total As Double = listaItems.Sum(Function(item) item.PrecioTotal)
        txtTotal.Text = total.ToString("C2")
        totalVenta = total.ToString("C2")
    End Sub

    Private Sub btnAdmVenta_Click(sender As Object, e As EventArgs) Handles btnAdmVenta.Click
        Dim b = True
        Dim b2 = False
        If String.IsNullOrEmpty(txtCliente.Text) Then
            MessageBox.Show("Por favor, complete el campo de Id Cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            b = False
        End If
        Dim clien As New List(Of Clientes)
        Dim negocioC As New ClientesNegocio

        Dim negocioIV As New VentasItemNegocio

        Dim idVenta As Integer
        If listaItems IsNot Nothing And listaItems.Count > 0 Then
            If b = True Then
                clien = negocioC.Listar()
                For Each item As Clientes In clien
                    If item.Id = Convert.ToInt32(txtCliente.Text) Then
                        b2 = True
                    End If
                Next

                If b2 = True Then

                    Dim VentaNuevo As New Ventas
                    Dim negocioV As New VentasNegocio

                    VentaNuevo.Cliente.Id = Convert.ToInt32(txtCliente.Text)
                    VentaNuevo.Fecha = DateTime.Now
                    VentaNuevo.Total = totalVenta

                    negocioV.Agregar(VentaNuevo)
                    idVenta = negocioV.DevolverId()

                    For Each item As VentasItems In listaItems
                        item.Ventas.Id = idVenta
                        negocioIV.Agregar(item)
                    Next
                    MessageBox.Show("Agregado Exitosamente :)")
                    Close()

                Else
                    MessageBox.Show("El IdCliente no existe en la base de datos..")
                End If
            End If
        Else
            MessageBox.Show("No hay ventas para cerrar..")
        End If
    End Sub
End Class