Namespace Entidades
    Public Class ClienteEntity
        Public Property ClienteID As Integer
        Public Property Nombre As String
        Public Property Apellido As String
        Public Property Email As String
        Public Property Telefono As String
        Public Property Direccion As String
        Public Property FechaRegistro As Date
        Public Property Visible As Boolean
        Public Property Contraseña As String
        Public Property UltimoAcceso As DateTime?

        ' Constructor vacío
        Public Sub New()
        End Sub

        ' Constructor con todos los valores
        Public Sub New(clienteID As Integer, nombre As String, apellido As String, email As String, telefono As String, direccion As String, fechaRegistro As Date, visible As Boolean, contraseña As String, ultimoAcceso As DateTime?)
            Me.ClienteID = clienteID
            Me.Nombre = nombre
            Me.Apellido = apellido
            Me.Email = email
            Me.Telefono = telefono
            Me.Direccion = direccion
            Me.FechaRegistro = fechaRegistro
            Me.Visible = visible
            Me.Contraseña = contraseña
            Me.UltimoAcceso = ultimoAcceso
        End Sub
    End Class

End Namespace


