Namespace Entidades
    Public Class Cliente

        Public Property ClientID As Integer
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property Address As String
        Public Property Visible As Boolean

        ' Construtor Primario
        Public Sub New()

        End Sub

        Public Sub New(id As Integer, name As String, email As String, phone As String, address As String)
            Me.ClientID = id
            Me.Name = name
            Me.Email = email
            Me.Phone = phone
            Me.Address = address
            Me.Visible = True
        End Sub

    End Class

End Namespace


