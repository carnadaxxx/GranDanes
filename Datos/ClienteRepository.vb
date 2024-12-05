Imports System.Configuration
Imports Entidades
Imports Microsoft.Data.SqlClient

Public Class ClienteRepository

    Private connectionString As String

    ' Constructor
    Public Sub New()
        connectionString = ConfigurationManager.ConnectionStrings("MiConexionSQL").ConnectionString
    End Sub

    ' Método para crear un cliente y asignarle roles
    Public Function CrearClienteConRoles(cliente As ClienteEntity, roles As List(Of RolEntity)) As Boolean
        Dim exito As Boolean = False

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Iniciar una transacción
            Dim transaction As SqlTransaction = connection.BeginTransaction()

            Try
                ' Insertar el cliente en la base de datos
                Using command As New SqlCommand("sp_CrearCliente", connection, transaction)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@Nombre", cliente.Nombre)
                    command.Parameters.AddWithValue("@Apellido", cliente.Apellido)
                    command.Parameters.AddWithValue("@Email", cliente.Email)
                    command.Parameters.AddWithValue("@Contraseña", cliente.Contraseña)
                    command.Parameters.AddWithValue("@Telefono", cliente.Telefono)
                    command.Parameters.AddWithValue("@Direccion", cliente.Direccion)
                    command.Parameters.AddWithValue("@Visible", cliente.Visible)
                    command.Parameters.AddWithValue("@UltimoAcceso", cliente.UltimoAcceso)

                    ' Ejecutar el procedimiento almacenado y obtener el ID del cliente
                    Dim clienteID As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' Asignar roles al cliente usando el procedimiento almacenado para cada rol
                    For Each rol As RolEntity In roles
                        Using roleCommand As New SqlCommand("sp_AsignarRolACliente", connection, transaction)
                            roleCommand.CommandType = CommandType.StoredProcedure
                            roleCommand.Parameters.AddWithValue("@ClienteID", clienteID)
                            roleCommand.Parameters.AddWithValue("@RolID", rol.RolID)
                            roleCommand.ExecuteNonQuery()
                        End Using
                    Next
                End Using

                ' Confirmar la transacción
                transaction.Commit()
                exito = True

            Catch ex As Exception
                ' En caso de error, revertir la transacción
                transaction.Rollback()
                Throw New Exception("Error al crear el cliente y asignar roles.", ex)
            End Try
        End Using

        Return exito
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


    ' Método para para listar clientes por nombre
    Public Function ListarClientesPorNombre(nombre As String) As List(Of ClienteEntity)
        Dim clientes As New List(Of ClienteEntity)()

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand("sp_ListarClientesPorNombre", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@Nombre", nombre)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim cliente As New ClienteEntity() With {
                        .ClienteID = Convert.ToInt32(reader("ClienteID")),
                        .Nombre = reader("Nombre").ToString(),
                        .Apellido = reader("Apellido").ToString(),
                        .Email = reader("Email").ToString(),
                        .Telefono = reader("Telefono").ToString(),
                        .Direccion = reader("Direccion").ToString()
                    }
                        clientes.Add(cliente)
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


    ' Función para obtener la lista de préstamos por cliente
    Public Function ObtenerPrestamosPorCliente(clienteID As Integer) As List(Of PrestamoEntity)
        Dim prestamos As New List(Of PrestamoEntity)()

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("sp_ObtenerPrestamosPorCliente", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@ClienteID", clienteID)

                connection.Open()

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim prestamo As New PrestamoEntity() With {
                            .PrestamoID = reader.GetInt32(0),
                            .ClienteID = reader.GetInt32(1),
                            .MontoTotal = reader.GetDecimal(2),
                            .MontoConIntereses = reader.GetDecimal(3),
                            .TasaInteres = reader.GetDecimal(4),
                            .FechaPrestamo = reader.GetDateTime(5),
                            .FechaVencimiento = reader.GetDateTime(6),
                            .Estado = reader.GetString(7),
                            .NumeroCuotas = reader.GetInt32(8),
                            .FrecuenciaPago = reader.GetString(9)
                        }
                        prestamos.Add(prestamo)
                    End While
                End Using
            End Using
        End Using

        Return prestamos
    End Function

    ' Método para obtener un cliente por su ID
    Public Function ObtenerClientePorID(clienteID As Integer) As ClienteEntity
        Dim cliente As ClienteEntity = Nothing

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("sp_ObtenerClientePorID", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Agregar parámetro para el ID del cliente
                command.Parameters.AddWithValue("@ClienteID", clienteID)

                Try
                    connection.Open()

                    ' Ejecutar el procedimiento y leer los datos del cliente
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            cliente = New ClienteEntity() With {
                                .ClienteID = reader.GetInt32(reader.GetOrdinal("ClienteID")),
                                .Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                .Apellido = reader.GetString(reader.GetOrdinal("Apellido")),
                                .Contraseña = reader.GetString(reader.GetOrdinal("Contraseña")),
                                .Email = reader.GetString(reader.GetOrdinal("Email")),
                                .Telefono = If(reader.IsDBNull(reader.GetOrdinal("Telefono")), Nothing, reader.GetString(reader.GetOrdinal("Telefono"))),
                                .Direccion = If(reader.IsDBNull(reader.GetOrdinal("Direccion")), Nothing, reader.GetString(reader.GetOrdinal("Direccion"))),
                                .FechaRegistro = If(reader.IsDBNull(reader.GetOrdinal("FechaRegistro")), Nothing, reader.GetDateTime(reader.GetOrdinal("FechaRegistro"))),
                                .Visible = If(reader.IsDBNull(reader.GetOrdinal("Visible")), False, reader.GetBoolean(reader.GetOrdinal("Visible"))),
                                .UltimoAcceso = If(reader.IsDBNull(reader.GetOrdinal("UltimoAcceso")), Nothing, reader.GetDateTime(reader.GetOrdinal("UltimoAcceso"))),
                                .Roles = reader.GetString(reader.GetOrdinal("Roles"))
                            }
                        End If
                    End Using
                Catch ex As Exception
                    ' Manejo de errores
                    MessageBox.Show("Error al obtener el cliente: " & ex.Message)
                End Try
            End Using
        End Using

        Return cliente
    End Function

    Public Function ModificarClienteConRoles(clienteID As Integer, nombre As String, apellido As String, email As String, telefono As String, direccion As String, visible As Boolean, contraseña As String, rolesAgregar As String, rolesQuitar As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("sp_ModificarClienteConRoles", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Parámetros de entrada
                command.Parameters.AddWithValue("@ClienteID", clienteID)
                command.Parameters.AddWithValue("@Nombre", nombre)
                command.Parameters.AddWithValue("@Apellido", apellido)
                command.Parameters.AddWithValue("@Email", email)
                command.Parameters.AddWithValue("@Telefono", telefono)
                command.Parameters.AddWithValue("@Direccion", direccion)
                command.Parameters.AddWithValue("@Visible", visible)
                command.Parameters.AddWithValue("@Contraseña", contraseña)
                command.Parameters.AddWithValue("@RolesAgregar", rolesAgregar)
                command.Parameters.AddWithValue("@RolesQuitar", rolesQuitar)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    Return True
                Catch ex As Exception
                    MessageBox.Show("Error al modificar el cliente y los roles: " & ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function

End Class
