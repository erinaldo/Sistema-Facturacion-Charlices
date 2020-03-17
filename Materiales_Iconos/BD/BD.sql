USE [master]
GO
/****** Object:  Database [Facturacion-SociioCoding]    Script Date: 17/03/2020 7:30:49 ******/
CREATE DATABASE [Facturacion-SociioCoding]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Facturacion-SociioCoding', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Facturacion-SociioCoding.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Facturacion-SociioCoding_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Facturacion-SociioCoding_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Facturacion-SociioCoding] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Facturacion-SociioCoding].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Facturacion-SociioCoding] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET ARITHABORT OFF 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET RECOVERY FULL 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET  MULTI_USER 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Facturacion-SociioCoding] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Facturacion-SociioCoding] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Facturacion-SociioCoding', N'ON'
GO
ALTER DATABASE [Facturacion-SociioCoding] SET QUERY_STORE = OFF
GO
USE [Facturacion-SociioCoding]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 17/03/2020 7:30:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](15) NOT NULL,
	[nombre] [varchar](25) NOT NULL,
	[estado] [bit] NOT NULL,
	[cocina] [bit] NOT NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 17/03/2020 7:30:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](15) NOT NULL,
	[nombre_completo] [varchar](35) NOT NULL,
	[telefono] [varchar](15) NULL,
	[direccion] [varchar](40) NULL,
	[tipo_cliente] [tinyint] NOT NULL,
	[correo] [varchar](60) NULL,
	[estado] [bit] NOT NULL,
	[cla_rnc] [varchar](25) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Combrobantes]    Script Date: 17/03/2020 7:30:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Combrobantes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](40) NOT NULL,
	[serie] [varchar](5) NOT NULL,
	[usados] [int] NOT NULL,
	[cantidad_limite] [int] NOT NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Combrobantes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalles_Facturas]    Script Date: 17/03/2020 7:30:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalles_Facturas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_factura] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[cantidad_producto] [int] NOT NULL,
	[precio_producto] [float] NOT NULL,
	[itbis] [float] NOT NULL,
 CONSTRAINT [PK_Detalles_Facturas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalles_Ordenes]    Script Date: 17/03/2020 7:30:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalles_Ordenes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[orden_id] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[cantidad_producto] [int] NOT NULL,
	[precio_producto] [float] NOT NULL,
	[itbis] [float] NOT NULL,
 CONSTRAINT [PK_Detalles_Ordenes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 17/03/2020 7:30:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[fecha] [datetime2](7) NOT NULL,
	[descuento] [float] NOT NULL,
	[total] [float] NOT NULL,
	[subtotal] [float] NOT NULL,
	[itbis_total] [float] NOT NULL,
	[NFC_comprobante] [varchar](12) NOT NULL,
	[comprobante_id] [int] NOT NULL,
	[usuario_vendedor_id] [int] NOT NULL,
	[metodo_pago_id] [int] NOT NULL,
	[usuario_cajero_id] [int] NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_Facturas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Metodos_Pagos]    Script Date: 17/03/2020 7:30:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Metodos_Pagos](
	[id] [int] NOT NULL,
	[nombre] [varchar](35) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_Metodos_Pagos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordenes_Reservadas]    Script Date: 17/03/2020 7:30:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordenes_Reservadas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[estado] [bit] NOT NULL,
	[fecha] [datetime2](7) NOT NULL,
	[id_mesera] [int] NOT NULL,
 CONSTRAINT [PK_Ordenes_Reservadas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 17/03/2020 7:30:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](15) NOT NULL,
	[nombre] [varchar](35) NOT NULL,
	[id_categoria] [int] NOT NULL,
	[precio_normal] [decimal](18, 0) NOT NULL,
	[precio_empleado] [decimal](18, 0) NOT NULL,
	[precio_empresa] [decimal](18, 0) NOT NULL,
	[id_unidad_medida] [int] NOT NULL,
	[tipo_producto] [tinyint] NOT NULL,
	[itbis] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[re_orden] [int] NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suplidores]    Script Date: 17/03/2020 7:30:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suplidores](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](15) NOT NULL,
	[nombre_completo] [varchar](35) NOT NULL,
	[cla_rnc] [varchar](25) NULL,
	[telefono] [varchar](15) NULL,
	[direccion] [varchar](40) NULL,
	[correo] [varchar](60) NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_Suplidores] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unidades_medidas]    Script Date: 17/03/2020 7:30:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unidades_medidas](
	[id] [int] NOT NULL,
	[nombre] [varchar](35) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_unidad_medida] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 17/03/2020 7:30:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](15) NOT NULL,
	[nombre_completo] [varchar](35) NOT NULL,
	[usuario] [varchar](35) NOT NULL,
	[password] [varchar](15) NOT NULL,
	[tipo_usuario] [int] NOT NULL,
	[ced_rnc] [varchar](25) NULL,
	[telefono] [varchar](15) NULL,
	[direccion] [varchar](40) NULL,
	[correo] [varchar](60) NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON 

