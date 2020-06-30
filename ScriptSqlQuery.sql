USE [PruebaTecnicaGalaxy]
GO
/****** Object:  Table [dbo].[Contrato]    Script Date: 29/06/2020 11:31:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contrato](
	[IdContrato] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Entidad] [varchar](25) NOT NULL,
	[Numero_Contrato] [int] NOT NULL,
	[Trabajador_Vinculado] [char](2) NOT NULL,
	[Fecha_Inicio] [date] NOT NULL,
	[Fecha_Finalizacion] [date] NOT NULL,
	[Numero_Identificacion] [varchar](10) NULL,
	[IdTrabajador] [int] NULL,
 CONSTRAINT [PK_Contrato] PRIMARY KEY CLUSTERED 
(
	[IdContrato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trabajador]    Script Date: 29/06/2020 11:31:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trabajador](
	[IdTrabajador] [int] IDENTITY(1,1) NOT NULL,
	[Tipo_Identificacion] [varchar](2) NOT NULL,
	[Numero_Identificacion] [varchar](10) NOT NULL,
	[Primer_Nombre] [varchar](15) NOT NULL,
	[Segundo_Nombre] [varchar](15) NOT NULL,
	[Primer_Apellido] [varchar](15) NOT NULL,
	[Segundo_Apellido] [varchar](15) NOT NULL,
	[Fecha_Nacimiento] [date] NOT NULL,
	[Edad] [int] NOT NULL,
	[Trabajador_Vinculado] [char](2) NULL,
	[IdContrato] [int] NULL,
 CONSTRAINT [PK_Trabajador] PRIMARY KEY CLUSTERED 
(
	[IdTrabajador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Contrato] ON 

INSERT [dbo].[Contrato] ([IdContrato], [Nombre_Entidad], [Numero_Contrato], [Trabajador_Vinculado], [Fecha_Inicio], [Fecha_Finalizacion], [Numero_Identificacion], [IdTrabajador]) VALUES (1, N'COMFENALCO', 10101, N'SI', CAST(N'1985-04-15' AS Date), CAST(N'2015-11-30' AS Date), NULL, NULL)
INSERT [dbo].[Contrato] ([IdContrato], [Nombre_Entidad], [Numero_Contrato], [Trabajador_Vinculado], [Fecha_Inicio], [Fecha_Finalizacion], [Numero_Identificacion], [IdTrabajador]) VALUES (2, N'GALAXY', 10102, N'NO', CAST(N'2000-06-27' AS Date), CAST(N'2020-06-30' AS Date), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Contrato] OFF
GO
SET IDENTITY_INSERT [dbo].[Trabajador] ON 

INSERT [dbo].[Trabajador] ([IdTrabajador], [Tipo_Identificacion], [Numero_Identificacion], [Primer_Nombre], [Segundo_Nombre], [Primer_Apellido], [Segundo_Apellido], [Fecha_Nacimiento], [Edad], [Trabajador_Vinculado], [IdContrato]) VALUES (1, N'CC', N'1029354986', N'DIEGO', N'LEON', N'MONTOYA', N'ARBELAEZ', CAST(N'1970-12-12' AS Date), 49, NULL, NULL)
INSERT [dbo].[Trabajador] ([IdTrabajador], [Tipo_Identificacion], [Numero_Identificacion], [Primer_Nombre], [Segundo_Nombre], [Primer_Apellido], [Segundo_Apellido], [Fecha_Nacimiento], [Edad], [Trabajador_Vinculado], [IdContrato]) VALUES (2, N'CC', N'1147254301', N'PAULA', N'ANDREA', N'ZAPATA', N'RIPOLL', CAST(N'1990-12-31' AS Date), 29, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Trabajador] OFF
GO
