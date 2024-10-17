Imports System.Configuration
Imports Entidades.Entidades
Imports Microsoft.Data.SqlClient

Public Class ClienteRepository

    Private connectionString As String

    ' Constructor
    Public Sub New()
        connectionString = ConfigurationManager.ConnectionStrings("MiConexionSQL").ConnectionString
    End Sub

    ' Método para crear un nuevo cliente usando el procedimiento almacenado
    Public Function CrearCliente(cliente As Cliente) As Boolean
        Try
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand("sp_InsertarCliente", connection)
                    command.CommandType = CommandType.StoredProcedure

                    ' Asignar los parámetros del procedimiento almacenado
                    command.Parameters.AddWithValue("@Name", cliente.Name)
                    command.Parameters.AddWithValue("@Email", cliente.Email)
                    command.Parameters.AddWithValue("@Phone", cliente.Phone)
                    command.Parameters.AddWithValue("@Address", cliente.Address)
                    command.Parameters.AddWithValue("@Visible", cliente.Visible)

                    ' Abrir la conexión
                    connection.Open()

                    ' Ejecutar el procedimiento almacenado
                    Dim result As Integer = command.ExecuteNonQuery()

                    ' Verificar si la inserción fue exitosa
                    Return result > 0
                End Using
            End Using
        Catch ex As Exception
            ' Manejar cualquier error que ocurra
            MessageBox.Show("Error al crear el cliente: " & ex.Message)
            Return False
        End Try
    End Function


    Public Function ListarTodosLosClientes() As List(Of Cliente)

        Dim clientes As New List(Of Cliente)()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "select * from Client where Visible = 1;"

            Using command As New SqlCommand(query, connection)

                Using reader As SqlDataReader = command.ExecuteReader()

                    While reader.Read()
                        Dim clienteObj As New Cliente()
                        clienteObj.ClientID = Convert.ToInt32(reader("ClientID"))
                        clienteObj.Name = reader("Name").ToString()
                        clienteObj.Address = reader("Address").ToString()
                        clienteObj.Phone = reader("Phone").ToString()
                        clienteObj.Visible = Convert.ToBoolean(reader("Visible"))
                        clientes.Add(clienteObj)
                    End While

                End Using

            End Using

        End Using

        Return clientes

    End Function

End Class
