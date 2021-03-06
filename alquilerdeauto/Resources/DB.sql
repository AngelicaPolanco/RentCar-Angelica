USE [master]
GO
/****** Object:  Database [rent-cars-Angelica]    Script Date: 16/08/2017 20:58:47 ******/
CREATE DATABASE [rent-cars-Angelica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'rent-cars-Angelica', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\rent-cars-Angelica.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'rent-cars-Angelica_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\rent-cars-Angelica_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [rent-cars-Angelica] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [rent-cars-Angelica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [rent-cars-Angelica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [rent-cars-Angelica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [rent-cars-Angelica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [rent-cars-Angelica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [rent-cars-Angelica] SET ARITHABORT OFF 
GO
ALTER DATABASE [rent-cars-Angelica] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [rent-cars-Angelica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [rent-cars-Angelica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [rent-cars-Angelica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [rent-cars-Angelica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [rent-cars-Angelica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [rent-cars-Angelica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [rent-cars-Angelica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [rent-cars-Angelica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [rent-cars-Angelica] SET  DISABLE_BROKER 
GO
ALTER DATABASE [rent-cars-Angelica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [rent-cars-Angelica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [rent-cars-Angelica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [rent-cars-Angelica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [rent-cars-Angelica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [rent-cars-Angelica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [rent-cars-Angelica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [rent-cars-Angelica] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [rent-cars-Angelica] SET  MULTI_USER 
GO
ALTER DATABASE [rent-cars-Angelica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [rent-cars-Angelica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [rent-cars-Angelica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [rent-cars-Angelica] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [rent-cars-Angelica] SET DELAYED_DURABILITY = DISABLED 
GO
USE [rent-cars-Angelica]
GO
/****** Object:  Table [dbo].[autoreserva]    Script Date: 16/08/2017 20:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[autoreserva](
	[id_auto_reserva] [varchar](10) NOT NULL,
	[id_reserva] [varchar](10) NOT NULL,
	[id_vehiculo] [varchar](10) NOT NULL,
	[fecha_reserva] [datetime] NOT NULL,
	[id_cliente] [varchar](10) NOT NULL,
 CONSTRAINT [PK_autoreserva] PRIMARY KEY CLUSTERED 
(
	[id_auto_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 16/08/2017 20:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cliente](
	[id_cliente] [varchar](10) NOT NULL,
	[nombre_completo] [varchar](50) NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[cedula] [varchar](50) NOT NULL,
	[correo] [varchar](50) NOT NULL,
	[telefono_celular] [varchar](50) NOT NULL,
 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[empleado]    Script Date: 16/08/2017 20:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empleado](
	[id_empleado] [varchar](10) NOT NULL,
	[nombre_completo] [varchar](50) NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[cedula] [varchar](50) NOT NULL,
	[correo] [varchar](50) NOT NULL,
	[telefono_celular] [varchar](50) NOT NULL,
	[cargo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_empleado] PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[factura_entrega]    Script Date: 16/08/2017 20:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[factura_entrega](
	[id_factura] [varchar](10) NOT NULL,
	[id_reserva] [varchar](10) NOT NULL,
	[id_cliente] [varchar](10) NOT NULL,
	[id_vehiculo] [varchar](10) NOT NULL,
	[id_empleado] [varchar](10) NOT NULL,
	[fecha_esperada] [datetime] NOT NULL,
	[fecha_entrega] [datetime] NOT NULL,
	[monto_penalidad] [int] NOT NULL,
	[monto_pagar] [int] NOT NULL,
 CONSTRAINT [PK_factura_entrega] PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[marca]    Script Date: 16/08/2017 20:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[marca](
	[id_marca] [varchar](10) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_marca] PRIMARY KEY CLUSTERED 
(
	[id_marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[modelo]    Script Date: 16/08/2017 20:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[modelo](
	[id_modelo] [varchar](10) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[id_marca] [varchar](10) NOT NULL,
 CONSTRAINT [PK_modelo] PRIMARY KEY CLUSTERED 
(
	[id_modelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[reserva]    Script Date: 16/08/2017 20:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[reserva](
	[id_reserva] [varchar](10) NOT NULL,
	[id_cliente] [varchar](10) NOT NULL,
	[id_vehiculo] [varchar](10) NOT NULL,
	[fecha_inicio] [datetime] NOT NULL,
	[fecha_devolucion] [datetime] NOT NULL,
	[id_tipo_vehiculo] [varchar](10) NOT NULL,
	[id_empleado] [varchar](10) NOT NULL,
	[monto_pagar] [int] NOT NULL,
 CONSTRAINT [PK_reserva] PRIMARY KEY CLUSTERED 
(
	[id_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipo_vehiculo]    Script Date: 16/08/2017 20:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo_vehiculo](
	[id_tipo_vehiculo] [varchar](10) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[pasajero] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tipo_vehiculo] PRIMARY KEY CLUSTERED 
(
	[id_tipo_vehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vehiculo]    Script Date: 16/08/2017 20:58:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vehiculo](
	[id_vehiculo] [varchar](10) NOT NULL,
	[id_marca] [varchar](10) NOT NULL,
	[id_modelo] [varchar](10) NOT NULL,
	[id_tipo_vehiculo] [varchar](10) NOT NULL,
	[ano] [date] NOT NULL,
	[color] [varchar](50) NOT NULL,
	[combustible] [varchar](50) NOT NULL,
	[matricula] [varchar](50) NOT NULL,
	[precio_alquiler_dia] [int] NOT NULL,
	[estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_vehiculo] PRIMARY KEY CLUSTERED 
(
	[id_vehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[autoreserva]  WITH CHECK ADD  CONSTRAINT [FK_autoreserva_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[autoreserva] CHECK CONSTRAINT [FK_autoreserva_cliente]
GO
ALTER TABLE [dbo].[autoreserva]  WITH CHECK ADD  CONSTRAINT [FK_autoreserva_reserva] FOREIGN KEY([id_reserva])
REFERENCES [dbo].[reserva] ([id_reserva])
GO
ALTER TABLE [dbo].[autoreserva] CHECK CONSTRAINT [FK_autoreserva_reserva]
GO
ALTER TABLE [dbo].[factura_entrega]  WITH CHECK ADD  CONSTRAINT [FK_factura_entrega_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[factura_entrega] CHECK CONSTRAINT [FK_factura_entrega_cliente]
GO
ALTER TABLE [dbo].[factura_entrega]  WITH CHECK ADD  CONSTRAINT [FK_factura_entrega_empleado] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[factura_entrega] CHECK CONSTRAINT [FK_factura_entrega_empleado]
GO
ALTER TABLE [dbo].[factura_entrega]  WITH CHECK ADD  CONSTRAINT [FK_factura_entrega_reserva] FOREIGN KEY([id_reserva])
REFERENCES [dbo].[reserva] ([id_reserva])
GO
ALTER TABLE [dbo].[factura_entrega] CHECK CONSTRAINT [FK_factura_entrega_reserva]
GO
ALTER TABLE [dbo].[factura_entrega]  WITH CHECK ADD  CONSTRAINT [FK_factura_entrega_vehiculo] FOREIGN KEY([id_vehiculo])
REFERENCES [dbo].[vehiculo] ([id_vehiculo])
GO
ALTER TABLE [dbo].[factura_entrega] CHECK CONSTRAINT [FK_factura_entrega_vehiculo]
GO
ALTER TABLE [dbo].[modelo]  WITH CHECK ADD  CONSTRAINT [FK_modelo_marca] FOREIGN KEY([id_marca])
REFERENCES [dbo].[marca] ([id_marca])
GO
ALTER TABLE [dbo].[modelo] CHECK CONSTRAINT [FK_modelo_marca]
GO
ALTER TABLE [dbo].[reserva]  WITH CHECK ADD  CONSTRAINT [FK_reserva_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[reserva] CHECK CONSTRAINT [FK_reserva_cliente]
GO
ALTER TABLE [dbo].[reserva]  WITH CHECK ADD  CONSTRAINT [FK_reserva_empleado] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[reserva] CHECK CONSTRAINT [FK_reserva_empleado]
GO
ALTER TABLE [dbo].[reserva]  WITH CHECK ADD  CONSTRAINT [FK_reserva_tipo_vehiculo] FOREIGN KEY([id_tipo_vehiculo])
REFERENCES [dbo].[tipo_vehiculo] ([id_tipo_vehiculo])
GO
ALTER TABLE [dbo].[reserva] CHECK CONSTRAINT [FK_reserva_tipo_vehiculo]
GO
ALTER TABLE [dbo].[reserva]  WITH CHECK ADD  CONSTRAINT [FK_reserva_vehiculo] FOREIGN KEY([id_vehiculo])
REFERENCES [dbo].[vehiculo] ([id_vehiculo])
GO
ALTER TABLE [dbo].[reserva] CHECK CONSTRAINT [FK_reserva_vehiculo]
GO
ALTER TABLE [dbo].[vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_vehiculo_modelo] FOREIGN KEY([id_modelo])
REFERENCES [dbo].[modelo] ([id_modelo])
GO
ALTER TABLE [dbo].[vehiculo] CHECK CONSTRAINT [FK_vehiculo_modelo]
GO
ALTER TABLE [dbo].[vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_vehiculo_tipo_vehiculo] FOREIGN KEY([id_tipo_vehiculo])
REFERENCES [dbo].[tipo_vehiculo] ([id_tipo_vehiculo])
GO
ALTER TABLE [dbo].[vehiculo] CHECK CONSTRAINT [FK_vehiculo_tipo_vehiculo]
GO
USE [master]
GO
ALTER DATABASE [rent-cars-Angelica] SET  READ_WRITE 
GO
