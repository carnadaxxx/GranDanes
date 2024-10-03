Public Class MainStrip

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Con esto hacemos que este formulario sea el contenedor principal.
        Me.IsMdiContainer = True

    End Sub

    Private Sub NuevoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoClienteToolStripMenuItem.Click

        Dim frm As New FrCrearCliente()

        frm.MdiParent = Me

        frm.Show()

    End Sub

    Private Sub VerClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerClientesToolStripMenuItem.Click

        Dim frm As New FrListarClientes()

        frm.MdiParent = Me

        frm.Show()

    End Sub
End Class