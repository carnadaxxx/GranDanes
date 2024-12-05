Imports Windows.Win32.System

Public Class FrEditarCliente

    Private clienteRepo As New ClienteRepository()
    Private rolesRepo As New RolRepository()
    Private clienteID As Integer ' El ID del cliente a editar

    Public Sub New(clienteID As Integer)
        InitializeComponent()
        Me.clienteID = clienteID
    End Sub

    Private Sub FrEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar datos del cliente y roles
        CargarDatosCliente()
        CargarRoles()
    End Sub

    Private Sub CargarDatosCliente()
        Dim cliente = clienteRepo.ObtenerClientePorID(clienteID)
        txtNombre.Text = cliente.Nombre
        txtApellido.Text = cliente.Apellido
        txtEmail.Text = cliente.Email
        txtTelefono.Text = cliente.Telefono
        txtDireccion.Text = cliente.Direccion
    End Sub

    Private Sub CargarRoles()
        Dim rolesDisponibles = rolesRepo.ObtenerRoles()
        Dim rolesCliente = rolesRepo.ObtenerRolesPorCliente(clienteID)

        For Each rol In rolesDisponibles
            Dim index = checkedListBoxRoles.Items.Add(rol.NombreRol)
            checkedListBoxRoles.SetItemChecked(index, rolesCliente.Contains(rol))
        Next
    End Sub

    '    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
    '        ' Capturar los datos del cliente
    '        Dim cliente = New ClienteEntity With {
    '            .ClienteID = clienteID,
    '            .Nombre = txtNombre.Text,
    '            .Apellido = txtApellido.Text,
    '            .Email = txtEmail.Text,
    '            .Telefono = txtTelefono.Text,
    '            .Direccion = txtDireccion.Text
    '        }

    '        ' Capturar los roles seleccionados
    '        Dim rolesSeleccionados As New List(Of Integer)
    '        For i As Integer = 0 To checkedListBoxRoles.Items.Count - 1
    '            If checkedListBoxRoles.GetItemChecked(i) Then
    '                rolesSeleccionados.Add(CType(checkedListBoxRoles.Items(i), Rol).ID)
    '            End If
    '        Next

    '        ' Guardar los cambios
    '        Dim exito = clienteRepo.ModificarClienteConRoles(
    '            clienteID:=cliente.ClienteID,
    '            nombre:=cliente.Nombre,
    '            apellido:=cliente.Apellido,
    '            email:=cliente.Email,
    '            telefono:=cliente.Telefono,
    '            direccion:=cliente.Direccion,
    ')

    '        If exito Then
    '            MessageBox.Show("El cliente se actualizó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Me.Close()
    '        Else
    '            MessageBox.Show("No se pudo actualizar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If
    '    End Sub

End Class