INSERT [dbo].[Categorias] ([id], [codigo], [nombre], [estado], [cocina]) VALUES (1, N'1', N'Jugos', 1, 0)
INSERT [dbo].[Categorias] ([id], [codigo], [nombre], [estado], [cocina]) VALUES (2, N'2', N'Carne', 1, 1)
SET IDENTITY_INSERT [dbo].[Categorias] OFF
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([id], [codigo], [nombre_completo], [telefono], [direccion], [tipo_cliente], [correo], [estado], [cla_rnc]) VALUES (0, N'1', N'Pedro Martinez', N'', N'', 2, N'', 1, NULL)
SET IDENTITY_INSERT [dbo].[Clientes] OFF
SET IDENTITY_INSERT [dbo].[Combrobantes] ON 

INSERT [dbo].[Combrobantes] ([id], [tipo], [serie], [usados], [cantidad_limite], [estado]) VALUES (1, N'COMPROBANTE GUBERNAMENTALES', N'B15', 9, 200, 1)
INSERT [dbo].[Combrobantes] ([id], [tipo], [serie], [usados], [cantidad_limite], [estado]) VALUES (2, N'FACTURAS DE CREDITO FISCAL', N'B01', 15, 150, 1)
INSERT [dbo].[Combrobantes] ([id], [tipo], [serie], [usados], [cantidad_limite], [estado]) VALUES (3, N'REGIMENES ESPECIALES DE TRIBUTACION', N'B14', 15, 150, 1)
INSERT [dbo].[Combrobantes] ([id], [tipo], [serie], [usados], [cantidad_limite], [estado]) VALUES (4, N'FACTURAS DE CONSUMO', N'B02', 21, 150, 1)
INSERT [dbo].[Combrobantes] ([id], [tipo], [serie], [usados], [cantidad_limite], [estado]) VALUES (5, N'SIN COMPROBANTE', N'0', 0, 0, 1)
SET IDENTITY_INSERT [dbo].[Combrobantes] OFF
SET IDENTITY_INSERT [dbo].[Detalles_Facturas] ON 

