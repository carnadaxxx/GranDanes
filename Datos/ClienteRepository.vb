Imports System.Configuration
Imports Microsoft.Data.SqlClient

Public Class ClienteRepository

    Private connectionString As String

    ' Constructor
    Public Sub New()
        connectionString = ConfigurationManager.ConnectionStrings("MiConexionSQL").ConnectionString
    End Sub

    ' Método para crear un cliente
    Public Function CrearCliente(cliente As ClienteEntity) As Integer
        Dim clienteID As Integer = 0

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Using command As New SqlCommand("sp_CrearCliente", connection)
                    command.CommandType = CommandType.StoredProcedure

                    ' Asignar los parámetros del procedimiento almacenado
                    command.Parameters.AddWithValue("@Nombre", cliente.Nombre)
                    command.Parameters.AddWithValue("@Apellido", cliente.Apellido)
                    command.Parameters.AddWithValue("@Email", cliente.Email)
                    command.Parameters.AddWithValue("@Telefono", If(cliente.Telefono, DBNull.Value))
                    command.Parameters.AddWithValue("@Direccion", If(cliente.Direccion, DBNull.Value))
                    command.Parameters.AddWithValue("@Visible", cliente.Visible)
                    command.Parameters.AddWithValue("@Contraseña", cliente.Contraseña)
                    command.Parameters.AddWithValue("@UltimoAcceso", If(cliente.UltimoAcceso, DBNull.Value))

                    ' Ejecutar el comando y obtener el ID generado
                    clienteID = Convert.ToInt32(command.ExecuteScalar())
                End Using

            Catch ex As Exception
                ' Maneja cualquier error
                Console.WriteLine("Error al crear el cliente: " & ex.Message)
            End Try
        End Using

        Return clienteID
    End Function

    ' Método para listar todos los clientes visibles
    Public Function ListarTodosLosClientes() As List(Of ClienteEntity)
        Dim clientes As New List(Of ClienteEntity)()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand("sp_ListarClientes", connection)
                command.CommandType = CommandType.StoredProcedure

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim clienteObj As New ClienteEntity()
                        clienteObj.ClienteID = Convert.ToInt32(reader("ClienteID"))
                        clienteObj.Nombre = reader("Nombre").ToString()
                        clienteObj.Apellido = reader("Apellido").ToString()
                        clienteObj.Email = reader("Email").ToString()
                        clienteObj.Telefono = reader("Telefono").ToString()
                        clienteObj.Direccion = reader("Direccion").ToString()
                        clienteObj.FechaRegistro = Convert.ToDateTime(reader("FechaRegistro"))
                        clienteObj.Visible = Convert.ToBoolean(reader("Visible"))
                        clienteObj.UltimoAcceso = If(IsDBNull(reader("UltimoAcceso")), Nothing, Convert.ToDateTime(reader("UltimoAcceso")))
                        clientes.Add(clienteObj)
                    End While
                End Using
            End Using
        End Using

        Return clientes
    End Function

    ' Método para validar al cliente
    Public Function ValidarCliente(email As String, contraseña As String) As Boolean

        Dim resultado As Integer

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Using command As New SqlCommand("sp_ValidarYRegistrarUltimoAcceso", connection)
                    command.CommandType = CommandType.StoredProcedure

                    ' Asignar parámetros
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@Contraseña", contraseña)

                    ' Agregar el parámetro de salida
                    Dim resultadoParam As SqlParameter = New SqlParameter("@Cuenta", SqlDbType.Int)
                    resultadoParam.Direction = ParameterDirection.Output
                    command.Parameters.Add(resultadoParam)

                    ' Ejecutar el comando
                    command.ExecuteNonQuery()

                    ' Obtener el resultado del parámetro de salida
                    resultado = Convert.ToInt32(resultadoParam.Value)

                End Using

            Catch ex As Exception
                ' Manejar cualquier error que ocurra
                Console.WriteLine("Error al validar el cliente: " & ex.Message)
                Return False
            End Try
        End Using

        ' Retornar True si existe el usuario, de lo contrario False
        Return resultado > 0
    End Function

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
