USE [DeudasDB]
GO
/****** Object:  Table [dbo].[ClienteRoles]    Script Date: 30/10/2024 21:26:39 ******/
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
/****** Object:  Table [dbo].[Clientes]    Script Date: 30/10/2024 21:26:39 ******/
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
/****** Object:  Table [dbo].[Configuracion]    Script Date: 30/10/2024 21:26:39 ******/
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
/****** Object:  Table [dbo].[Roles]    Script Date: 30/10/2024 21:26:39 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ActualizarUltimoAcceso]    Script Date: 30/10/2024 21:26:39 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_CrearCliente]    Script Date: 30/10/2024 21:26:39 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_CrearConfiguracion]    Script Date: 30/10/2024 21:26:39 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ListarClientes]    Script Date: 30/10/2024 21:26:39 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ListarConfiguraciones]    Script Date: 30/10/2024 21:26:39 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ListarRoles]    Script Date: 30/10/2024 21:26:39 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ValidarUsuario]    Script Date: 30/10/2024 21:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Procedimiento para validar el usuario 
CREATE PROCEDURE [dbo].[sp_ValidarUsuario]
    @Email NVARCHAR(150),
    @Contraseña NVARCHAR(255),
    @Resultado INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;   

    -- Inicializar el resultado a 0
    SET @Resultado = 0;

    -- Verificar si el usuario existe con el email y la contraseña proporcionados
    SELECT @Resultado = COUNT(*)
    FROM Clientes
    WHERE Email = @Email AND Contraseña = @Contraseña; -- Asegúrate de usar un método seguro para la contraseña

    -- Nota: En una implementación real, deberías usar un método seguro para la verificación de contraseñas
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ValidarYRegistrarUltimoAcceso]    Script Date: 30/10/2024 21:26:39 ******/
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

    -- Verificar si el usuario existe con el email y la contraseña proporcionados
    SELECT @Cuenta = COUNT(*)
    FROM Clientes
    WHERE Email = @Email AND Contraseña = @Contraseña;

    -- Si las credenciales son válidas (Cuenta es 1), actualizar UltimoAcceso
    IF @Cuenta = 1
    BEGIN
        UPDATE Clientes
        SET UltimoAcceso = GETDATE()
        WHERE Email = @Email;
    END
END;
GO