INSERT [dbo].[Detalles_Facturas] ([id], [id_factura], [id_producto], [cantidad_producto], [precio_producto], [itbis]) VALUES (1, 1, 6, 3, 100, 0)
INSERT [dbo].[Detalles_Facturas] ([id], [id_factura], [id_producto], [cantidad_producto], [precio_producto], [itbis]) VALUES (2, 1, 7, 3, 25, 1.5)
INSERT [dbo].[Detalles_Facturas] ([id], [id_factura], [id_producto], [cantidad_producto], [precio_producto], [itbis]) VALUES (3, 1, 10, 1, 500, 90)
INSERT [dbo].[Detalles_Facturas] ([id], [id_factura], [id_producto], [cantidad_producto], [precio_producto], [itbis]) VALUES (1002, 2, 6, 2, 50, 0)
INSERT [dbo].[Detalles_Facturas] ([id], [id_factura], [id_producto], [cantidad_producto], [precio_producto], [itbis]) VALUES (1003, 2, 7, 1, 10, 0.2)
INSERT [dbo].[Detalles_Facturas] ([id], [id_factura], [id_producto], [cantidad_producto], [precio_producto], [itbis]) VALUES (1004, 3, 6, 1, 20, 0)
INSERT [dbo].[Detalles_Facturas] ([id], [id_factura], [id_producto], [cantidad_producto], [precio_producto], [itbis]) VALUES (1005, 4, 7, 1, 5, 0.1)
INSERT [dbo].[Detalles_Facturas] ([id], [id_factura], [id_producto], [cantidad_producto], [precio_producto], [itbis]) VALUES (1006, 5, 7, 1, 10, 0.2)
SET IDENTITY_INSERT [dbo].[Detalles_Facturas] OFF
SET IDENTITY_INSERT [dbo].[Detalles_Ordenes] ON 

INSERT [dbo].[Detalles_Ordenes] ([id], [orden_id], [id_producto], [cantidad_producto], [precio_producto], [itbis]) VALUES (12, 1, 6, 1, 50, 0)
INSERT [dbo].[Detalles_Ordenes] ([id], [orden_id], [id_producto], [cantidad_producto], [precio_producto], [itbis]) VALUES (13, 1, 7, 1, 10, 0.2)
INSERT [dbo].[Detalles_Ordenes] ([id], [orden_id], [id_producto], [cantidad_producto], [precio_producto], [itbis]) VALUES (14, 2, 7, 1, 10, 0.2)
SET IDENTITY_INSERT [dbo].[Detalles_Ordenes] OFF
SET IDENTITY_INSERT [dbo].[Facturas] ON 

INSERT [dbo].[Facturas] ([id], [id_cliente], [fecha], [descuento], [total], [subtotal], [itbis_total], [NFC_comprobante], [comprobante_id], [usuario_vendedor_id], [metodo_pago_id], [usuario_cajero_id], [estado]) VALUES (1, 0, CAST(N'2020-03-12T00:00:00.0000000' AS DateTime2), 0, 875, 875, 91.5, N'prueba', 1, 1, 1, 1, 1)
INSERT [dbo].[Facturas] ([id], [id_cliente], [fecha], [descuento], [total], [subtotal], [itbis_total], [NFC_comprobante], [comprobante_id], [usuario_vendedor_id], [metodo_pago_id], [usuario_cajero_id], [estado]) VALUES (2, 0, CAST(N'2020-03-15T00:00:00.0000000' AS DateTime2), 0, 110, 110, 0.2, N'B1500000061', 1, 1, 1, 1, 0)
INSERT [dbo].[Facturas] ([id], [id_cliente], [fecha], [descuento], [total], [subtotal], [itbis_total], [NFC_comprobante], [comprobante_id], [usuario_vendedor_id], [metodo_pago_id], [usuario_cajero_id], [estado]) VALUES (3, 0, CAST(N'2020-03-15T00:00:00.0000000' AS DateTime2), 0, 20, 20, 0, N'B1500000007', 1, 1, 1, 1, 0)
INSERT [dbo].[Facturas] ([id], [id_cliente], [fecha], [descuento], [total], [subtotal], [itbis_total], [NFC_comprobante], [comprobante_id], [usuario_vendedor_id], [metodo_pago_id], [usuario_cajero_id], [estado]) VALUES (4, 0, CAST(N'2020-03-15T00:00:00.0000000' AS DateTime2), 0, 5, 5, 0.1, N'B1500000008', 1, 1, 1, 1, 0)
INSERT [dbo].[Facturas] ([id], [id_cliente], [fecha], [descuento], [total], [subtotal], [itbis_total], [NFC_comprobante], [comprobante_id], [usuario_vendedor_id], [metodo_pago_id], [usuario_cajero_id], [estado]) VALUES (5, 0, CAST(N'2020-03-17T00:00:00.0000000' AS DateTime2), 0, 10, 10, 0.2, N'B1500000009', 1, 4, 1, 4, 0)
SET IDENTITY_INSERT [dbo].[Facturas] OFF
INSERT [dbo].[Metodos_Pagos] ([id], [nombre], [estado]) VALUES (1, N'Efectivo', 1)
INSERT [dbo].[Metodos_Pagos] ([id], [nombre], [estado]) VALUES (2, N'Crédito', 1)
INSERT [dbo].[Metodos_Pagos] ([id], [nombre], [estado]) VALUES (3, N'Tarjeta', 1)
INSERT [dbo].[Metodos_Pagos] ([id], [nombre], [estado]) VALUES (4, N'Cheque', 1)
SET IDENTITY_INSERT [dbo].[Ordenes_Reservadas] ON 

