Imports System.Drawing.Text
Imports Entidades.Entidades

Public Class FrListarClientes

    Private clientes As List(Of Cliente)

    Private Sub FrListarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Esto es para cargar los clientes en memoria lo que no va a cambiar mas adelante
        clientes = New List(Of Cliente) From {
            New Cliente(1, "Wilson Coronado", "w@uss.edu.pe", "952177674", "Leticia 466"),
            New Cliente(2, "Altamirano", "a@uss.edu.pe", "952177672", "Leticia 463")
        }

        DataGridView1.DataSource = clientes

    End Sub

    Private Sub BtnFiltrarCliente_Click(sender As Object, e As EventArgs) Handles BtnFiltrarCliente.Click

        Dim filtroNombre As String = InputNombreFiltro.Text.Trim()

        Dim clientesFiltrados = clientes.Where(Function(c) c.Name.ToLower().Contains(filtroNombre.ToLower())).ToList()

        DataGridView1.DataSource = clientesFiltrados

    End Sub
End Class