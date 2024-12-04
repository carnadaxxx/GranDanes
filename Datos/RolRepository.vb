Imports System.Configuration
Imports System.Data.SqlClient
Imports Entidades

Public Class RolRepository

    Private connectionString As String

    ' Constructor
    Public Sub New()
        connectionString = ConfigurationManager.ConnectionStrings("MiConexionSQL").ConnectionString
    End Sub


    ' Método para obtener la lista de roles
    Public Function ObtenerRoles() As List(Of Entidades.RolEntity)
        Dim roles As New List(Of Entidades.RolEntity)()

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("sp_ListarRoles", connection)
                command.CommandType = CommandType.StoredProcedure

                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim rol As New Entidades.RolEntity() With {
                            .RolID = reader.GetInt32(0),
                            .NombreRol = reader.GetString(1),
                            .Descripcion = If(reader.IsDBNull(2), String.Empty, reader.GetString(2))
                        }
                        roles.Add(rol)
                    End While
                End Using
            End Using
        End Using

        Return roles
    End Function

    ' Método para obtener los roles de un cliente específico
    Public Function ObtenerRolesPorCliente(clienteID As Integer) As List(Of RolEntity)
        Dim roles As New List(Of RolEntity)()

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("sp_ObtenerRolesPorCliente", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Agregar el parámetro para el ID del cliente
                command.Parameters.AddWithValue("@ClienteID", clienteID)

                Try
                    connection.Open()

                    ' Ejecutar el procedimiento y leer los datos de los roles
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim rol As New RolEntity() With {
                                .RolID = reader.GetInt32(reader.GetOrdinal("RolID")),
                                .NombreRol = reader.GetString(reader.GetOrdinal("NombreRol"))
                            }
                            roles.Add(rol)
                        End While
                    End Using
                Catch ex As Exception
                    ' Manejo de errores
                    MessageBox.Show("Error al obtener los roles del cliente: " & ex.Message)
                End Try
            End Using
        End Using

        Return roles
    End Function


End Class
