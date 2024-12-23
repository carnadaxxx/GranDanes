USE [DeudasDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/12/2024 17:56:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClienteRoles]    Script Date: 5/12/2024 17:56:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClienteRoles](
	[ClienteID] [int] NOT NULL,
	[RolID] [int] NOT NULL,
	[FechaAsignacion] [datetime] NULL,
 CONSTRAINT [PK_ClienteRoles] PRIMARY KEY CLUSTERED 
(
	[ClienteID] ASC,
	[RolID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 5/12/2024 17:56:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ClienteID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Apellido] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](150) NOT NULL,
	[Telefono] [nvarchar](20) NULL,
	[Direccion] [nvarchar](255) NULL,
	[FechaRegistro] [date] NULL,
	[Visible] [bit] NULL,
	[Contraseña] [nvarchar](255) NOT NULL,
	[UltimoAcceso] [datetime] NULL,
	[RutaImagen] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ClienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Configuracion]    Script Date: 5/12/2024 17:56:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Configuracion](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ConfigKey] [nvarchar](100) NOT NULL,
	[ConfigValue] [nvarchar](255) NOT NULL,
	[ConfigDescription] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cuotas]    Script Date: 5/12/2024 17:56:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuotas](
	[CuotaID] [int] IDENTITY(1,1) NOT NULL,
	[PrestamoID] [int] NOT NULL,
	[NumeroCuota] [int] NOT NULL,
	[MontoCuota] [decimal](18, 2) NOT NULL,
	[FechaVencimiento] [date] NOT NULL,
	[Estado] [nvarchar](50) NULL,
	[FechaPago] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[CuotaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prestamos]    Script Date: 5/12/2024 17:56:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prestamos](
	[PrestamoID] [int] IDENTITY(1,1) NOT NULL,
	[ClienteID] [int] NOT NULL,
	[MontoTotal] [decimal](18, 2) NOT NULL,
	[MontoConIntereses] [decimal](18, 2) NOT NULL,
	[TasaInteres] [decimal](5, 2) NOT NULL,
	[FechaPrestamo] [date] NOT NULL,
	[FechaVencimiento] [date] NOT NULL,
	[Estado] [nvarchar](50) NOT NULL,
	[NumeroCuotas] [int] NOT NULL,
	[FrecuenciaPago] [nvarchar](50) NOT NULL,
	[EstadoAprobacion] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[PrestamoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 5/12/2024 17:56:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RolID] [int] IDENTITY(1,1) NOT NULL,
	[NombreRol] [nvarchar](50) NOT NULL,
	[Descripcion] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[RolID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[NombreRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ClienteRoles] ADD  DEFAULT (getdate()) FOR [FechaAsignacion]
GO
ALTER TABLE [dbo].[Clientes] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[Clientes] ADD  DEFAULT ((1)) FOR [Visible]
GO
ALTER TABLE [dbo].[Cuotas] ADD  DEFAULT ('Pendiente') FOR [Estado]
GO
ALTER TABLE [dbo].[Prestamos] ADD  CONSTRAINT [DF_Prestamos_FechaPrestamo]  DEFAULT (getdate()) FOR [FechaPrestamo]
GO
ALTER TABLE [dbo].[ClienteRoles]  WITH CHECK ADD  CONSTRAINT [FK_ClienteRoles_Clientes] FOREIGN KEY([ClienteID])
REFERENCES [dbo].[Clientes] ([ClienteID])
GO
ALTER TABLE [dbo].[ClienteRoles] CHECK CONSTRAINT [FK_ClienteRoles_Clientes]
GO
ALTER TABLE [dbo].[ClienteRoles]  WITH CHECK ADD  CONSTRAINT [FK_ClienteRoles_Roles] FOREIGN KEY([RolID])
REFERENCES [dbo].[Roles] ([RolID])
GO
ALTER TABLE [dbo].[ClienteRoles] CHECK CONSTRAINT [FK_ClienteRoles_Roles]
GO
ALTER TABLE [dbo].[Cuotas]  WITH CHECK ADD  CONSTRAINT [FK_Cuota_Prestamo] FOREIGN KEY([PrestamoID])
REFERENCES [dbo].[Prestamos] ([PrestamoID])
GO
ALTER TABLE [dbo].[Cuotas] CHECK CONSTRAINT [FK_Cuota_Prestamo]
GO
ALTER TABLE [dbo].[Prestamos]  WITH CHECK ADD  CONSTRAINT [FK_Prestamo_Cliente] FOREIGN KEY([ClienteID])
REFERENCES [dbo].[Clientes] ([ClienteID])
GO
ALTER TABLE [dbo].[Prestamos] CHECK CONSTRAINT [FK_Prestamo_Cliente]
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarUltimoAcceso]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ActualizarUltimoAcceso]
    @ClienteID INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Actualizar el campo UltimoAcceso con la fecha y hora actuales
    UPDATE Clientes
    SET UltimoAcceso = GETDATE()
    WHERE ClienteID = @ClienteID;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_AsignarRolACliente]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AsignarRolACliente]
    @ClienteID INT,
    @RolID INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Insertar el rol al cliente en la tabla intermedia ClienteRoles
    IF NOT EXISTS (SELECT 1 FROM ClienteRoles WHERE ClienteID = @ClienteID AND RolID = @RolID)
    BEGIN
        INSERT INTO ClienteRoles (ClienteID, RolID)
        VALUES (@ClienteID, @RolID)
    END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_CrearCliente]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- Procedimiento para crear clientes
