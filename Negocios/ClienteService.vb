' Clase de servicio para la validación de datos de cliente
Imports Entidades
Imports Entidades.Entidades
Imports System.Text.RegularExpressions

Public Class ClienteService
    ' Método para validar los datos de creación de cliente
    Public Function ValidarCliente(cliente As ClienteEntity, rolesSeleccionados As List(Of RolEntity)) As List(Of String)
        Dim errores As New List(Of String)

        ' Validar nombre
        If String.IsNullOrWhiteSpace(cliente.Nombre) Then
            errores.Add("El nombre es obligatorio.")
        End If

        ' Validar apellido
        If String.IsNullOrWhiteSpace(cliente.Apellido) Then
            errores.Add("El apellido es obligatorio.")
        End If

        ' Validar email
        If String.IsNullOrWhiteSpace(cliente.Email) Then
            errores.Add("El email es obligatorio.")
        ElseIf Not Regex.IsMatch(cliente.Email, "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
            errores.Add("El formato del email es inválido.")
        End If

        ' Validar contraseña
        If String.IsNullOrWhiteSpace(cliente.Contraseña) Then
            errores.Add("La contraseña es obligatoria.")
        ElseIf cliente.Contraseña.Length < 6 Then
            errores.Add("La contraseña debe tener al menos 6 caracteres.")
        End If

        ' Validar roles
        If rolesSeleccionados Is Nothing OrElse rolesSeleccionados.Count = 0 Then
            errores.Add("Debe seleccionar al menos un rol.")
        End If

        Return errores
    End Function
End Class
