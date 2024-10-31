Public Class MainForm

    Public Sub Main()
        Dim sessionService As New SessionService()

        ' Verificar si el usuario ya está logueado
        If Not SessionService.IsUserLoggedIn Then
            ' Mostrar el formulario de login
            Dim loginForm As New Login()

            ' Si el login es exitoso, cambia la propiedad y muestra MainForm
            If loginForm.ShowDialog() = DialogResult.OK Then
                SessionService.IsUserLoggedIn = True
                Dim mainForm As New MainForm()
                mainForm.ShowDialog()
            End If
        Else
            ' Si ya está logueado, abre directamente MainForm
            Dim mainForm As New MainForm()
            mainForm.ShowDialog()
        End If
    End Sub

    Public Sub CargarFormularioEnPanel(ByVal formulario As Form)

        ' Limpiar el panel antes de cargar el nuevo formulario
        pnlContenedor.Controls.Clear()

        ' Configurar el formulario para cargarlo en el panel
        formulario.TopLevel = False

        formulario.FormBorderStyle = FormBorderStyle.None

        formulario.Dock = DockStyle.Fill

        pnlContenedor.Controls.Add(formulario)

        pnlContenedor.Tag = formulario

        formulario.Show()

    End Sub


    Private Sub NuevoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoClienteToolStripMenuItem.Click

        CargarFormularioEnPanel(New FrCrearCliente)

    End Sub

    Private Sub VerClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerClientesToolStripMenuItem.Click

        CargarFormularioEnPanel(New FrListarClientes)

    End Sub


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sessionService As New SessionService()

        ' Verificar si el usuario está logueado
        If Not SessionService.IsUserLoggedIn Then
            ' Mostrar formulario de login si no está logueado
            Dim loginForm As New Login()
            loginForm.ShowDialog() ' Mostrar modal para forzar el login

            ' Si el login fue exitoso, continúa con la carga del formulario
            If Not SessionService.IsUserLoggedIn Then
                ' Si no se loguea, cerrar la aplicación
                Me.Close()
                Exit Sub
            End If
        End If

        ' Cargar FrListarClientes en el panel
        CargarFormularioEnPanel(New FrListarClientes())

    End Sub

    Private Sub MostrarConfiguracionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarConfiguracionesToolStripMenuItem.Click

        CargarFormularioEnPanel(New FrListarConfiguracion)

    End Sub

    Private Sub CrearConfiguracionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearConfiguracionToolStripMenuItem.Click
        CargarFormularioEnPanel(New FrCrearConfiguracion)
    End Sub
End Class