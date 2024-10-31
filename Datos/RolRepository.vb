Imports System.Configuration
Imports System.Data.SqlClient

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


End Class
