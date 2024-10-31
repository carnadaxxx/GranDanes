USE [DeudasDB]
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 
GO
INSERT [dbo].[Clientes] ([ClienteID], [Nombre], [Apellido], [Email], [Telefono], [Direccion], [FechaRegistro], [Visible], [Contraseña], [UltimoAcceso]) VALUES (1, N'Juan', N'Perez', N'juan.perez@email.com', N'555-1234', N'Calle Falsa 123', CAST(N'2024-10-30' AS Date), 1, N'password', CAST(N'2024-10-31T15:03:10.810' AS DateTime))
GO
INSERT [dbo].[Clientes] ([ClienteID], [Nombre], [Apellido], [Email], [Telefono], [Direccion], [FechaRegistro], [Visible], [Contraseña], [UltimoAcceso]) VALUES (2, N'Ana', N'Garcia', N'ana.garcia@email.com', N'555-5678', N'Avenida Siempre Viva 742', CAST(N'2024-10-30' AS Date), 1, N'password', NULL)
GO
INSERT [dbo].[Clientes] ([ClienteID], [Nombre], [Apellido], [Email], [Telefono], [Direccion], [FechaRegistro], [Visible], [Contraseña], [UltimoAcceso]) VALUES (3, N'Luis', N'Martinez', N'luis.martinez@email.com', N'555-9101', N'Boulevard Central 456', CAST(N'2024-10-30' AS Date), 1, N'password', NULL)
GO
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 
GO
INSERT [dbo].[Roles] ([RolID], [NombreRol], [Descripcion]) VALUES (1, N'Administrador', N'Acceso completo al sistema')
GO
INSERT [dbo].[Roles] ([RolID], [NombreRol], [Descripcion]) VALUES (2, N'Usuario', N'Acceso básico al sistema')
GO
INSERT [dbo].[Roles] ([RolID], [NombreRol], [Descripcion]) VALUES (3, N'Supervisor', N'Acceso a reportes y supervisión')
GO
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
INSERT [dbo].[ClienteRoles] ([ClienteID], [RolID], [FechaAsignacion]) VALUES (1, 1, CAST(N'2024-10-30T20:17:01.580' AS DateTime))
GO
INSERT [dbo].[ClienteRoles] ([ClienteID], [RolID], [FechaAsignacion]) VALUES (2, 2, CAST(N'2024-10-30T20:17:01.580' AS DateTime))
GO
INSERT [dbo].[ClienteRoles] ([ClienteID], [RolID], [FechaAsignacion]) VALUES (3, 2, CAST(N'2024-10-30T20:17:01.580' AS DateTime))
GO
INSERT [dbo].[ClienteRoles] ([ClienteID], [RolID], [FechaAsignacion]) VALUES (3, 3, CAST(N'2024-10-30T20:17:01.580' AS DateTime))
GO
