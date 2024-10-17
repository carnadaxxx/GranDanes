Public Class FrCrearCliente
    Private Sub BtnCrearCliente_Click(sender As Object, e As EventArgs) Handles BtnCrearCliente.Click

        Dim nuevoCliente As New Cliente() With {
            .Name = NameTextBox.Text,
            .Email = EmailTextBox.Text,
            .Address = AddressTextBox.Text,
            .Phone = PhoneTextBox.Text,
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