INSERT [dbo].[Ordenes_Reservadas] ([id], [id_cliente], [estado], [fecha], [id_mesera]) VALUES (1, 0, 0, CAST(N'2020-03-17T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Ordenes_Reservadas] ([id], [id_cliente], [estado], [fecha], [id_mesera]) VALUES (2, 0, 1, CAST(N'2020-03-17T00:00:00.0000000' AS DateTime2), 4)
SET IDENTITY_INSERT [dbo].[Ordenes_Reservadas] OFF
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([id], [codigo], [nombre], [id_categoria], [precio_normal], [precio_empleado], [precio_empresa], [id_unidad_medida], [tipo_producto], [itbis], [cantidad], [re_orden], [estado]) VALUES (6, N'1', N'Pollo frito', 2, CAST(100 AS Decimal(18, 0)), CAST(50 AS Decimal(18, 0)), CAST(20 AS Decimal(18, 0)), 2, 1, 0, 32, 50, 1)
INSERT [dbo].[Productos] ([id], [codigo], [nombre], [id_categoria], [precio_normal], [precio_empleado], [precio_empresa], [id_unidad_medida], [tipo_producto], [itbis], [cantidad], [re_orden], [estado]) VALUES (7, N'2', N'Arroz', 1, CAST(25 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), CAST(5 AS Decimal(18, 0)), 2, 1, 2, 22, 5, 1)
INSERT [dbo].[Productos] ([id], [codigo], [nombre], [id_categoria], [precio_normal], [precio_empleado], [precio_empresa], [id_unidad_medida], [tipo_producto], [itbis], [cantidad], [re_orden], [estado]) VALUES (10, N'3', N'Pica pollo', 2, CAST(500 AS Decimal(18, 0)), CAST(500 AS Decimal(18, 0)), CAST(500 AS Decimal(18, 0)), 1, 2, 18, 0, 0, 1)
INSERT [dbo].[Productos] ([id], [codigo], [nombre], [id_categoria], [precio_normal], [precio_empleado], [precio_empresa], [id_unidad_medida], [tipo_producto], [itbis], [cantidad], [re_orden], [estado]) VALUES (11, N'6', N'CARNE FRITA', 2, CAST(27 AS Decimal(18, 0)), CAST(27 AS Decimal(18, 0)), CAST(27 AS Decimal(18, 0)), 1, 1, 0, 20, 0, 1)
SET IDENTITY_INSERT [dbo].[Productos] OFF
SET IDENTITY_INSERT [dbo].[Suplidores] ON 

INSERT [dbo].[Suplidores] ([id], [codigo], [nombre_completo], [cla_rnc], [telefono], [direccion], [correo], [estado]) VALUES (1, N'1', N'Pedro', N'', N'', N'', N'', 1)
INSERT [dbo].[Suplidores] ([id], [codigo], [nombre_completo], [cla_rnc], [telefono], [direccion], [correo], [estado]) VALUES (2, N'2', N'Maria', N'44', N'34534', N'dfg', N'dfg', 1)
SET IDENTITY_INSERT [dbo].[Suplidores] OFF
INSERT [dbo].[Unidades_medidas] ([id], [nombre], [estado]) VALUES (1, N'Libras', 1)
INSERT [dbo].[Unidades_medidas] ([id], [nombre], [estado]) VALUES (2, N'Paquetes', 1)
INSERT [dbo].[Unidades_medidas] ([id], [nombre], [estado]) VALUES (3, N'sdf', 1)
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([id], [codigo], [nombre_completo], [usuario], [password], [tipo_usuario], [ced_rnc], [telefono], [direccion], [correo], [estado]) VALUES (1, N'1', N'Edgar Tavarez', N'edgar004', N'12345', 1, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Usuarios] ([id], [codigo], [nombre_completo], [usuario], [password], [tipo_usuario], [ced_rnc], [telefono], [direccion], [correo], [estado]) VALUES (3, N'2', N'Yeri', N'yeri002', N'2342', 1, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Usuarios] ([id], [codigo], [nombre_completo], [usuario], [password], [tipo_usuario], [ced_rnc], [telefono], [direccion], [correo], [estado]) VALUES (4, N'3', N'Juan', N'juan42', N'3', 2, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Usuarios] ([id], [codigo], [nombre_completo], [usuario], [password], [tipo_usuario], [ced_rnc], [telefono], [direccion], [correo], [estado]) VALUES (5, N'4', N'Pedrito', N'pedrit004', N'1234', 2, N'asdad', N'8095624712', N'jbjh', N'mnjhj', 0)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
ALTER TABLE [dbo].[Categorias] ADD  CONSTRAINT [DF_Categorias_estado]  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Categorias] ADD  CONSTRAINT [DF_Categorias_cocina]  DEFAULT ((0)) FOR [cocina]
GO
ALTER TABLE [dbo].[Clientes] ADD  CONSTRAINT [DF_Clientes_estado]  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Facturas] ADD  CONSTRAINT [DF_Facturas_fecha]  DEFAULT (sysdatetime()) FOR [fecha]
GO
ALTER TABLE [dbo].[Facturas] ADD  CONSTRAINT [DF_Facturas_estado]  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Metodos_Pagos] ADD  CONSTRAINT [DF_Metodos_Pagos_estado]  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Ordenes_Reservadas] ADD  CONSTRAINT [DF_Ordenes_Reservadas_estado]  DEFAULT ((0)) FOR [estado]
GO
ALTER TABLE [dbo].[Ordenes_Reservadas] ADD  CONSTRAINT [DF_Ordenes_Reservadas_fecha]  DEFAULT (sysdatetime()) FOR [fecha]
GO
ALTER TABLE [dbo].[Suplidores] ADD  CONSTRAINT [DF_Suplidores_estado]  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Unidades_medidas] ADD  CONSTRAINT [DF_Unidades_medidas_estado]  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_estado]  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Detalles_Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Detalles_Facturas_Facturas] FOREIGN KEY([id_factura])
REFERENCES [dbo].[Facturas] ([id])
GO
ALTER TABLE [dbo].[Detalles_Facturas] CHECK CONSTRAINT [FK_Detalles_Facturas_Facturas]
GO
ALTER TABLE [dbo].[Detalles_Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Detalles_Facturas_PRODUCTO] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id])
GO
ALTER TABLE [dbo].[Detalles_Facturas] CHECK CONSTRAINT [FK_Detalles_Facturas_PRODUCTO]
GO
ALTER TABLE [dbo].[Detalles_Ordenes]  WITH CHECK ADD  CONSTRAINT [FK_Detalles_ORDEN_PRODUCTO] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id])
GO
ALTER TABLE [dbo].[Detalles_Ordenes] CHECK CONSTRAINT [FK_Detalles_ORDEN_PRODUCTO]
GO
ALTER TABLE [dbo].[Detalles_Ordenes]  WITH CHECK ADD  CONSTRAINT [FK_ORDEN] FOREIGN KEY([orden_id])
REFERENCES [dbo].[Ordenes_Reservadas] ([id])
GO
ALTER TABLE [dbo].[Detalles_Ordenes] CHECK CONSTRAINT [FK_ORDEN]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_CAJERO] FOREIGN KEY([usuario_cajero_id])
REFERENCES [dbo].[Usuarios] ([id])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_CAJERO]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_CLIENTE] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_CLIENTE]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_COMBROBANTE] FOREIGN KEY([comprobante_id])
REFERENCES [dbo].[Combrobantes] ([id])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_COMBROBANTE]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_METOGO_PAGO] FOREIGN KEY([metodo_pago_id])
REFERENCES [dbo].[Metodos_Pagos] ([id])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_METOGO_PAGO]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_VENDEDOR] FOREIGN KEY([usuario_vendedor_id])
REFERENCES [dbo].[Usuarios] ([id])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_VENDEDOR]
GO
ALTER TABLE [dbo].[Ordenes_Reservadas]  WITH CHECK ADD  CONSTRAINT [FK_CLIENTES] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id])
GO
ALTER TABLE [dbo].[Ordenes_Reservadas] CHECK CONSTRAINT [FK_CLIENTES]
GO
ALTER TABLE [dbo].[Ordenes_Reservadas]  WITH CHECK ADD  CONSTRAINT [FK_MESERA] FOREIGN KEY([id_mesera])
REFERENCES [dbo].[Usuarios] ([id])
GO
ALTER TABLE [dbo].[Ordenes_Reservadas] CHECK CONSTRAINT [FK_MESERA]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_CATEGORIAS] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categorias] ([id])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_CATEGORIAS]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_UNIDADES_MEDIDAS] FOREIGN KEY([id_unidad_medida])
REFERENCES [dbo].[Unidades_medidas] ([id])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_UNIDADES_MEDIDAS]
GO
/****** Object:  StoredProcedure [dbo].[FACT]    Script Date: 17/03/2020 7:30:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[FACT]
@CODIGOFACT int
as 
SELECT
    clientes.nombre_completo,
	clientes.cla_rnc,
	clientes.direccion,		
    CONCAT ('FAC',RIGHT('000000'+CAST(facturas.id as varchar), 8)) as id_facFormato,
	facturas.fecha,
    detalles_facturas.cantidad_producto,
	detalles_facturas.itbis,
    productos.tipo_producto,
	productos.codigo,
	productos.nombre,
	Combrobantes.tipo,
	facturas.NFC_comprobante,
    CONCAT('RD$',cast (detalles_facturas.precio_producto as decimal(18,2))) as precio_producto,
	CONCAT('RD$',cast((
        (
            detalles_facturas.itbis
        )) as decimal (18,2)))
     AS itbis_producto,
    
    CONCAT('RD$',cast ((
        detalles_facturas.cantidad_producto * detalles_facturas.precio_producto
    ) as decimal(18,2))) AS total_factura,
	CONCAT('RD$', cast (facturas.subtotal as decimal(18,2))) as subtotal_factura, 
    CONCAT('RD$',cast (facturas.itbis_total as decimal(18,2))) as itbisTotal_factura,
    CONCAT('RD$',cast (facturas.total as decimal(18,2) )) as total_factura
FROM
   facturas
INNER JOIN detalles_facturas ON facturas.id = detalles_facturas.id_factura
INNER JOIN clientes ON clientes.id = facturas.id_cliente
INNER JOIN productos ON productos.id = detalles_facturas.id_producto INNER JOIN Combrobantes on facturas.comprobante_id = Combrobantes.id
WHERE
    facturas.id =@CODIGOFACT
GO
USE [master]
GO
ALTER DATABASE [Facturacion-SociioCoding] SET  READ_WRITE 
GO
