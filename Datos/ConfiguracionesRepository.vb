Imports System.Configuration
Imports System.Data.SqlClient

Public Class ConfiguracionesRepository

    Private connectionString As String

    ' Constructor
    Public Sub New()
        connectionString = ConfigurationManager.ConnectionStrings("MiConexionSQL").ConnectionString
    End Sub


    ' Método para listar configuraciones
    Public Function ListarConfiguraciones() As List(Of ConfiguracionEntity)
        Dim configuraciones As New List(Of ConfiguracionEntity)()

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("sp_ListarConfiguraciones", connection)
                command.CommandType = CommandType.StoredProcedure

                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim configuracion As New ConfiguracionEntity() With {
                            .ID = reader.GetInt32(0),
                            .ConfigKey = reader.GetString(1),
                            .ConfigValue = reader.GetString(2),
                            .ConfigDescription = reader.GetString(3)
                        }
                        configuraciones.Add(configuracion)
                    End While
                End Using
            End Using
        End Using

        Return configuraciones
    End Function

    ' Método para crear una nueva configuración
    Public Function CrearConfiguracion(configKey As String, configValue As String, configDescription As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("sp_CrearConfiguracion", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Asignar los parámetros
                command.Parameters.AddWithValue("@ConfigKey", configKey)
                command.Parameters.AddWithValue("@ConfigValue", configValue)
                command.Parameters.AddWithValue("@ConfigDescription", configDescription)

                connection.Open()
                Dim result As Integer = command.ExecuteNonQuery()

                ' Retornar verdadero si la operación fue exitosa
                Return result > 0
            End Using
        End Using
    End Function

End Class
