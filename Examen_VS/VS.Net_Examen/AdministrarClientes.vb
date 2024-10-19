Public Class AdministrarClientes

    Private identificador As Clientes
    Private identifi As Integer

    Public Sub New(iden As Clientes)
        InitializeComponent()
        identificador = iden
        identifi = 1
    End Sub

    Public Sub New()
        InitializeComponent()
        identifi = 0
    End Sub

    Private Sub AdministrarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If identifi = 1 Then
            btnAdmCliente.Text = "Modificar"

            txtId.Text = identificador.Id
            txtNombre.Text = identificador.Cliente
            txtTelefono.Text = identificador.Telefono
            txtGmail.Text = identificador.Correo

        Else
            btnAdmCliente.Text = "Agregar"
            lblId.Visible = False
            txtId.Visible = False
        End If
    End Sub

    Private Sub btnAdmCliente_Click(sender As Object, e As EventArgs) Handles btnAdmCliente.Click
        Dim b As Boolean = True
        Dim negocio As New ClientesNegocio
        Dim clien As New Clientes
        If identifi = 1 Then
            If String.IsNullOrEmpty(txtNombre.Text) Then
                MessageBox.Show("Por favor, complete el campo de Nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                b = False
            End If
            If String.IsNullOrEmpty(txtGmail.Text) Then
                MessageBox.Show("Por favor, complete el campo de gmail.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                b = False
            End If
            If String.IsNullOrEmpty(txtTelefono.Text) Then
                MessageBox.Show("Por favor, complete el campo de telefono.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                b = False
            End If

            If b = True Then

                clien.Id = txtId.Text
                clien.Cliente = txtNombre.Text
                clien.Correo = txtGmail.Text
                clien.Telefono = txtTelefono.Text

                negocio.Modificar(clien)
                MessageBox.Show("Modificado exitosamente :)")
                Close()
            End If

        Else
            If String.IsNullOrEmpty(txtNombre.Text) Then
                MessageBox.Show("Por favor, complete el campo de Nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                b = False
            End If
            If String.IsNullOrEmpty(txtGmail.Text) Then
                MessageBox.Show("Por favor, complete el campo de gmail.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                b = False
            End If
            If String.IsNullOrEmpty(txtTelefono.Text) Then
                MessageBox.Show("Por favor, complete el campo de telefono.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                b = False
            End If

            If b = True Then

                clien.Cliente = txtNombre.Text
                clien.Correo = txtGmail.Text
                clien.Telefono = txtTelefono.Text

                negocio.Agregar(clien)
                MessageBox.Show("Agregado exitosamente")
                Close()
            End If
        End If
    End Sub
End Class