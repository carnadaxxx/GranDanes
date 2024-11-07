USE [DeudasDB]
GO
/****** Object:  Table [dbo].[ClienteRoles]    Script Date: 6/11/2024 20:55:30 ******/
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
/****** Object:  Table [dbo].[Clientes]    Script Date: 6/11/2024 20:55:30 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Configuracion]    Script Date: 6/11/2024 20:55:30 ******/
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
/****** Object:  Table [dbo].[Cuotas]    Script Date: 6/11/2024 20:55:30 ******/
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
/****** Object:  Table [dbo].[Prestamos]    Script Date: 6/11/2024 20:55:30 ******/
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
PRIMARY KEY CLUSTERED 
(
	[PrestamoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 6/11/2024 20:55:30 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ClienteRoles] ([ClienteID], [RolID], [FechaAsignacion]) VALUES (1, 1, CAST(N'2024-10-30T20:17:01.580' AS DateTime))
INSERT [dbo].[ClienteRoles] ([ClienteID], [RolID], [FechaAsignacion]) VALUES (2, 2, CAST(N'2024-10-30T20:17:01.580' AS DateTime))
INSERT [dbo].[ClienteRoles] ([ClienteID], [RolID], [FechaAsignacion]) VALUES (3, 2, CAST(N'2024-10-30T20:17:01.580' AS DateTime))
INSERT [dbo].[ClienteRoles] ([ClienteID], [RolID], [FechaAsignacion]) VALUES (3, 3, CAST(N'2024-10-30T20:17:01.580' AS DateTime))
INSERT [dbo].[ClienteRoles] ([ClienteID], [RolID], [FechaAsignacion]) VALUES (4, 1, CAST(N'2024-10-31T19:39:41.583' AS DateTime))
INSERT [dbo].[ClienteRoles] ([ClienteID], [RolID], [FechaAsignacion]) VALUES (4, 2, CAST(N'2024-10-31T19:39:41.583' AS DateTime))
INSERT [dbo].[ClienteRoles] ([ClienteID], [RolID], [FechaAsignacion]) VALUES (5, 2, CAST(N'2024-10-31T20:49:08.247' AS DateTime))
INSERT [dbo].[ClienteRoles] ([ClienteID], [RolID], [FechaAsignacion]) VALUES (6, 2, CAST(N'2024-10-31T20:52:56.510' AS DateTime))
INSERT [dbo].[ClienteRoles] ([ClienteID], [RolID], [FechaAsignacion]) VALUES (1004, 2, CAST(N'2024-11-01T20:50:36.843' AS DateTime))
INSERT [dbo].[ClienteRoles] ([ClienteID], [RolID], [FechaAsignacion]) VALUES (2004, 2, CAST(N'2024-11-03T23:38:45.033' AS DateTime))
INSERT [dbo].[ClienteRoles] ([ClienteID], [RolID], [FechaAsignacion]) VALUES (2005, 2, CAST(N'2024-11-03T23:42:52.237' AS DateTime))
INSERT [dbo].[ClienteRoles] ([ClienteID], [RolID], [FechaAsignacion]) VALUES (2006, 2, CAST(N'2024-11-04T00:00:43.947' AS DateTime))
INSERT [dbo].[ClienteRoles] ([ClienteID], [RolID], [FechaAsignacion]) VALUES (2007, 2, CAST(N'2024-11-04T00:02:41.840' AS DateTime))
INSERT [dbo].[ClienteRoles] ([ClienteID], [RolID], [FechaAsignacion]) VALUES (2008, 2, CAST(N'2024-11-04T00:11:31.343' AS DateTime))
INSERT [dbo].[ClienteRoles] ([ClienteID], [RolID], [FechaAsignacion]) VALUES (2009, 2, CAST(N'2024-11-04T00:17:32.090' AS DateTime))
INSERT [dbo].[ClienteRoles] ([ClienteID], [RolID], [FechaAsignacion]) VALUES (2010, 2, CAST(N'2024-11-07T00:34:33.897' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([ClienteID], [Nombre], [Apellido], [Email], [Telefono], [Direccion], [FechaRegistro], [Visible], [Contraseña], [UltimoAcceso]) VALUES (1, N'Juan', N'Perez', N'juan.perez@email.com', N'555-1234', N'Calle Falsa 123', CAST(N'2024-10-30' AS Date), 1, N'password', CAST(N'2024-11-07T01:50:51.740' AS DateTime))
INSERT [dbo].[Clientes] ([ClienteID], [Nombre], [Apellido], [Email], [Telefono], [Direccion], [FechaRegistro], [Visible], [Contraseña], [UltimoAcceso]) VALUES (2, N'Ana', N'Garcia', N'ana.garcia@email.com', N'555-5678', N'Avenida Siempre Viva 742', CAST(N'2024-10-30' AS Date), 1, N'password', NULL)
INSERT [dbo].[Clientes] ([ClienteID], [Nombre], [Apellido], [Email], [Telefono], [Direccion], [FechaRegistro], [Visible], [Contraseña], [UltimoAcceso]) VALUES (3, N'Luis', N'Martinez', N'luis.martinez@email.com', N'555-9101', N'Boulevard Central 456', CAST(N'2024-10-30' AS Date), 1, N'password', NULL)
INSERT [dbo].[Clientes] ([ClienteID], [Nombre], [Apellido], [Email], [Telefono], [Direccion], [FechaRegistro], [Visible], [Contraseña], [UltimoAcceso]) VALUES (4, N'Wilson ', N'Coronado', N'wilson.coronado@email.com', N'952177674', N'Leticia 466', CAST(N'2024-10-31' AS Date), 1, N'password', NULL)
INSERT [dbo].[Clientes] ([ClienteID], [Nombre], [Apellido], [Email], [Telefono], [Direccion], [FechaRegistro], [Visible], [Contraseña], [UltimoAcceso]) VALUES (5, N'Fernando', N'Alvarez', N'fernando.alvarez@email.com', N'963258741', N'Santa ines 536', CAST(N'2024-10-31' AS Date), 1, N'password', NULL)
INSERT [dbo].[Clientes] ([ClienteID], [Nombre], [Apellido], [Email], [Telefono], [Direccion], [FechaRegistro], [Visible], [Contraseña], [UltimoAcceso]) VALUES (6, N'Carlos', N'Sanchez', N'carlos.sanchez@email.com', N'952654789', N'Sin Dirección Conocida', CAST(N'2024-10-31' AS Date), 1, N'password', NULL)
INSERT [dbo].[Clientes] ([ClienteID], [Nombre], [Apellido], [Email], [Telefono], [Direccion], [FechaRegistro], [Visible], [Contraseña], [UltimoAcceso]) VALUES (1004, N'Domingo', N'Peron', N'domingo.peron@email.com', N'987456321', N'No definido', CAST(N'2024-11-01' AS Date), 1, N'password', NULL)
INSERT [dbo].[Clientes] ([ClienteID], [Nombre], [Apellido], [Email], [Telefono], [Direccion], [FechaRegistro], [Visible], [Contraseña], [UltimoAcceso]) VALUES (2004, N'Luis', N'Perez', N'luis.perez@email.com', N'98741159', N'No definido', CAST(N'2024-11-03' AS Date), 1, N'password', NULL)
INSERT [dbo].[Clientes] ([ClienteID], [Nombre], [Apellido], [Email], [Telefono], [Direccion], [FechaRegistro], [Visible], [Contraseña], [UltimoAcceso]) VALUES (2005, N'Walter', N'Ramirez', N'walter.ramirez@email.com', N'753159654', N'No definida', CAST(N'2024-11-03' AS Date), 1, N'password', NULL)
INSERT [dbo].[Clientes] ([ClienteID], [Nombre], [Apellido], [Email], [Telefono], [Direccion], [FechaRegistro], [Visible], [Contraseña], [UltimoAcceso]) VALUES (2006, N'Jorge', N'Pizarro', N'jorge.pizzaro@email.com', N'963214785', N'No definida', CAST(N'2024-11-04' AS Date), 1, N'password', NULL)
INSERT [dbo].[Clientes] ([ClienteID], [Nombre], [Apellido], [Email], [Telefono], [Direccion], [FechaRegistro], [Visible], [Contraseña], [UltimoAcceso]) VALUES (2007, N'Fernando', N'Aguinaga', N'fernando.aguinaga@email.com', N'785478547', N'No definida', CAST(N'2024-11-04' AS Date), 1, N'password', NULL)
INSERT [dbo].[Clientes] ([ClienteID], [Nombre], [Apellido], [Email], [Telefono], [Direccion], [FechaRegistro], [Visible], [Contraseña], [UltimoAcceso]) VALUES (2008, N'Alberto', N'Sanchez', N'alverto.sanchez@email.com', N'741254587', N'No definida', CAST(N'2024-11-04' AS Date), 1, N'password', NULL)
INSERT [dbo].[Clientes] ([ClienteID], [Nombre], [Apellido], [Email], [Telefono], [Direccion], [FechaRegistro], [Visible], [Contraseña], [UltimoAcceso]) VALUES (2009, N'Maira', N'Perez', N'maria.perez@gmail.com', N'201050', N'No definida', CAST(N'2024-11-04' AS Date), 1, N'password', NULL)
INSERT [dbo].[Clientes] ([ClienteID], [Nombre], [Apellido], [Email], [Telefono], [Direccion], [FechaRegistro], [Visible], [Contraseña], [UltimoAcceso]) VALUES (2010, N'Paula', N'Carrasco', N'paula.carrasco@email.com', N'874-698-654', N'No definida', CAST(N'2024-11-07' AS Date), 1, N'password', NULL)
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Configuracion] ON 

INSERT [dbo].[Configuracion] ([ID], [ConfigKey], [ConfigValue], [ConfigDescription]) VALUES (1, N'MontoMinimoPrestamo', N'100', N'Este es el monto minimo por prestasmo menos de esto y saldra un error en la validación')
INSERT [dbo].[Configuracion] ([ID], [ConfigKey], [ConfigValue], [ConfigDescription]) VALUES (2, N'TasaInteresPorDefecto', N'10', N'Esta es la tasa de interes por defecto si no se especifica entonces esta es la que va')
INSERT [dbo].[Configuracion] ([ID], [ConfigKey], [ConfigValue], [ConfigDescription]) VALUES (3, N'NumeroDeCuotasPorDefecto', N'5', N'Este es el numero de cuotas por defecto si no se espesifica este sera el numero por defecto')
INSERT [dbo].[Configuracion] ([ID], [ConfigKey], [ConfigValue], [ConfigDescription]) VALUES (4, N'NumeroPrestamosSinPagarPorCliente', N'3', N'Si el cliente tiene este numero de prestamos sin pagar entonces no se le permite crear otro hasta que pague')
SET IDENTITY_INSERT [dbo].[Configuracion] OFF
GO
SET IDENTITY_INSERT [dbo].[Cuotas] ON 

INSERT [dbo].[Cuotas] ([CuotaID], [PrestamoID], [NumeroCuota], [MontoCuota], [FechaVencimiento], [Estado], [FechaPago]) VALUES (1, 1, 1, CAST(110.00 AS Decimal(18, 2)), CAST(N'2024-11-06' AS Date), N'Cancelada', NULL)
INSERT [dbo].[Cuotas] ([CuotaID], [PrestamoID], [NumeroCuota], [MontoCuota], [FechaVencimiento], [Estado], [FechaPago]) VALUES (2, 1, 2, CAST(110.00 AS Decimal(18, 2)), CAST(N'2024-12-06' AS Date), N'Cancelada', NULL)
INSERT [dbo].[Cuotas] ([CuotaID], [PrestamoID], [NumeroCuota], [MontoCuota], [FechaVencimiento], [Estado], [FechaPago]) VALUES (3, 1, 3, CAST(110.00 AS Decimal(18, 2)), CAST(N'2025-01-05' AS Date), N'Cancelada', CAST(N'2024-11-07' AS Date))
INSERT [dbo].[Cuotas] ([CuotaID], [PrestamoID], [NumeroCuota], [MontoCuota], [FechaVencimiento], [Estado], [FechaPago]) VALUES (4, 1, 4, CAST(110.00 AS Decimal(18, 2)), CAST(N'2025-02-04' AS Date), N'Pendiente', NULL)
INSERT [dbo].[Cuotas] ([CuotaID], [PrestamoID], [NumeroCuota], [MontoCuota], [FechaVencimiento], [Estado], [FechaPago]) VALUES (5, 1, 5, CAST(110.00 AS Decimal(18, 2)), CAST(N'2025-03-06' AS Date), N'Pendiente', NULL)
INSERT [dbo].[Cuotas] ([CuotaID], [PrestamoID], [NumeroCuota], [MontoCuota], [FechaVencimiento], [Estado], [FechaPago]) VALUES (6, 2, 1, CAST(110.00 AS Decimal(18, 2)), CAST(N'2024-11-06' AS Date), N'Pendiente', NULL)
INSERT [dbo].[Cuotas] ([CuotaID], [PrestamoID], [NumeroCuota], [MontoCuota], [FechaVencimiento], [Estado], [FechaPago]) VALUES (7, 2, 2, CAST(110.00 AS Decimal(18, 2)), CAST(N'2024-12-06' AS Date), N'Pendiente', NULL)
INSERT [dbo].[Cuotas] ([CuotaID], [PrestamoID], [NumeroCuota], [MontoCuota], [FechaVencimiento], [Estado], [FechaPago]) VALUES (8, 2, 3, CAST(110.00 AS Decimal(18, 2)), CAST(N'2025-01-05' AS Date), N'Pendiente', NULL)
INSERT [dbo].[Cuotas] ([CuotaID], [PrestamoID], [NumeroCuota], [MontoCuota], [FechaVencimiento], [Estado], [FechaPago]) VALUES (9, 2, 4, CAST(110.00 AS Decimal(18, 2)), CAST(N'2025-02-04' AS Date), N'Pendiente', NULL)
INSERT [dbo].[Cuotas] ([CuotaID], [PrestamoID], [NumeroCuota], [MontoCuota], [FechaVencimiento], [Estado], [FechaPago]) VALUES (10, 2, 5, CAST(110.00 AS Decimal(18, 2)), CAST(N'2025-03-06' AS Date), N'Pendiente', NULL)
INSERT [dbo].[Cuotas] ([CuotaID], [PrestamoID], [NumeroCuota], [MontoCuota], [FechaVencimiento], [Estado], [FechaPago]) VALUES (1002, 1002, 1, CAST(99.00 AS Decimal(18, 2)), CAST(N'2024-11-06' AS Date), N'Pendiente', NULL)
INSERT [dbo].[Cuotas] ([CuotaID], [PrestamoID], [NumeroCuota], [MontoCuota], [FechaVencimiento], [Estado], [FechaPago]) VALUES (1003, 1002, 2, CAST(99.00 AS Decimal(18, 2)), CAST(N'2024-12-06' AS Date), N'Pendiente', NULL)
INSERT [dbo].[Cuotas] ([CuotaID], [PrestamoID], [NumeroCuota], [MontoCuota], [FechaVencimiento], [Estado], [FechaPago]) VALUES (1004, 1002, 3, CAST(99.00 AS Decimal(18, 2)), CAST(N'2025-01-05' AS Date), N'Pendiente', NULL)
INSERT [dbo].[Cuotas] ([CuotaID], [PrestamoID], [NumeroCuota], [MontoCuota], [FechaVencimiento], [Estado], [FechaPago]) VALUES (1005, 1002, 4, CAST(99.00 AS Decimal(18, 2)), CAST(N'2025-02-04' AS Date), N'Pendiente', NULL)
INSERT [dbo].[Cuotas] ([CuotaID], [PrestamoID], [NumeroCuota], [MontoCuota], [FechaVencimiento], [Estado], [FechaPago]) VALUES (1006, 1002, 5, CAST(99.00 AS Decimal(18, 2)), CAST(N'2025-03-06' AS Date), N'Pendiente', NULL)
SET IDENTITY_INSERT [dbo].[Cuotas] OFF
GO
SET IDENTITY_INSERT [dbo].[Prestamos] ON 

INSERT [dbo].[Prestamos] ([PrestamoID], [ClienteID], [MontoTotal], [MontoConIntereses], [TasaInteres], [FechaPrestamo], [FechaVencimiento], [Estado], [NumeroCuotas], [FrecuenciaPago]) VALUES (1, 2, CAST(500.00 AS Decimal(18, 2)), CAST(550.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(5, 2)), CAST(N'2024-11-06' AS Date), CAST(N'2025-04-05' AS Date), N'Pendiente', 5, N'Mensual')
INSERT [dbo].[Prestamos] ([PrestamoID], [ClienteID], [MontoTotal], [MontoConIntereses], [TasaInteres], [FechaPrestamo], [FechaVencimiento], [Estado], [NumeroCuotas], [FrecuenciaPago]) VALUES (2, 2, CAST(500.00 AS Decimal(18, 2)), CAST(550.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(5, 2)), CAST(N'2024-11-06' AS Date), CAST(N'2025-04-05' AS Date), N'Pendiente', 5, N'Mensual')
INSERT [dbo].[Prestamos] ([PrestamoID], [ClienteID], [MontoTotal], [MontoConIntereses], [TasaInteres], [FechaPrestamo], [FechaVencimiento], [Estado], [NumeroCuotas], [FrecuenciaPago]) VALUES (1002, 4, CAST(450.00 AS Decimal(18, 2)), CAST(495.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(5, 2)), CAST(N'2024-11-06' AS Date), CAST(N'2025-04-05' AS Date), N'Pendiente', 5, N'Mensual')
SET IDENTITY_INSERT [dbo].[Prestamos] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RolID], [NombreRol], [Descripcion]) VALUES (1, N'Administrador', N'Acceso completo al sistema')
INSERT [dbo].[Roles] ([RolID], [NombreRol], [Descripcion]) VALUES (2, N'Usuario', N'Acceso básico al sistema')
INSERT [dbo].[Roles] ([RolID], [NombreRol], [Descripcion]) VALUES (3, N'Supervisor', N'Acceso a reportes y supervisión')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Clientes__A9D10534778702D4]    Script Date: 6/11/2024 20:55:30 ******/
ALTER TABLE [dbo].[Clientes] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Roles__4F0B537FE33BDB47]    Script Date: 6/11/2024 20:55:30 ******/
ALTER TABLE [dbo].[Roles] ADD UNIQUE NONCLUSTERED 
(
	[NombreRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
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
/****** Object:  StoredProcedure [dbo].[sp_ActualizarUltimoAcceso]    Script Date: 6/11/2024 20:55:30 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_AsignarRolACliente]    Script Date: 6/11/2024 20:55:30 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_CrearCliente]    Script Date: 6/11/2024 20:55:30 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_CrearConfiguracion]    Script Date: 6/11/2024 20:55:30 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_CrearPrestamoConCuotas]    Script Date: 6/11/2024 20:55:30 ******/
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
    INSERT INTO Prestamos (ClienteID, MontoTotal, MontoConIntereses, TasaInteres, FechaPrestamo, FechaVencimiento, Estado, NumeroCuotas, FrecuenciaPago)
    VALUES (@ClienteID, @MontoTotal, @MontoConIntereses, @TasaInteres, @FechaInicio, DATEADD(DAY, @IncrementoDias * @NumeroCuotas, @FechaInicio), 'Pendiente', @NumeroCuotas, @FrecuenciaPago);

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
/****** Object:  StoredProcedure [dbo].[sp_ListarClientes]    Script Date: 6/11/2024 20:55:30 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ListarClientesPorNombre]    Script Date: 6/11/2024 20:55:30 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ListarConfiguraciones]    Script Date: 6/11/2024 20:55:30 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ListarPrestamosPorCliente]    Script Date: 6/11/2024 20:55:30 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ListarRoles]    Script Date: 6/11/2024 20:55:30 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_MarcarCuotaComoCancelada]    Script Date: 6/11/2024 20:55:30 ******/
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
    
    -- Devolver el resultado
    SELECT CASE 
            WHEN @@ROWCOUNT > 0 THEN 1 -- Indica que la actualización fue exitosa
            ELSE 0 -- Indica que no se encontró la cuota o no se pudo actualizar
           END AS Resultado;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ModificarCliente]    Script Date: 6/11/2024 20:55:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ModificarCliente]
    @ClienteID INT,
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @Email NVARCHAR(100),
    @Telefono NVARCHAR(50),
    @Direccion NVARCHAR(200),
    @FechaRegistro DATE,
    @Visible BIT,
    @Contraseña NVARCHAR(100),
    @UltimoAcceso DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    -- Actualizar los datos del cliente en la tabla Clientes
    UPDATE Clientes
    SET 
        Nombre = @Nombre,
        Apellido = @Apellido,
        Email = @Email,
        Telefono = @Telefono,
        Direccion = @Direccion,
        FechaRegistro = @FechaRegistro,
        Visible = @Visible,
        Contraseña = @Contraseña,
        UltimoAcceso = @UltimoAcceso
    WHERE ClienteID = @ClienteID;

    -- Devolver un mensaje de confirmación
    SELECT 'Cliente actualizado exitosamente' AS Mensaje;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerConfiguracion]    Script Date: 6/11/2024 20:55:30 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ObtenerCuotasPorPrestamo]    Script Date: 6/11/2024 20:55:30 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ObtenerDetallePrestamo]    Script Date: 6/11/2024 20:55:30 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ObtenerMontoCancelado]    Script Date: 6/11/2024 20:55:30 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPrestamosPorCliente]    Script Date: 6/11/2024 20:55:30 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ObtenerTodosLosPrestamos]    Script Date: 6/11/2024 20:55:30 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ObtenerValorConfiguracion]    Script Date: 6/11/2024 20:55:30 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ValidarUsuario]    Script Date: 6/11/2024 20:55:30 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ValidarYRegistrarUltimoAcceso]    Script Date: 6/11/2024 20:55:30 ******/
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
