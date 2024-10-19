Public Class Producto
    Private listaProductos As List(Of Productos)
    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nego As New ProductosNegocio
        cboFiltro.Text = "Nombre"
        Try
            listaProductos = nego.Listar()
            dgvProductos.DataSource = nego.Listar()
            Globales.DiseñoDtv(dgvProductos)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim ventana As AdministrarProductos = New AdministrarProductos()
        ventana.ShowDialog()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim pro As Productos = dgvProductos.CurrentRow.DataBoundItem
        Dim ventana As AdministrarProductos = New AdministrarProductos(pro)
        ventana.ShowDialog()
    End Sub

    Private Sub btnLogico_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim seleccionado As New Productos
        Dim negocio As New ProductosNegocio
        Dim result As DialogResult = MessageBox.Show("¿Estas seguro de Eliminar este Producto?", "Eliminar producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then

            seleccionado = dgvProductos.CurrentRow.DataBoundItem
            negocio.Eliminar(seleccionado.Id)
            MessageBox.Show("Eliminado exitosamente")

            dgvProductos.DataSource = negocio.Listar()
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Dim filtro As String = txtFiltro.Text.ToLower()
        Dim filtrada As New List(Of Productos)

        If filtro.Length() > 2 Then
            If cboFiltro.Text = "Nombre" Then
                filtrada = listaProductos.FindAll(Function(x) x.Nombre.ToLower().Contains(filtro.ToLower()))
            Else
                filtrada = listaProductos.FindAll(Function(x) x.Categoria.ToLower().Contains(filtro.ToLower()))
            End If
        Else
            filtrada = listaProductos
        End If

        dgvProductos.DataSource = Nothing
        dgvProductos.DataSource = filtrada
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim nego As New ProductosNegocio
        dgvProductos.DataSource = nego.Listar()
        Globales.DiseñoDtv(dgvProductos)
    End Sub
End Class