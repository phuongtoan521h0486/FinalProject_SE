USE [master]
GO
/****** Object:  Database [Mobile_Phone_Distribution_Management_System_DB]    Script Date: 5/5/2023 11:50:11 PM ******/
CREATE DATABASE [Mobile_Phone_Distribution_Management_System_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Mobile_Phone_Distribution_Management_System_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Mobile_Phone_Distribution_Management_System_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Mobile_Phone_Distribution_Management_System_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Mobile_Phone_Distribution_Management_System_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Mobile_Phone_Distribution_Management_System_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET  MULTI_USER 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET QUERY_STORE = OFF
GO
USE [Mobile_Phone_Distribution_Management_System_DB]
GO
/****** Object:  Table [dbo].[Accountant]    Script Date: 5/5/2023 11:50:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accountant](
	[AccountantID] [varchar](255) NOT NULL,
	[AccountantName] [varchar](255) NOT NULL,
	[ContactInfo] [varchar](255) NOT NULL,
	[Username] [varchar](255) NOT NULL,
	[Password] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AccountantID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeliveryNote]    Script Date: 5/5/2023 11:50:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeliveryNote](
	[DeliveryNoteNumber] [varchar](255) NOT NULL,
	[DateDelivered] [date] NOT NULL,
	[ResellerID] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DeliveryNoteNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeliveryNoteItem]    Script Date: 5/5/2023 11:50:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeliveryNoteItem](
	[DeliveryNoteNumber] [varchar](255) NOT NULL,
	[ProductID] [varchar](255) NOT NULL,
	[Quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DeliveryNoteNumber] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 5/5/2023 11:50:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderID] [varchar](255) NOT NULL,
	[OrderNumber] [varchar](255) NOT NULL,
	[DateOrdered] [date] NOT NULL,
	[ResellerID] [varchar](255) NOT NULL,
	[OrderStatus] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItem]    Script Date: 5/5/2023 11:50:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItem](
	[OrderID] [varchar](255) NOT NULL,
	[ProductID] [varchar](255) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 5/5/2023 11:50:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[PaymentID] [varchar](255) NOT NULL,
	[Amount] [decimal](10, 2) NOT NULL,
	[PaymentDate] [date] NOT NULL,
	[PaymentStatus] [varchar](255) NOT NULL,
	[OrderID] [varchar](255) NOT NULL,
	[ResellerID] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 5/5/2023 11:50:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [varchar](255) NOT NULL,
	[ProductName] [varchar](255) NOT NULL,
	[Price] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reseller]    Script Date: 5/5/2023 11:50:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reseller](
	[ResellerID] [varchar](255) NOT NULL,
	[ResellerName] [varchar](255) NOT NULL,
	[ContactInfo] [varchar](255) NOT NULL,
	[Username] [varchar](255) NOT NULL,
	[Password] [varchar](255) NOT NULL,
	[PaymentMethod] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ResellerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 5/5/2023 11:50:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[SupplierID] [varchar](255) NOT NULL,
	[SupplierName] [varchar](255) NOT NULL,
	[ContactInfo] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse]    Script Date: 5/5/2023 11:50:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse](
	[WarehouseReceiptNumber] [varchar](255) NOT NULL,
	[DateReceived] [date] NOT NULL,
	[SupplierID] [varchar](255) NOT NULL,
	[ProductID] [varchar](255) NOT NULL,
	[Quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[WarehouseReceiptNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DeliveryNote]  WITH CHECK ADD FOREIGN KEY([ResellerID])
REFERENCES [dbo].[Reseller] ([ResellerID])
GO
ALTER TABLE [dbo].[DeliveryNote]  WITH CHECK ADD FOREIGN KEY([ResellerID])
REFERENCES [dbo].[Reseller] ([ResellerID])
GO
ALTER TABLE [dbo].[DeliveryNoteItem]  WITH CHECK ADD FOREIGN KEY([DeliveryNoteNumber])
REFERENCES [dbo].[DeliveryNote] ([DeliveryNoteNumber])
GO
ALTER TABLE [dbo].[DeliveryNoteItem]  WITH CHECK ADD FOREIGN KEY([DeliveryNoteNumber])
REFERENCES [dbo].[DeliveryNote] ([DeliveryNoteNumber])
GO
ALTER TABLE [dbo].[DeliveryNoteItem]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[DeliveryNoteItem]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([ResellerID])
REFERENCES [dbo].[Reseller] ([ResellerID])
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([ResellerID])
REFERENCES [dbo].[Reseller] ([ResellerID])
GO
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD FOREIGN KEY([ResellerID])
REFERENCES [dbo].[Reseller] ([ResellerID])
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD FOREIGN KEY([ResellerID])
REFERENCES [dbo].[Reseller] ([ResellerID])
GO
ALTER TABLE [dbo].[Warehouse]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Warehouse]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Warehouse]  WITH CHECK ADD FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([SupplierID])
GO
ALTER TABLE [dbo].[Warehouse]  WITH CHECK ADD FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([SupplierID])
GO
USE [master]
GO
ALTER DATABASE [Mobile_Phone_Distribution_Management_System_DB] SET  READ_WRITE 
GO
