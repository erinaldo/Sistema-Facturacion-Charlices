USE [master]
GO
/****** Object:  Database [Facturacion-SociioCoding]    Script Date: 08/04/2020 8:11:15 ******/
CREATE DATABASE [Facturacion-SociioCoding]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Facturacion-SociioCoding', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Facturacion-SociioCoding.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Facturacion-SociioCoding_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Facturacion-SociioCoding_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
/****** Object:  Table [dbo].[Aperturas_Cajas]    Script Date: 08/04/2020 8:11:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aperturas_Cajas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[monto_inicial] [float] NOT NULL,
 CONSTRAINT [PK_Aperturas_Cajas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 08/04/2020 8:11:16 ******/
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
/****** Object:  Table [dbo].[Cierre_Caja]    Script Date: 08/04/2020 8:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cierre_Caja](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[total_vendido] [float] NOT NULL,
	[total_anulado] [float] NOT NULL,
	[entrada_caja] [float] NOT NULL,
	[salida_caja] [float] NOT NULL,
	[total_caja] [float] NOT NULL,
 CONSTRAINT [PK_Cierre_Caja] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 08/04/2020 8:11:16 ******/
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
/****** Object:  Table [dbo].[Combrobantes]    Script Date: 08/04/2020 8:11:16 ******/
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
/****** Object:  Table [dbo].[Detalles_Facturas]    Script Date: 08/04/2020 8:11:16 ******/
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
/****** Object:  Table [dbo].[Detalles_Ordenes]    Script Date: 08/04/2020 8:11:16 ******/
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
/****** Object:  Table [dbo].[Entrada_Salida_Caja]    Script Date: 08/04/2020 8:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entrada_Salida_Caja](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[monto] [float] NOT NULL,
	[motivo] [varchar](50) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[estado] [bit] NOT NULL,
	[tipo] [bit] NOT NULL,
 CONSTRAINT [PK_Entrada_Salida_Caja] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 08/04/2020 8:11:16 ******/
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
/****** Object:  Table [dbo].[Metodos_Pagos]    Script Date: 08/04/2020 8:11:16 ******/
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
/****** Object:  Table [dbo].[Ordenes_Reservadas]    Script Date: 08/04/2020 8:11:16 ******/
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
/****** Object:  Table [dbo].[Productos]    Script Date: 08/04/2020 8:11:16 ******/
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
/****** Object:  Table [dbo].[Suplidores]    Script Date: 08/04/2020 8:11:16 ******/
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
/****** Object:  Table [dbo].[Unidades_medidas]    Script Date: 08/04/2020 8:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unidades_medidas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](15) NOT NULL,
	[nombre] [varchar](35) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_unidad_medida] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 08/04/2020 8:11:16 ******/
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
ALTER TABLE [dbo].[Categorias] ADD  CONSTRAINT [DF_Categorias_estado]  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Categorias] ADD  CONSTRAINT [DF_Categorias_cocina]  DEFAULT ((0)) FOR [cocina]
GO
ALTER TABLE [dbo].[Clientes] ADD  CONSTRAINT [DF_Clientes_estado]  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Entrada_Salida_Caja] ADD  CONSTRAINT [DF_Entrada_Salida_Caja_estado]  DEFAULT ((1)) FOR [estado]
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
ALTER TABLE [dbo].[Aperturas_Cajas]  WITH CHECK ADD  CONSTRAINT [FK_USUARIO] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id])
GO
ALTER TABLE [dbo].[Aperturas_Cajas] CHECK CONSTRAINT [FK_USUARIO]
GO
ALTER TABLE [dbo].[Cierre_Caja]  WITH CHECK ADD  CONSTRAINT [FK_USUARIO_CIERRE] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id])
GO
ALTER TABLE [dbo].[Cierre_Caja] CHECK CONSTRAINT [FK_USUARIO_CIERRE]
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
ALTER TABLE [dbo].[Entrada_Salida_Caja]  WITH CHECK ADD  CONSTRAINT [FK_USUARIO_SALIDAD_ENTRADA] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id])
GO
ALTER TABLE [dbo].[Entrada_Salida_Caja] CHECK CONSTRAINT [FK_USUARIO_SALIDAD_ENTRADA]
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
/****** Object:  StoredProcedure [dbo].[FACT]    Script Date: 08/04/2020 8:11:16 ******/
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
/****** Object:  StoredProcedure [dbo].[Total_Caja]    Script Date: 08/04/2020 8:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Total_Caja]
@accion_proceso nchar(20),
@id_usuario int = null
as
declare @total_ventas float 
declare @total_anulado float 
declare @entrada_caja float 
declare @salida_caja float 
declare @total_caja float 
declare @total_apertura_caja float 


select @total_apertura_caja =  monto_inicial from Aperturas_Cajas where convert(datetime,CONVERT(varchar(10),fecha, 103),103)
= convert(datetime,CONVERT(varchar(10),getdate(), 103),103)


select @total_ventas =  sum(total) from Facturas where estado =0 and convert(datetime,CONVERT(varchar(10),fecha, 103),103)
= convert(datetime,CONVERT(varchar(10),getdate(), 103),103) and metodo_pago_id = 1 

select @total_anulado =  sum(total) from Facturas where estado =1 and convert(datetime,CONVERT(varchar(10),fecha, 103),103)
= convert(datetime,CONVERT(varchar(10),getdate(), 103),103) and metodo_pago_id = 1

select @entrada_caja =  sum(monto) from Entrada_Salida_Caja where tipo =0 and convert(datetime,CONVERT(varchar(10),fecha, 103),103)
= convert(datetime,CONVERT(varchar(10),getdate(), 103),103) and estado = 1

select @salida_caja =  sum(monto) from Entrada_Salida_Caja where tipo =1 and convert(datetime,CONVERT(varchar(10),fecha, 103),103)
= convert(datetime,CONVERT(varchar(10),getdate(), 103),103)  and estado = 1 


set  @total_ventas = ISNULL(@total_ventas,0)
set  @total_anulado = ISNULL(@total_anulado,0)
set  @entrada_caja = ISNULL(@entrada_caja,0)
set  @salida_caja = ISNULL(@salida_caja,0)


select @total_caja = (ISNULL(@total_apertura_caja,0) + ISNULL(@total_ventas,0)  + ISNULL(@entrada_caja,0)) -ISNULL(@salida_caja,0)

if(@accion_proceso='cierre_caja')
begin
insert into Cierre_Caja (fecha,id_usuario,total_vendido,total_anulado,entrada_caja,salida_caja,total_caja) 
values(GETDATE(),@id_usuario,@total_ventas,@total_anulado,@entrada_caja,@salida_caja,@total_caja) 
end


select @total_caja as total_efectivo_caja,@total_ventas as total_ventas_efectivo, @total_anulado as anulada, @total_apertura_caja as apertura_caja, @entrada_caja as entrada_caja, @salida_caja
as salida_caja




GO
USE [master]
GO
ALTER DATABASE [Facturacion-SociioCoding] SET  READ_WRITE 
GO
