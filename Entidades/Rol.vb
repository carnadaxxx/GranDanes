Public Class RolEntity
    Public Property RolID As Integer
    Public Property NombreRol As String
    Public Property Descripcion As String

    ' Constructor vacío
    Public Sub New()
    End Sub

    ' Constructor con parámetros
    Public Sub New(rolID As Integer, nombreRol As String, descripcion As String)
        Me.RolID = rolID
        Me.NombreRol = nombreRol
        Me.Descripcion = descripcion
    End Sub
End Class
