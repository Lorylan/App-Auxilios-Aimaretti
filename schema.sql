USE [ProyectoAA]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 19/10/2020 0:21:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[NombreEmpresa] [nvarchar](50) NOT NULL,
	[Cuit] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](50) NOT NULL,
	[CuentaBancaria] [nvarchar](50) NULL,
	[CBU] [nvarchar](50) NULL,
	[Domicilio] [nvarchar](50) NOT NULL,
	[Observaciones] [nchar](100) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[NombreEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Combustible]    Script Date: 19/10/2020 0:21:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Combustible](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaYhora] [datetime] NOT NULL,
	[Litro] [nvarchar](50) NOT NULL,
	[Importe] [nvarchar](50) NOT NULL,
	[idUsuario] [nvarchar](50) NOT NULL,
	[idCliente] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Combustible] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PagoClienteCB]    Script Date: 19/10/2020 0:21:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PagoClienteCB](
	[ComprobanteNro] [nvarchar](50) NOT NULL,
	[FechaC] [datetime] NOT NULL,
	[Nro] [nvarchar](50) NOT NULL,
	[Banco] [nvarchar](50) NOT NULL,
	[NroCuenta] [nvarchar](50) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Monto] [nvarchar](50) NOT NULL,
	[idCliente] [nvarchar](50) NOT NULL,
	[idUsuario] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PagoClienteCB] PRIMARY KEY CLUSTERED 
(
	[ComprobanteNro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PagoClienteE]    Script Date: 19/10/2020 0:21:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PagoClienteE](
	[ComprobanteNro] [nvarchar](50) NOT NULL,
	[FechaC] [datetime] NOT NULL,
	[Monto] [nvarchar](50) NOT NULL,
	[Detalle] [nvarchar](100) NULL,
	[idCliente] [nvarchar](50) NOT NULL,
	[idUsuario] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PagoClienteE] PRIMARY KEY CLUSTERED 
(
	[ComprobanteNro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personal]    Script Date: 19/10/2020 0:21:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personal](
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Documento] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[CategoriaRegistro] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Personal] PRIMARY KEY CLUSTERED 
(
	[Documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicio]    Script Date: 19/10/2020 0:21:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Codigo] [nvarchar](50) NOT NULL,
	[idTipo] [nvarchar](50) NOT NULL,
	[Vehiculo] [nvarchar](50) NOT NULL,
	[Patente] [nvarchar](50) NOT NULL,
	[Color] [nvarchar](50) NULL,
	[Desperfecto] [nvarchar](50) NOT NULL,
	[Movil] [nvarchar](50) NULL,
	[Desde] [nvarchar](75) NOT NULL,
	[Hasta] [nvarchar](75) NOT NULL,
	[Km] [nvarchar](50) NOT NULL,
	[MontoCobrado] [nvarchar](50) NOT NULL,
	[Importe] [nvarchar](50) NOT NULL,
	[Observaciones] [nvarchar](100) NULL,
	[idCliente] [nvarchar](50) NOT NULL,
	[idUsuario] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Servicio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TarifaPactada]    Script Date: 19/10/2020 0:21:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TarifaPactada](
	[idTipo] [nvarchar](50) NOT NULL,
	[Importe] [nvarchar](50) NOT NULL,
	[idCliente] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TarifaPactada] PRIMARY KEY CLUSTERED 
(
	[idTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo]    Script Date: 19/10/2020 0:21:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo](
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tipo] PRIMARY KEY CLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 19/10/2020 0:21:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Nombre] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](512) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Cliente] ([NombreEmpresa], [Cuit], [Email], [Telefono], [CuentaBancaria], [CBU], [Domicilio], [Observaciones]) VALUES (N'empresa1', N'1111111111', N'email empresa1', N'44444444', N'22222222', N'333333', N'domicilio empresa1', N'                                                                                                    ')
GO
INSERT [dbo].[TarifaPactada] ([idTipo], [Importe], [idCliente]) VALUES (N'Extraccion', N'213', N'empresa1')
GO
INSERT [dbo].[TarifaPactada] ([idTipo], [Importe], [idCliente]) VALUES (N'Traslado', N'123', N'empresa1')
GO
INSERT [dbo].[Usuario] ([Nombre], [Contraseña]) VALUES (N'gustavo', N'c7ad44cbad762a5da0a452f9e854fdc1e0e7a52a38015f23f3eab1d80b931dd472634dfac71cd34ebc35d16ab7fb8a90c81f975113d6c7538dc69dd8de9077ec')
GO
ALTER TABLE [dbo].[Combustible]  WITH CHECK ADD  CONSTRAINT [FK_Combustible_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([NombreEmpresa])
GO
ALTER TABLE [dbo].[Combustible] CHECK CONSTRAINT [FK_Combustible_Cliente]
GO
ALTER TABLE [dbo].[Combustible]  WITH CHECK ADD  CONSTRAINT [FK_Combustible_Usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([Nombre])
GO
ALTER TABLE [dbo].[Combustible] CHECK CONSTRAINT [FK_Combustible_Usuario]
GO
ALTER TABLE [dbo].[PagoClienteCB]  WITH CHECK ADD  CONSTRAINT [FK_PagoClienteCB_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([NombreEmpresa])
GO
ALTER TABLE [dbo].[PagoClienteCB] CHECK CONSTRAINT [FK_PagoClienteCB_Cliente]
GO
ALTER TABLE [dbo].[PagoClienteCB]  WITH CHECK ADD  CONSTRAINT [FK_PagoClienteCB_Usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([Nombre])
GO
ALTER TABLE [dbo].[PagoClienteCB] CHECK CONSTRAINT [FK_PagoClienteCB_Usuario]
GO
ALTER TABLE [dbo].[PagoClienteE]  WITH CHECK ADD  CONSTRAINT [FK_PagoClienteE_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([NombreEmpresa])
GO
ALTER TABLE [dbo].[PagoClienteE] CHECK CONSTRAINT [FK_PagoClienteE_Cliente]
GO
ALTER TABLE [dbo].[PagoClienteE]  WITH CHECK ADD  CONSTRAINT [FK_PagoClienteE_Usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([Nombre])
GO
ALTER TABLE [dbo].[PagoClienteE] CHECK CONSTRAINT [FK_PagoClienteE_Usuario]
GO
ALTER TABLE [dbo].[Servicio]  WITH CHECK ADD  CONSTRAINT [FK_Servicio_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([NombreEmpresa])
GO
ALTER TABLE [dbo].[Servicio] CHECK CONSTRAINT [FK_Servicio_Cliente]
GO
ALTER TABLE [dbo].[Servicio]  WITH CHECK ADD  CONSTRAINT [FK_Servicio_Usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([Nombre])
GO
ALTER TABLE [dbo].[Servicio] CHECK CONSTRAINT [FK_Servicio_Usuario]
GO
ALTER TABLE [dbo].[TarifaPactada]  WITH CHECK ADD  CONSTRAINT [FK_TarifaPactada_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([NombreEmpresa])
GO
ALTER TABLE [dbo].[TarifaPactada] CHECK CONSTRAINT [FK_TarifaPactada_Cliente]
GO
ALTER TABLE [dbo].[Tipo]  WITH CHECK ADD  CONSTRAINT [FK_Tipo_TarifaPactada] FOREIGN KEY([Nombre])
REFERENCES [dbo].[TarifaPactada] ([idTipo])
GO
ALTER TABLE [dbo].[Tipo] CHECK CONSTRAINT [FK_Tipo_TarifaPactada]
GO
