Public Class FrCrearCliente
    Private Sub BtnCrearCliente_Click(sender As Object, e As EventArgs) Handles BtnCrearCliente.Click

        Dim nuevoCliente As New ClienteEntity() With {
            .Nombre = NameTextBox.Text,
            .Email = EmailTextBox.Text,
            .Direccion = AddressTextBox.Text,
            .Telefono = PhoneTextBox.Text,
            .Visible = True
        }

        Dim clienteRepo As New ClienteRepository()

        Dim exito As Boolean = clienteRepo.CrearCliente(nuevoCliente)

        ' Verificar si la creación fue exitosa
        If exito Then
            MessageBox.Show("Cliente creado exitosamente.")
        Else
            MessageBox.Show("Error al crear el cliente.")
        End If

    End Sub
End Class
