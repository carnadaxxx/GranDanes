Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim email As String = TextBoxEmail.Text
        Dim contraseña As String = TextBoxPassword.Text

        Dim clienteRepo As New ClienteRepository()
        Dim sessionService As New SessionService()

        If clienteRepo.ValidarCliente(email, contraseña) Then
            ' Si la validación es exitosa, establece la sesión
            SessionService.IsUserLoggedIn = True
            SessionService.UserEmail = email

            ' Cierra el formulario de login para retornar a MainForm
            Me.Close()
        Else
            MessageBox.Show("Correo o contraseña incorrectos.")
        End If
    End Sub


End Class