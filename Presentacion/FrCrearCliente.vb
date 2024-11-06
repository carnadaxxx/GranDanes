Imports Entidades
Imports Negocios

Public Class FrCrearCliente

    Private Sub FrmCrearCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar roles en el CheckedListBox
        Dim rolesRepo As New RolRepository
        Dim roles As List(Of RolEntity) = rolesRepo.ObtenerRoles()

        For Each rol As RolEntity In roles
            CheckedListBoxRoles.Items.Add(rol, False)
        Next
    End Sub

    Private Sub BtnCrearCliente_Click(sender As Object, e As EventArgs) Handles BtnCrearCliente.Click

        Dim nuevoCliente As New ClienteEntity() With {
            .Nombre = NameTextBox.Text,
            .Apellido = TextBoxApellidos.Text,
            .Email = EmailTextBox.Text,
            .Contraseña = TextBoxContraseña.Text,
            .Direccion = AddressTextBox.Text,
            .Telefono = PhoneTextBox.Text,
            .Visible = True
        }

        ' Obtener los roles seleccionados
        Dim rolesSeleccionados As New List(Of RolEntity)
        For Each item In CheckedListBoxRoles.CheckedItems
            rolesSeleccionados.Add(DirectCast(item, RolEntity))
        Next

        Dim clienteService As New ClienteService

        Dim errores As List(Of String) = clienteService.ValidarCliente(nuevoCliente, rolesSeleccionados)

        If errores.Any() Then
            ' Mostrar los errores al usuario
            MessageBox.Show(String.Join(Environment.NewLine, errores), "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' Llamar al repositorio para guardar el cliente (asumiendo que ya tienes implementado el método CrearCliente en tu repositorio)
            Dim clienteRepo As New ClienteRepository()
            Dim exito As Boolean = clienteRepo.CrearClienteConRoles(nuevoCliente, rolesSeleccionados)

            If exito Then
                MessageBox.Show("Cliente creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Cargar el formulario de listado de configuraciones en el panel

                Me.Close() ' Cerrar el formulario después de guardar
            Else
                MessageBox.Show("Hubo un error al crear el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub


End Class
