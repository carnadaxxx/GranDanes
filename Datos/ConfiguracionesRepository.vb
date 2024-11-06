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

    ' Método para crear una nueva configuración en la base de datos
    Public Function CrearConfiguracion(configuracion As ConfiguracionEntity) As Boolean
        Dim exito As Boolean = False

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Using command As New SqlCommand("sp_CrearConfiguracion", connection)
                    command.CommandType = CommandType.StoredProcedure

                    ' Configurar los parámetros para el procedimiento almacenado
                    command.Parameters.AddWithValue("@ConfigKey", configuracion.ConfigKey)
                    command.Parameters.AddWithValue("@ConfigValue", configuracion.ConfigValue)
                    command.Parameters.AddWithValue("@ConfigDescription", configuracion.ConfigDescription)

                    ' Ejecutar el comando
                    command.ExecuteNonQuery()
                    exito = True
                End Using

            Catch ex As Exception
                ' Manejo de errores si ocurre alguno al ejecutar el procedimiento almacenado
                Throw New Exception("Error al crear la configuración: " & ex.Message)
            End Try
        End Using

        Return exito
    End Function

    Public Function ObtenerConfiguracion(configKey As String) As String
        Dim configValue As String = String.Empty

        Using connection As New SqlConnection(connectionString) ' Cambia esto por tu cadena de conexión
            Using command As New SqlCommand("sp_ObtenerConfiguracion", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@ConfigKey", configKey)

                connection.Open()

                Dim result = command.ExecuteScalar()
                If result IsNot Nothing Then
                    configValue = result.ToString()
                End If
            End Using
        End Using

        Return configValue
    End Function


End Class
