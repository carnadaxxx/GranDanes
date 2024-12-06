Imports Entidades

Public Class FrClienteDetalle

    Public cliente As ClienteEntity
    Public clienteRepository As New ClienteRepository
    Public rolRepository As New RolRepository


    Public Sub New(cliente As ClienteEntity)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Me.cliente = cliente

        TextNombre.Text = cliente.Nombre
        TextDireccion.Text = cliente.Direccion
        TextApellidos.Text = cliente.Apellido
        TextTelefono.Text = cliente.Telefono
        TextEmail.Text = cliente.Email
        TextContraseña.Text = cliente.Contraseña

        CargarRoles(cliente.Roles)

        PrestamosDatagrid.DataSource = clienteRepository.ObtenerPrestamosPorCliente(cliente.ClienteID)

    End Sub


    ' Método para cargar la lista de roles y marcar los roles asignados al cliente
    Private Sub CargarRoles(rolesAsignados As String)

        Dim rolesDisponibles As List(Of RolEntity) = rolRepository.ObtenerRoles()

        ' Dividir los roles asignados en una lista

        Dim listaRolesAsignados As List(Of String) = rolesAsignados.Split(","c).Select(Function(r) r.Trim()).ToList()
        ' Limpiar el CheckedListBox antes de cargar los roles

        CheckedListBoxRoles.Items.Clear()
        ' Añadir roles al CheckedListBox y marcar los roles asignados

        For Each rol In rolesDisponibles
            Dim index As Integer = CheckedListBoxRoles.Items.Add(rol.NombreRol)
            If listaRolesAsignados.Contains(rol.NombreRol) Then
                CheckedListBoxRoles.SetItemChecked(index, True)
            End If
        Next
    End Sub

    Private Sub ModificarButton_Click(sender As Object, e As EventArgs) Handles modificarButton.Click

        cliente.Nombre = TextNombre.Text
        cliente.Apellido = TextApellidos.Text
        cliente.Email = TextEmail.Text
        cliente.Telefono = TextTelefono.Text
        cliente.Direccion = TextDireccion.Text
        cliente.Contraseña = TextContraseña.Text
        cliente.Visible = True

        Dim rolesAgregar As New List(Of String)
        Dim rolesQuitar As New List(Of String)

        For Each item In CheckedListBoxRoles.Items

            Dim rol As String = item.ToString()

            If CheckedListBoxRoles.CheckedItems.Contains(rol) AndAlso Not cliente.Roles.Contains(rol) Then
                rolesAgregar.Add(rol)
            ElseIf Not CheckedListBoxRoles.CheckedItems.Contains(rol) AndAlso cliente.Roles.Contains(rol) Then
                rolesQuitar.Add(rol)
            End If

        Next

        Dim rolesAgregarStr As String = String.Join(",", rolesAgregar)
        Dim rolesQuitarStr As String = String.Join(",", rolesQuitar)

        If clienteRepository.ModificarClienteConRoles(cliente, rolesAgregarStr, rolesQuitarStr) Then
            MessageBox.Show("Cliente actualizado Correctamente.")
        Else
            MessageBox.Show("Error al actualizar el Cliente.")
        End If

    End Sub
End Class