Public Class AdministrarProductos
    Private identificador As Productos
    Private identifi As Integer
    Public Sub New(iden As Productos)
        InitializeComponent()
        identificador = iden
        identifi = 1
    End Sub

    Public Sub New()
        InitializeComponent()
        identifi = 0
    End Sub

    Private Sub AdministrarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblId.Visible = False
        txtId.Visible = False
        If identifi = 1 Then
            btnAdmProducto.Text = "Modificar"

            txtId.Text = identificador.Id
            txtNombre.Text = identificador.Nombre
            txtCategoria.Text = identificador.Categoria
            txtPrecio.Text = identificador.Precio
        Else
            btnAdmProducto.Text = "Agregar"
            lblId.Visible = False
            txtId.Visible = False
        End If
    End Sub

    Private Sub btnAdmProducto_Click(sender As Object, e As EventArgs) Handles btnAdmProducto.Click
        Dim b As Boolean = True
        Dim pro As New Productos
        Dim negocio As New ProductosNegocio
        If identifi = 1 Then
            If String.IsNullOrEmpty(txtNombre.Text) Then
                MessageBox.Show("Por favor, complete el campo de Nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                b = False
            End If
            If String.IsNullOrEmpty(txtPrecio.Text) Then
                MessageBox.Show("Por favor, complete el campo de Precio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                b = False
            End If
            If String.IsNullOrEmpty(txtCategoria.Text) Then
                MessageBox.Show("Por favor, complete el campo de Categoria.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                b = False
            End If

            If b = True Then
                pro.Id = txtId.Text
                pro.Nombre = txtNombre.Text
                pro.Categoria = txtCategoria.Text
                pro.Precio = txtPrecio.Text

                negocio.Modificar(pro)
                MessageBox.Show("Modificado exitosamente :)")
                Close()
            End If

        Else
            If String.IsNullOrEmpty(txtNombre.Text) Then
                MessageBox.Show("Por favor, complete el campo de Nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                b = False
            End If
            If String.IsNullOrEmpty(txtPrecio.Text) Then
                MessageBox.Show("Por favor, complete el campo de Precio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                b = False
            End If
            If String.IsNullOrEmpty(txtCategoria.Text) Then
                MessageBox.Show("Por favor, complete el campo de Categoria.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                b = False
            End If

            If b = True Then
                pro.Nombre = txtNombre.Text
                pro.Categoria = txtCategoria.Text
                pro.Precio = txtPrecio.Text

                negocio.Agregar(pro)
                MessageBox.Show("Agregado exitosamente :)")
                Close()
            End If

        End If
    End Sub
End Class