Namespace Entidades
    Public Class Configuracion

        Public Property ID As Integer
        Public Property ConfigKey As String
        Public Property ConfigValue As String
        Public Property ConfigDescription As String

        ' Construtor Primario
        Public Sub New()

        End Sub

        Public Sub New(id As Integer, key As String, value As String, description As String)

            Me.ID = id
            Me.ConfigKey = key
            Me.ConfigValue = value
            Me.ConfigDescription = description

        End Sub

    End Class

End Namespace