CREATE PROCEDURE [dbo].[sp_CrearCliente]
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @Email NVARCHAR(150),
    @Telefono NVARCHAR(20) = NULL,
    @Direccion NVARCHAR(255) = NULL,
    @Visible BIT = 1,
    @Contraseña NVARCHAR(255),
    @UltimoAcceso DATETIME = NULL
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Clientes (Nombre, Apellido, Email, Telefono, Direccion, FechaRegistro, Visible, Contraseña, UltimoAcceso)
    VALUES (@Nombre, @Apellido, @Email, @Telefono, @Direccion, GETDATE(), @Visible, @Contraseña, @UltimoAcceso);

    -- Retorna el ID del cliente recién insertado
    SELECT SCOPE_IDENTITY() AS ClienteID;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_CrearConfiguracion]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CrearConfiguracion]
    @ConfigKey NVARCHAR(100),
    @ConfigValue NVARCHAR(255),
    @ConfigDescription NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Configuracion (ConfigKey, ConfigValue, ConfigDescription)
    VALUES (@ConfigKey, @ConfigValue, @ConfigDescription);
END
GO
/****** Object:  StoredProcedure [dbo].[sp_CrearPrestamoConCuotas]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CrearPrestamoConCuotas]
    @ClienteID INT,
    @MontoTotal DECIMAL(18, 2),
    @NumeroCuotas INT,
    @FrecuenciaPago NVARCHAR(50),
    @TasaInteres DECIMAL(5, 2)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @PrestamoID INT;
    DECLARE @MontoConIntereses DECIMAL(18, 2);
    DECLARE @MontoCuota DECIMAL(18, 2);
    DECLARE @FechaVencimientoCuota DATE;
    DECLARE @IncrementoDias INT;
	DECLARE @FechaInicio DATE;  -- Declarar la variable de tipo DATE
	SET @FechaInicio = GETDATE();  -- Asignar la fecha actual a la variable


    -- Calcular el monto total a pagar con intereses
    SET @MontoConIntereses = @MontoTotal * (1 + @TasaInteres / 100);

    -- Calcular el monto de cada cuota
    SET @MontoCuota = @MontoConIntereses / @NumeroCuotas;

    -- Determinar el incremento de días según la frecuencia de pago
    SET @IncrementoDias = CASE 
                            WHEN @FrecuenciaPago = 'Mensual' THEN 30
                            WHEN @FrecuenciaPago = 'Quincenal' THEN 15
                            ELSE 30 -- Valor predeterminado si la frecuencia no es reconocida
                          END;

    -- Insertar el préstamo en la tabla de Prestamos
    INSERT INTO Prestamos (ClienteID, MontoTotal, MontoConIntereses, TasaInteres, FechaPrestamo, FechaVencimiento, Estado, NumeroCuotas, FrecuenciaPago, EstadoAprobacion)
    VALUES (@ClienteID, @MontoTotal, @MontoConIntereses, @TasaInteres, @FechaInicio, DATEADD(DAY, @IncrementoDias * @NumeroCuotas, @FechaInicio), 'Pendiente', @NumeroCuotas, @FrecuenciaPago, 'pendiente');

    -- Obtener el ID del préstamo recién insertado
    SET @PrestamoID = SCOPE_IDENTITY();

    -- Generar y registrar cada cuota
    SET @FechaVencimientoCuota = @FechaInicio;

    DECLARE @Contador INT = 1;
    WHILE @Contador <= @NumeroCuotas
    BEGIN
        -- Insertar cada cuota en la tabla Cuotas
        INSERT INTO Cuotas (PrestamoID, NumeroCuota, MontoCuota, FechaVencimiento, Estado)
        VALUES (@PrestamoID, @Contador, @MontoCuota, @FechaVencimientoCuota, 'Pendiente');

        -- Calcular la fecha de vencimiento de la siguiente cuota
        SET @FechaVencimientoCuota = DATEADD(DAY, @IncrementoDias, @FechaVencimientoCuota);

        -- Incrementar el contador
        SET @Contador = @Contador + 1;
    END;

    -- Devolver el ID del préstamo creado
    SELECT @PrestamoID AS PrestamoID;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarClientes]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Procedimiento para listar clientes
CREATE PROCEDURE [dbo].[sp_ListarClientes]
AS
BEGIN
    SELECT ClienteID, Nombre, Apellido, Email, Telefono, Direccion, FechaRegistro, Visible, UltimoAcceso
    FROM Clientes
    WHERE Visible = 1; -- Solo devuelve clientes activos
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarClientesPorNombre]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ListarClientesPorNombre]
    @Nombre NVARCHAR(150)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT ClienteID, Nombre, Apellido, Email, Telefono, Direccion
    FROM Clientes
    WHERE (Nombre LIKE '%' + @Nombre + '%' OR @Nombre = '')
      AND Visible = 1; -- Filtrar solo clientes visibles
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarConfiguraciones]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ListarConfiguraciones]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT ID, ConfigKey, ConfigValue, ConfigDescription
    FROM Configuracion;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarPrestamosPorCliente]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ListarPrestamosPorCliente]
    @ClienteID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        PrestamoID,
        ClienteID,
        MontoTotal,
        MontoConIntereses,
        TasaInteres,
        FechaPrestamo,
        FechaVencimiento,
        Estado
    FROM 
        Prestamos
    WHERE 
        ClienteID = @ClienteID
    ORDER BY 
        FechaPrestamo DESC;  -- Opcional: Ordenar los préstamos por la fecha de creación, del más reciente al más antiguo.
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ListarRoles]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ListarRoles]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT RolID, NombreRol, Descripcion
    FROM Roles;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarcarCuotaComoCancelada]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MarcarCuotaComoCancelada]
    @CuotaID INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Actualizar la cuota y marcarla como cancelada
    UPDATE Cuotas
    SET Estado = 'Cancelada', FechaPago = GETDATE()
    WHERE CuotaID = @CuotaID;

    -- Guardar el resultado de @@ROWCOUNT inmediatamente después de la actualización
    DECLARE @Resultado INT = @@ROWCOUNT;

    -- Verificar si la cuota fue actualizada
    IF @Resultado > 0
    BEGIN
        -- Obtener el IdPrestamo de la cuota
        DECLARE @IdPrestamo INT;
        SELECT @IdPrestamo = PrestamoID FROM Cuotas WHERE CuotaID = @CuotaID;

        -- Calcular el monto total de las cuotas canceladas para el préstamo
        DECLARE @MontoPagado DECIMAL(18, 2);
        SELECT @MontoPagado = SUM(MontoCuota) FROM Cuotas WHERE PrestamoID = @IdPrestamo AND Estado = 'Cancelada';

        -- Obtener el monto total con intereses del préstamo
        DECLARE @MontoConIntereses DECIMAL(18, 2);
        SELECT @MontoConIntereses = MontoConIntereses FROM Prestamos WHERE PrestamoID = @IdPrestamo;

        -- Si el monto pagado es igual o mayor al monto con intereses, cambiar el estado del préstamo a "Pagado"
        IF @MontoPagado >= @MontoConIntereses
        BEGIN
            UPDATE Prestamos
            SET Estado = 'Pagado'
            WHERE PrestamoID = @IdPrestamo;
        END
    END

    -- Devolver el resultado guardado anteriormente
    SELECT @Resultado AS Resultado;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_ModificarCliente]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ModificarCliente]
    @ClienteID INT,
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @Email NVARCHAR(150),
    @Telefono NVARCHAR(20),
    @Direccion NVARCHAR(255),
    @Contraseña NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF EXISTS (SELECT 1 FROM Clientes WHERE ClienteID = @ClienteID)
        BEGIN
            UPDATE Clientes
            SET 
                Nombre = CASE WHEN Nombre != @Nombre THEN @Nombre ELSE Nombre END,
                Apellido = CASE WHEN Apellido != @Apellido THEN @Apellido ELSE Apellido END,
                Email = CASE WHEN Email != @Email THEN @Email ELSE Email END,
                Telefono = CASE WHEN Telefono != @Telefono THEN @Telefono ELSE Telefono END,
                Direccion = CASE WHEN Direccion != @Direccion THEN @Direccion ELSE Direccion END,
                Contraseña = CASE WHEN Contraseña != @Contraseña THEN @Contraseña ELSE Contraseña END
            WHERE ClienteID = @ClienteID;
        END
        ELSE
        BEGIN
            RAISERROR ('Cliente no encontrado.', 16, 1);
        END
    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ModificarClienteConRoles]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Crear el procedimiento almacenado para modificar un cliente y gestionar sus roles
CREATE PROCEDURE [dbo].[sp_ModificarClienteConRoles]
    @ClienteID INT,
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @Email NVARCHAR(150),
    @Telefono NVARCHAR(20),
    @Direccion NVARCHAR(255),
    @Visible BIT,
    @Contraseña NVARCHAR(255),
    @RolesAgregar NVARCHAR(MAX),   -- IDs de roles para agregar, separados por comas (ej. '1,3,5')
    @RolesQuitar NVARCHAR(MAX)      -- IDs de roles para quitar, separados por comas (ej. '2,4')
AS
BEGIN
    SET NOCOUNT ON;

    -- Actualizar los datos del cliente
    UPDATE Clientes
    SET Nombre = @Nombre,
        Apellido = @Apellido,
        Email = @Email,
        Telefono = @Telefono,
        Direccion = @Direccion,
        Visible = @Visible,
        Contraseña = @Contraseña
    WHERE ClienteID = @ClienteID;

    -- Agregar roles al cliente
    IF @RolesAgregar IS NOT NULL AND LEN(@RolesAgregar) > 0
    BEGIN
        DECLARE @RolID INT
        DECLARE @RolesCursorAgregar CURSOR
        SET @RolesCursorAgregar = CURSOR FOR
            SELECT value FROM STRING_SPLIT(@RolesAgregar, ',')

        OPEN @RolesCursorAgregar
        FETCH NEXT FROM @RolesCursorAgregar INTO @RolID

        WHILE @@FETCH_STATUS = 0
        BEGIN
            IF NOT EXISTS (SELECT 1 FROM ClienteRoles WHERE ClienteID = @ClienteID AND RolID = @RolID)
            BEGIN
                INSERT INTO ClienteRoles (ClienteID, RolID)
                VALUES (@ClienteID, @RolID)
            END
            FETCH NEXT FROM @RolesCursorAgregar INTO @RolID
        END

        CLOSE @RolesCursorAgregar
        DEALLOCATE @RolesCursorAgregar
    END

    -- Quitar roles del cliente
    IF @RolesQuitar IS NOT NULL AND LEN(@RolesQuitar) > 0
    BEGIN
        DECLARE @RolesCursorQuitar CURSOR
        SET @RolesCursorQuitar = CURSOR FOR
            SELECT value FROM STRING_SPLIT(@RolesQuitar, ',')

        OPEN @RolesCursorQuitar
        FETCH NEXT FROM @RolesCursorQuitar INTO @RolID

        WHILE @@FETCH_STATUS = 0
        BEGIN
            DELETE FROM ClienteRoles
            WHERE ClienteID = @ClienteID AND RolID = @RolID
            FETCH NEXT FROM @RolesCursorQuitar INTO @RolID
        END

        CLOSE @RolesCursorQuitar
        DEALLOCATE @RolesCursorQuitar
    END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerClientePorID]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Crear o modificar el procedimiento almacenado
CREATE PROCEDURE [dbo].[sp_ObtenerClientePorID]
    @ClienteID INT
AS
BEGIN
SET NOCOUNT ON;

    -- Validar que se proporcione un ID válido
    IF @ClienteID IS NULL
    BEGIN
        THROW 50001, 'Debe proporcionar un ClienteID para realizar la búsqueda.', 1;
    END

    -- Obtener los datos del cliente por ID
    SELECT 
        c.ClienteID,
        c.Nombre,
        c.Apellido,
        c.Email,
		c.Contraseña,
        c.Telefono,
        c.Direccion,
        c.FechaRegistro,
        c.Visible,
        c.UltimoAcceso,
        STRING_AGG(r.NombreRol, ', ') AS Roles -- Agrupar roles en una sola columna
    FROM 
        Clientes c
    LEFT JOIN 
        ClienteRoles cr ON c.ClienteID = cr.ClienteID
    LEFT JOIN 
        Roles r ON cr.RolID = r.RolID
    WHERE 
        c.ClienteID = @ClienteID
    GROUP BY 
        c.ClienteID, c.Nombre, c.Apellido, c.Email, c.Telefono, 
        c.Direccion, c.FechaRegistro, c.Visible, c.UltimoAcceso, c.Contraseña;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerConfiguracion]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerConfiguracion]
    @ConfigKey NVARCHAR(50) -- Parámetro de entrada para la clave de configuración
AS
BEGIN
    SET NOCOUNT ON;

    -- Retornar el ConfigValue correspondiente al ConfigKey proporcionado
    SELECT ConfigValue
    FROM Configuracion
    WHERE ConfigKey = @ConfigKey;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerCuotasPorPrestamo]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerCuotasPorPrestamo]
    @PrestamoID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        CuotaID,
        PrestamoID,
        NumeroCuota,
        MontoCuota,
        FechaVencimiento,
        Estado
    FROM 
        Cuotas
    WHERE 
        PrestamoID = @PrestamoID
    ORDER BY 
        NumeroCuota;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerDetallePrestamo]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerDetallePrestamo]
    @PrestamoID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.PrestamoID,
        p.ClienteID,
        c.Nombre AS ClienteNombre,
        p.MontoTotal,
        p.MontoConIntereses,
        p.TasaInteres,
        p.NumeroCuotas,
        p.FrecuenciaPago,
        p.FechaPrestamo,
        p.FechaVencimiento,
        p.Estado,
        c.Apellido AS ClienteApellido
    FROM 
        Prestamos p
    INNER JOIN 
        Clientes c ON p.ClienteID = c.ClienteID
    WHERE 
        p.PrestamoID = @PrestamoID;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerIdPrestamoPorCuota]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerIdPrestamoPorCuota]
    @CuotaID INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Seleccionar el IdPrestamo de la tabla Cuotas dado el IdCuota
    SELECT PrestamoID
    FROM Cuotas
    WHERE CuotaID = @CuotaID;

    -- Si no se encuentra el registro, puedes manejarlo como un valor NULL
    IF @@ROWCOUNT = 0
    BEGIN
        SELECT NULL AS IdPrestamo; -- Retorna NULL si no se encuentra el IdCuota
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerMontoCancelado]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerMontoCancelado]
    @PrestamoID INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Sumar el monto de las cuotas canceladas para el préstamo específico,
    -- devolviendo 0 si no existen cuotas canceladas
    SELECT ISNULL(SUM(MontoCuota), 0) AS MontoCancelado
    FROM Cuotas
    WHERE PrestamoID = @PrestamoID AND Estado = 'Cancelada';
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPrestamosPendientesPorCliente]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerPrestamosPendientesPorCliente]
    @ClienteID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        PrestamoID,
        ClienteID,
        MontoTotal,
        MontoConIntereses,
        TasaInteres,
        FechaPrestamo,
        FechaVencimiento,
        Estado,
        NumeroCuotas,
        FrecuenciaPago
    FROM 
        Prestamos
    WHERE 
        ClienteID = @ClienteID
        AND Estado = 'Pendiente';
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPrestamosPorCliente]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerPrestamosPorCliente]
    @ClienteID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        PrestamoID,
        ClienteID,
        MontoTotal,
        MontoConIntereses,
        TasaInteres,
        FechaPrestamo,
        FechaVencimiento,
        Estado,
        NumeroCuotas,
        FrecuenciaPago
    FROM 
        Prestamos
    WHERE 
        ClienteID = @ClienteID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerRolesPorCliente]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerRolesPorCliente]
    @ClienteID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT R.RolID, R.NombreRol
    FROM Roles R
    INNER JOIN ClienteRoles CR ON R.RolID = CR.RolID
    WHERE CR.ClienteID = @ClienteID;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerTodosLosPrestamos]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerTodosLosPrestamos]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        PrestamoID,
        ClienteID,
        MontoTotal,
        MontoConIntereses,
        TasaInteres,
        FechaPrestamo,
        FechaVencimiento,
        Estado,
        NumeroCuotas,
        FrecuenciaPago
    FROM 
        Prestamos
    ORDER BY 
        FechaPrestamo DESC;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerValorConfiguracion]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerValorConfiguracion]
    @ConfigKey NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT ConfigValue
    FROM Configuracion
    WHERE ConfigKey = @ConfigKey;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ValidarClienteWeb]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ValidarClienteWeb]
    @Email NVARCHAR(150),
    @Contraseña NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ClienteID INT = NULL;
    DECLARE @EsValido BIT = 0;

    -- Validar el usuario y comparar los hashes
    IF EXISTS (
        SELECT 1
        FROM Clientes c
        JOIN ClienteRoles cr ON c.ClienteID = cr.ClienteID
        JOIN Roles r ON cr.RolID = r.RolID
        WHERE c.Email = @Email
          AND c.Contraseña = @Contraseña
          AND r.NombreRol = 'Usuario'
          AND c.Visible = 1
    )
    BEGIN
        SET @ClienteID = (SELECT ClienteID FROM Clientes WHERE Email = @Email);
        SET @EsValido = 1;
    END

    IF @EsValido = 1
    BEGIN
        UPDATE Clientes
        SET UltimoAcceso = GETDATE()
        WHERE Email = @Email;
    END

    SELECT @EsValido AS EsValido, @ClienteID AS ClienteID;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ValidarUsuario]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ValidarUsuario]
    @Email NVARCHAR(150),
    @Contraseña NVARCHAR(255),
    @Resultado INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Inicializar el resultado a 0
    SET @Resultado = 0;

    -- Verificar si el usuario existe con el rol de "Administrador"
    SELECT @Resultado = COUNT(*)
    FROM Clientes C
    INNER JOIN ClienteRoles CR ON C.ClienteID = CR.ClienteID
    INNER JOIN Roles R ON CR.RolID = R.RolID
    WHERE C.Email = @Email 
      AND C.Contraseña = @Contraseña
      AND R.NombreRol = 'Administrador'; -- Aquí aseguramos que solo los administradores puedan ingresar

    -- Nota: En una implementación real, se recomienda usar un método seguro para el almacenamiento y verificación de contraseñas
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ValidarYRegistrarUltimoAcceso]    Script Date: 5/12/2024 17:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ValidarYRegistrarUltimoAcceso]
    @Email NVARCHAR(150),
    @Contraseña NVARCHAR(255),
    @Cuenta INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Inicializar la salida en 0
    SET @Cuenta = 0;

    -- Verificar si el usuario existe con el email, contraseña, y tiene el rol de "Administrador"
    SELECT @Cuenta = COUNT(*)
    FROM Clientes C
    INNER JOIN ClienteRoles CR ON C.ClienteID = CR.ClienteID
    INNER JOIN Roles R ON CR.RolID = R.RolID
    WHERE C.Email = @Email 
      AND C.Contraseña = @Contraseña
      AND R.NombreRol = 'Administrador'; -- Aseguramos que solo los administradores sean contados

    -- Si el cliente tiene credenciales válidas y es administrador, actualizar el UltimoAcceso
    IF @Cuenta = 1
    BEGIN
        UPDATE Clientes
        SET UltimoAcceso = GETDATE()
        WHERE Email = @Email;
    END
END;
GO
