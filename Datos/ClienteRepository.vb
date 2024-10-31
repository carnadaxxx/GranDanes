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

End Class
