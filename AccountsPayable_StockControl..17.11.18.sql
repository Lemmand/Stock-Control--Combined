USE [master]
GO
/****** Object:  Database [AccountsPayable]    Script Date: 11/17/2018 2:07:01 PM ******/
CREATE DATABASE [AccountsPayable]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AccountsPayable', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\AccountsPayable.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AccountsPayable_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\AccountsPayable_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [AccountsPayable] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AccountsPayable].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AccountsPayable] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AccountsPayable] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AccountsPayable] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AccountsPayable] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AccountsPayable] SET ARITHABORT OFF 
GO
ALTER DATABASE [AccountsPayable] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AccountsPayable] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AccountsPayable] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AccountsPayable] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AccountsPayable] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AccountsPayable] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AccountsPayable] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AccountsPayable] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AccountsPayable] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AccountsPayable] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AccountsPayable] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AccountsPayable] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AccountsPayable] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AccountsPayable] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AccountsPayable] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AccountsPayable] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AccountsPayable] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AccountsPayable] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AccountsPayable] SET  MULTI_USER 
GO
ALTER DATABASE [AccountsPayable] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AccountsPayable] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AccountsPayable] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AccountsPayable] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AccountsPayable] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AccountsPayable] SET QUERY_STORE = OFF
GO
USE [AccountsPayable]
GO
/****** Object:  Table [dbo].[TBL_CUSTOMERS]    Script Date: 11/17/2018 2:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_CUSTOMERS](
	[NUM_Vendor_ID] [int] NOT NULL,
	[NUM_phone] [int] NOT NULL,
	[CHR_firstname] [varchar](225) NOT NULL,
	[CHR_surname] [varchar](225) NOT NULL,
	[CHR_email] [varchar](225) NOT NULL,
	[CHR_address_] [varchar](320) NOT NULL,
	[CHR_country] [varchar](225) NOT NULL,
	[CHR_city] [varchar](225) NOT NULL,
 CONSTRAINT [PK_TBL_CUSTOMERS] PRIMARY KEY CLUSTERED 
(
	[NUM_Vendor_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_INVOICE]    Script Date: 11/17/2018 2:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_INVOICE](
	[NUM_invoiceID] [int] NOT NULL,
	[NUM_POID] [int] NOT NULL,
	[DT_created_date] [date] NOT NULL,
	[DT_due_date] [date] NOT NULL,
	[CHR_info] [varchar](320) NULL,
	[NUM_vendorID] [int] NOT NULL,
	[FT_total] [float] NULL,
	[FT_discount] [float] NULL,
	[NUM_Istatus] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[NUM_invoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_INVOICE_ITEMS]    Script Date: 11/17/2018 2:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_INVOICE_ITEMS](
	[NUM_invoiceID] [int] NOT NULL,
	[NUM_itemID] [int] NOT NULL,
	[NUM_quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NUM_invoiceID] ASC,
	[NUM_itemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_PAYMENT]    Script Date: 11/17/2018 2:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_PAYMENT](
	[NUM_PaymentID] [int] NOT NULL,
	[NUM_PaymentType] [int] NOT NULL,
	[NUM_invoiceID] [int] NULL,
	[NUM_vendorID] [int] NULL,
	[NUM_SalaryID] [int] NULL,
	[NUM_POID] [int] NULL,
	[DT_issueDate] [datetime] NULL,
	[DT_paymentDate] [datetime] NULL,
	[FT_amount] [float] NULL,
	[FT_BalanceDue] [float] NULL,
	[DT_duedate] [date] NULL,
	[FT_discount] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[NUM_PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_PAYMENT_TYPES]    Script Date: 11/17/2018 2:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_PAYMENT_TYPES](
	[NUM_PTID] [int] NOT NULL,
	[NUM_ptype] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NUM_PTID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_PO_ITEMS]    Script Date: 11/17/2018 2:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_PO_ITEMS](
	[NUM_POID] [int] NOT NULL,
	[NUM_itemID] [int] NOT NULL,
	[NUM_quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NUM_POID] ASC,
	[NUM_itemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_PRODUCT_CATEGORIES]    Script Date: 11/17/2018 2:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_PRODUCT_CATEGORIES](
	[NUM_Category_id] [int] IDENTITY(1,1) NOT NULL,
	[CHR_Category_name] [varchar](50) NOT NULL,
	[CHR_Description] [varchar](50) NULL,
 CONSTRAINT [PK_TBL_PRODUCT_CATEGORIES] PRIMARY KEY CLUSTERED 
(
	[NUM_Category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_PURCHASE_ORDER]    Script Date: 11/17/2018 2:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_PURCHASE_ORDER](
	[NUM_POID] [int] NOT NULL,
	[CHR_notes] [varchar](225) NULL,
	[NUM_userID] [int] NULL,
	[NUM_tax] [int] NULL,
	[DT_delivery_date] [date] NOT NULL,
	[DT_created_date] [date] NOT NULL,
	[CHR_terms] [varchar](320) NULL,
	[CHR_deliveryAddress] [varchar](225) NULL,
	[NUM_vendorID] [int] NULL,
	[FT_total] [float] NULL,
	[NUM_POstatus] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[NUM_POID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_RECEIPT]    Script Date: 11/17/2018 2:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_RECEIPT](
	[NUM_receiptID] [int] NOT NULL,
	[FT_amount] [float] NOT NULL,
	[DT_printDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NUM_receiptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_RECEIVED_ITEMS]    Script Date: 11/17/2018 2:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_RECEIVED_ITEMS](
	[NUM_RRID] [int] NOT NULL,
	[NUM_itemID] [int] NOT NULL,
	[NUM_quantity] [int] NOT NULL,
	[NUM_received] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NUM_RRID] ASC,
	[NUM_itemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_RECEIVING_REPORT]    Script Date: 11/17/2018 2:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_RECEIVING_REPORT](
	[NUM_RRID] [int] NOT NULL,
	[DT_delivery_date] [date] NOT NULL,
	[DT_created_date] [date] NOT NULL,
	[CHR_terms] [varchar](320) NULL,
	[NUM_POID] [int] NULL,
	[CHR_notes] [varchar](320) NULL,
	[FT_total] [float] NULL,
	[NUM_RRstatus] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[NUM_RRID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_SALARY_PAYMENTS]    Script Date: 11/17/2018 2:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_SALARY_PAYMENTS](
	[NUM_SalaryID] [int] NOT NULL,
	[NUM_userID] [int] NOT NULL,
	[NUM_salaryType] [int] NOT NULL,
	[FT_amount] [float] NOT NULL,
	[DT_paydate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[NUM_SalaryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_SALARY_TYPES]    Script Date: 11/17/2018 2:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_SALARY_TYPES](
	[NUM_STID] [int] NOT NULL,
	[NUM_stype] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NUM_STID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_SC_ITEMS]    Script Date: 11/17/2018 2:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_SC_ITEMS](
	[NUM_itemID] [int] NOT NULL,
	[CHR_item_name] [varchar](225) NOT NULL,
	[FT_price] [float] NOT NULL,
	[CHR_info] [varchar](320) NULL,
	[NUM_manufacturer] [int] NULL,
	[FT_VAT] [float] NULL,
	[NUM_Quantity] [int] NOT NULL,
	[CHR_Product_saleflag] [varchar](50) NULL,
	[NUM_Vat_category] [int] NULL,
	[NUM_Product_category] [int] NULL,
 CONSTRAINT [PK__TBL_SC_I__14637B9CAB9F51A1] PRIMARY KEY CLUSTERED 
(
	[NUM_itemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_USER]    Script Date: 11/17/2018 2:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_USER](
	[NUM_UserID] [int] NOT NULL,
	[CHR_firstname] [varchar](225) NOT NULL,
	[CHR_surname] [varchar](225) NOT NULL,
	[CHR_email] [varchar](320) NULL,
	[NUM_phone] [int] NULL,
	[CHR_city] [varchar](225) NULL,
	[CHR_country] [varchar](225) NULL,
	[CHR_username] [varchar](225) NOT NULL,
	[CHR_pass] [varchar](225) NOT NULL,
	[CHR_address] [varchar](320) NULL,
PRIMARY KEY CLUSTERED 
(
	[NUM_UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_VAT_CATEGORIES]    Script Date: 11/17/2018 2:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_VAT_CATEGORIES](
	[NUM_Vat_id] [int] IDENTITY(1,1) NOT NULL,
	[NUM_Vat_rate] [int] NOT NULL,
	[CHR_Description] [varchar](50) NULL,
 CONSTRAINT [PK_TBL_VAT_CATEGORIES] PRIMARY KEY CLUSTERED 
(
	[NUM_Vat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_VENDOR]    Script Date: 11/17/2018 2:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_VENDOR](
	[NUM_Vendor_ID] [int] NOT NULL,
	[NUM_phone] [int] NOT NULL,
	[CHR_address_] [varchar](320) NOT NULL,
	[CHR_companyName] [varchar](225) NOT NULL,
	[CHR_companyType] [varchar](225) NOT NULL,
	[CHR_country] [varchar](225) NOT NULL,
	[CHR_city] [varchar](225) NOT NULL,
	[CHR_titl] [varchar](225) NOT NULL,
	[CHR_firstname] [varchar](225) NOT NULL,
	[CHR_surname] [varchar](225) NOT NULL,
	[CHR_email] [varchar](225) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NUM_Vendor_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TBL_INVOICE] ([NUM_invoiceID], [NUM_POID], [DT_created_date], [DT_due_date], [CHR_info], [NUM_vendorID], [FT_total], [FT_discount], [NUM_Istatus]) VALUES (90902, 45452, CAST(N'2018-09-30' AS Date), CAST(N'2018-10-08' AS Date), NULL, 2346, 200, NULL, 0)
INSERT [dbo].[TBL_INVOICE] ([NUM_invoiceID], [NUM_POID], [DT_created_date], [DT_due_date], [CHR_info], [NUM_vendorID], [FT_total], [FT_discount], [NUM_Istatus]) VALUES (90903, 45451, CAST(N'2018-12-10' AS Date), CAST(N'2018-12-30' AS Date), NULL, 2345, 150, NULL, 0)
INSERT [dbo].[TBL_INVOICE] ([NUM_invoiceID], [NUM_POID], [DT_created_date], [DT_due_date], [CHR_info], [NUM_vendorID], [FT_total], [FT_discount], [NUM_Istatus]) VALUES (90904, 45451, CAST(N'2018-01-01' AS Date), CAST(N'2018-02-02' AS Date), NULL, 2345, 90, NULL, 0)
INSERT [dbo].[TBL_INVOICE] ([NUM_invoiceID], [NUM_POID], [DT_created_date], [DT_due_date], [CHR_info], [NUM_vendorID], [FT_total], [FT_discount], [NUM_Istatus]) VALUES (90905, 45454, CAST(N'2018-06-30' AS Date), CAST(N'2018-10-20' AS Date), NULL, 2347, 1350.49, NULL, 2)
INSERT [dbo].[TBL_INVOICE_ITEMS] ([NUM_invoiceID], [NUM_itemID], [NUM_quantity]) VALUES (90902, 7832, 2)
INSERT [dbo].[TBL_INVOICE_ITEMS] ([NUM_invoiceID], [NUM_itemID], [NUM_quantity]) VALUES (90902, 7867, 1)
INSERT [dbo].[TBL_INVOICE_ITEMS] ([NUM_invoiceID], [NUM_itemID], [NUM_quantity]) VALUES (90902, 7890, 1)
INSERT [dbo].[TBL_INVOICE_ITEMS] ([NUM_invoiceID], [NUM_itemID], [NUM_quantity]) VALUES (90905, 7894, 1)
INSERT [dbo].[TBL_INVOICE_ITEMS] ([NUM_invoiceID], [NUM_itemID], [NUM_quantity]) VALUES (90905, 7895, 1)
INSERT [dbo].[TBL_PAYMENT] ([NUM_PaymentID], [NUM_PaymentType], [NUM_invoiceID], [NUM_vendorID], [NUM_SalaryID], [NUM_POID], [DT_issueDate], [DT_paymentDate], [FT_amount], [FT_BalanceDue], [DT_duedate], [FT_discount]) VALUES (0, 1, 0, 0, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TBL_PAYMENT] ([NUM_PaymentID], [NUM_PaymentType], [NUM_invoiceID], [NUM_vendorID], [NUM_SalaryID], [NUM_POID], [DT_issueDate], [DT_paymentDate], [FT_amount], [FT_BalanceDue], [DT_duedate], [FT_discount]) VALUES (1, 2, 90905, 2347, NULL, 45454, NULL, CAST(N'2018-11-03T00:00:00.000' AS DateTime), 1350.49, NULL, CAST(N'2018-11-03' AS Date), NULL)
INSERT [dbo].[TBL_PAYMENT] ([NUM_PaymentID], [NUM_PaymentType], [NUM_invoiceID], [NUM_vendorID], [NUM_SalaryID], [NUM_POID], [DT_issueDate], [DT_paymentDate], [FT_amount], [FT_BalanceDue], [DT_duedate], [FT_discount]) VALUES (2, 2, 90905, 2347, NULL, 45454, NULL, CAST(N'2018-11-03T00:00:00.000' AS DateTime), 1350.49, NULL, CAST(N'2018-11-03' AS Date), NULL)
INSERT [dbo].[TBL_PAYMENT] ([NUM_PaymentID], [NUM_PaymentType], [NUM_invoiceID], [NUM_vendorID], [NUM_SalaryID], [NUM_POID], [DT_issueDate], [DT_paymentDate], [FT_amount], [FT_BalanceDue], [DT_duedate], [FT_discount]) VALUES (3, 2, 90905, 2347, NULL, 45454, NULL, CAST(N'2018-11-03T00:00:00.000' AS DateTime), 1350.49, NULL, CAST(N'2018-11-03' AS Date), NULL)
INSERT [dbo].[TBL_PAYMENT] ([NUM_PaymentID], [NUM_PaymentType], [NUM_invoiceID], [NUM_vendorID], [NUM_SalaryID], [NUM_POID], [DT_issueDate], [DT_paymentDate], [FT_amount], [FT_BalanceDue], [DT_duedate], [FT_discount]) VALUES (4, 2, 90905, 2347, NULL, 45454, NULL, CAST(N'2018-11-03T00:00:00.000' AS DateTime), 1350.49, NULL, CAST(N'2018-11-03' AS Date), NULL)
INSERT [dbo].[TBL_PAYMENT] ([NUM_PaymentID], [NUM_PaymentType], [NUM_invoiceID], [NUM_vendorID], [NUM_SalaryID], [NUM_POID], [DT_issueDate], [DT_paymentDate], [FT_amount], [FT_BalanceDue], [DT_duedate], [FT_discount]) VALUES (5, 2, 90905, 2347, NULL, 45454, NULL, CAST(N'2018-11-03T00:00:00.000' AS DateTime), 1350.49, NULL, CAST(N'2018-11-03' AS Date), NULL)
INSERT [dbo].[TBL_PAYMENT] ([NUM_PaymentID], [NUM_PaymentType], [NUM_invoiceID], [NUM_vendorID], [NUM_SalaryID], [NUM_POID], [DT_issueDate], [DT_paymentDate], [FT_amount], [FT_BalanceDue], [DT_duedate], [FT_discount]) VALUES (6, 2, 90905, 2347, NULL, 45454, NULL, CAST(N'2018-11-03T00:00:00.000' AS DateTime), 1350.49, NULL, CAST(N'2018-11-03' AS Date), NULL)
INSERT [dbo].[TBL_PAYMENT] ([NUM_PaymentID], [NUM_PaymentType], [NUM_invoiceID], [NUM_vendorID], [NUM_SalaryID], [NUM_POID], [DT_issueDate], [DT_paymentDate], [FT_amount], [FT_BalanceDue], [DT_duedate], [FT_discount]) VALUES (7, 2, 90905, 2347, NULL, 45454, NULL, CAST(N'2018-11-03T00:00:00.000' AS DateTime), 1350.49, NULL, CAST(N'2018-11-03' AS Date), NULL)
INSERT [dbo].[TBL_PAYMENT] ([NUM_PaymentID], [NUM_PaymentType], [NUM_invoiceID], [NUM_vendorID], [NUM_SalaryID], [NUM_POID], [DT_issueDate], [DT_paymentDate], [FT_amount], [FT_BalanceDue], [DT_duedate], [FT_discount]) VALUES (8, 2, 90905, 2347, NULL, 45454, NULL, CAST(N'2018-11-03T00:00:00.000' AS DateTime), 1350.49, NULL, CAST(N'2018-11-03' AS Date), NULL)
INSERT [dbo].[TBL_PAYMENT] ([NUM_PaymentID], [NUM_PaymentType], [NUM_invoiceID], [NUM_vendorID], [NUM_SalaryID], [NUM_POID], [DT_issueDate], [DT_paymentDate], [FT_amount], [FT_BalanceDue], [DT_duedate], [FT_discount]) VALUES (9, 2, 90905, 2347, NULL, 45454, NULL, CAST(N'2018-11-03T00:00:00.000' AS DateTime), 1350.49, NULL, CAST(N'2018-11-03' AS Date), NULL)
INSERT [dbo].[TBL_PAYMENT] ([NUM_PaymentID], [NUM_PaymentType], [NUM_invoiceID], [NUM_vendorID], [NUM_SalaryID], [NUM_POID], [DT_issueDate], [DT_paymentDate], [FT_amount], [FT_BalanceDue], [DT_duedate], [FT_discount]) VALUES (10, 2, 90905, 2347, NULL, 45454, NULL, CAST(N'2018-11-03T00:00:00.000' AS DateTime), 1350.49, NULL, CAST(N'2018-11-03' AS Date), NULL)
INSERT [dbo].[TBL_PAYMENT] ([NUM_PaymentID], [NUM_PaymentType], [NUM_invoiceID], [NUM_vendorID], [NUM_SalaryID], [NUM_POID], [DT_issueDate], [DT_paymentDate], [FT_amount], [FT_BalanceDue], [DT_duedate], [FT_discount]) VALUES (11, 2, 90905, 2347, NULL, 45454, NULL, CAST(N'2018-11-03T00:00:00.000' AS DateTime), 1350.49, NULL, CAST(N'2018-11-03' AS Date), NULL)
INSERT [dbo].[TBL_PAYMENT] ([NUM_PaymentID], [NUM_PaymentType], [NUM_invoiceID], [NUM_vendorID], [NUM_SalaryID], [NUM_POID], [DT_issueDate], [DT_paymentDate], [FT_amount], [FT_BalanceDue], [DT_duedate], [FT_discount]) VALUES (12, 2, 90905, 2347, NULL, 45454, NULL, CAST(N'2018-11-03T00:00:00.000' AS DateTime), 1350.49, NULL, CAST(N'2018-11-03' AS Date), NULL)
INSERT [dbo].[TBL_PAYMENT] ([NUM_PaymentID], [NUM_PaymentType], [NUM_invoiceID], [NUM_vendorID], [NUM_SalaryID], [NUM_POID], [DT_issueDate], [DT_paymentDate], [FT_amount], [FT_BalanceDue], [DT_duedate], [FT_discount]) VALUES (13, 2, 90905, 2347, NULL, 45454, NULL, CAST(N'2018-11-03T00:00:00.000' AS DateTime), 1350.49, NULL, CAST(N'2018-11-03' AS Date), NULL)
INSERT [dbo].[TBL_PAYMENT] ([NUM_PaymentID], [NUM_PaymentType], [NUM_invoiceID], [NUM_vendorID], [NUM_SalaryID], [NUM_POID], [DT_issueDate], [DT_paymentDate], [FT_amount], [FT_BalanceDue], [DT_duedate], [FT_discount]) VALUES (14, 2, 90905, 2347, NULL, 45454, NULL, CAST(N'2018-11-03T00:00:00.000' AS DateTime), 1350.49, NULL, CAST(N'2018-11-03' AS Date), NULL)
INSERT [dbo].[TBL_PAYMENT] ([NUM_PaymentID], [NUM_PaymentType], [NUM_invoiceID], [NUM_vendorID], [NUM_SalaryID], [NUM_POID], [DT_issueDate], [DT_paymentDate], [FT_amount], [FT_BalanceDue], [DT_duedate], [FT_discount]) VALUES (15, 2, 90905, 2347, NULL, 45454, NULL, CAST(N'2018-11-03T00:00:00.000' AS DateTime), 1350.49, NULL, CAST(N'2018-11-03' AS Date), NULL)
INSERT [dbo].[TBL_PAYMENT] ([NUM_PaymentID], [NUM_PaymentType], [NUM_invoiceID], [NUM_vendorID], [NUM_SalaryID], [NUM_POID], [DT_issueDate], [DT_paymentDate], [FT_amount], [FT_BalanceDue], [DT_duedate], [FT_discount]) VALUES (16, 2, 90905, 2347, NULL, 45454, NULL, CAST(N'2018-11-03T00:00:00.000' AS DateTime), 1350.49, NULL, CAST(N'2018-11-03' AS Date), NULL)
INSERT [dbo].[TBL_PAYMENT_TYPES] ([NUM_PTID], [NUM_ptype]) VALUES (1, N'Employee Salary')
INSERT [dbo].[TBL_PAYMENT_TYPES] ([NUM_PTID], [NUM_ptype]) VALUES (2, N'Invoice Payment')
INSERT [dbo].[TBL_PAYMENT_TYPES] ([NUM_PTID], [NUM_ptype]) VALUES (3, N'Other')
INSERT [dbo].[TBL_PO_ITEMS] ([NUM_POID], [NUM_itemID], [NUM_quantity]) VALUES (45451, 7812, 2)
INSERT [dbo].[TBL_PO_ITEMS] ([NUM_POID], [NUM_itemID], [NUM_quantity]) VALUES (45451, 7832, 16)
INSERT [dbo].[TBL_PO_ITEMS] ([NUM_POID], [NUM_itemID], [NUM_quantity]) VALUES (45451, 7867, 1)
INSERT [dbo].[TBL_PO_ITEMS] ([NUM_POID], [NUM_itemID], [NUM_quantity]) VALUES (45451, 7878, 1)
INSERT [dbo].[TBL_PO_ITEMS] ([NUM_POID], [NUM_itemID], [NUM_quantity]) VALUES (45451, 7890, 2)
INSERT [dbo].[TBL_PO_ITEMS] ([NUM_POID], [NUM_itemID], [NUM_quantity]) VALUES (45451, 7891, 3)
INSERT [dbo].[TBL_PO_ITEMS] ([NUM_POID], [NUM_itemID], [NUM_quantity]) VALUES (45451, 7893, 1)
INSERT [dbo].[TBL_PO_ITEMS] ([NUM_POID], [NUM_itemID], [NUM_quantity]) VALUES (45452, 7841, 1)
INSERT [dbo].[TBL_PO_ITEMS] ([NUM_POID], [NUM_itemID], [NUM_quantity]) VALUES (45452, 7864, 2)
INSERT [dbo].[TBL_PO_ITEMS] ([NUM_POID], [NUM_itemID], [NUM_quantity]) VALUES (45454, 7894, 1)
INSERT [dbo].[TBL_PO_ITEMS] ([NUM_POID], [NUM_itemID], [NUM_quantity]) VALUES (45454, 7895, 1)
INSERT [dbo].[TBL_PO_ITEMS] ([NUM_POID], [NUM_itemID], [NUM_quantity]) VALUES (45458, 7894, 8)
INSERT [dbo].[TBL_PO_ITEMS] ([NUM_POID], [NUM_itemID], [NUM_quantity]) VALUES (45462, 7894, 6)
SET IDENTITY_INSERT [dbo].[TBL_PRODUCT_CATEGORIES] ON 

INSERT [dbo].[TBL_PRODUCT_CATEGORIES] ([NUM_Category_id], [CHR_Category_name], [CHR_Description]) VALUES (1, N'Food', NULL)
SET IDENTITY_INSERT [dbo].[TBL_PRODUCT_CATEGORIES] OFF
INSERT [dbo].[TBL_PURCHASE_ORDER] ([NUM_POID], [CHR_notes], [NUM_userID], [NUM_tax], [DT_delivery_date], [DT_created_date], [CHR_terms], [CHR_deliveryAddress], [NUM_vendorID], [FT_total], [NUM_POstatus]) VALUES (45451, N'', 1234, 0, CAST(N'2018-10-18' AS Date), CAST(N'2018-10-18' AS Date), N'', NULL, 2345, 933.12, 0)
INSERT [dbo].[TBL_PURCHASE_ORDER] ([NUM_POID], [CHR_notes], [NUM_userID], [NUM_tax], [DT_delivery_date], [DT_created_date], [CHR_terms], [CHR_deliveryAddress], [NUM_vendorID], [FT_total], [NUM_POstatus]) VALUES (45452, N'', 1234, 0, CAST(N'2018-10-18' AS Date), CAST(N'2018-10-18' AS Date), N'', NULL, 2346, 64.98, 0)
INSERT [dbo].[TBL_PURCHASE_ORDER] ([NUM_POID], [CHR_notes], [NUM_userID], [NUM_tax], [DT_delivery_date], [DT_created_date], [CHR_terms], [CHR_deliveryAddress], [NUM_vendorID], [FT_total], [NUM_POstatus]) VALUES (45454, N'', NULL, 0, CAST(N'2018-10-19' AS Date), CAST(N'2018-10-19' AS Date), N'', NULL, 2347, 1349.99, 1)
INSERT [dbo].[TBL_PURCHASE_ORDER] ([NUM_POID], [CHR_notes], [NUM_userID], [NUM_tax], [DT_delivery_date], [DT_created_date], [CHR_terms], [CHR_deliveryAddress], [NUM_vendorID], [FT_total], [NUM_POstatus]) VALUES (45455, NULL, NULL, NULL, CAST(N'2018-11-13' AS Date), CAST(N'2018-11-13' AS Date), NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[TBL_PURCHASE_ORDER] ([NUM_POID], [CHR_notes], [NUM_userID], [NUM_tax], [DT_delivery_date], [DT_created_date], [CHR_terms], [CHR_deliveryAddress], [NUM_vendorID], [FT_total], [NUM_POstatus]) VALUES (45456, NULL, NULL, NULL, CAST(N'2018-11-13' AS Date), CAST(N'2018-11-13' AS Date), NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[TBL_PURCHASE_ORDER] ([NUM_POID], [CHR_notes], [NUM_userID], [NUM_tax], [DT_delivery_date], [DT_created_date], [CHR_terms], [CHR_deliveryAddress], [NUM_vendorID], [FT_total], [NUM_POstatus]) VALUES (45457, NULL, NULL, NULL, CAST(N'2018-11-13' AS Date), CAST(N'2018-11-13' AS Date), NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[TBL_PURCHASE_ORDER] ([NUM_POID], [CHR_notes], [NUM_userID], [NUM_tax], [DT_delivery_date], [DT_created_date], [CHR_terms], [CHR_deliveryAddress], [NUM_vendorID], [FT_total], [NUM_POstatus]) VALUES (45458, N'', NULL, 0, CAST(N'2018-11-13' AS Date), CAST(N'2018-11-13' AS Date), N'', NULL, 2347, 4399.92, 1)
INSERT [dbo].[TBL_PURCHASE_ORDER] ([NUM_POID], [CHR_notes], [NUM_userID], [NUM_tax], [DT_delivery_date], [DT_created_date], [CHR_terms], [CHR_deliveryAddress], [NUM_vendorID], [FT_total], [NUM_POstatus]) VALUES (45459, NULL, NULL, NULL, CAST(N'2018-11-13' AS Date), CAST(N'2018-11-13' AS Date), NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[TBL_PURCHASE_ORDER] ([NUM_POID], [CHR_notes], [NUM_userID], [NUM_tax], [DT_delivery_date], [DT_created_date], [CHR_terms], [CHR_deliveryAddress], [NUM_vendorID], [FT_total], [NUM_POstatus]) VALUES (45460, NULL, NULL, NULL, CAST(N'2018-11-13' AS Date), CAST(N'2018-11-13' AS Date), NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[TBL_PURCHASE_ORDER] ([NUM_POID], [CHR_notes], [NUM_userID], [NUM_tax], [DT_delivery_date], [DT_created_date], [CHR_terms], [CHR_deliveryAddress], [NUM_vendorID], [FT_total], [NUM_POstatus]) VALUES (45461, NULL, NULL, NULL, CAST(N'2018-11-13' AS Date), CAST(N'2018-11-13' AS Date), NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[TBL_PURCHASE_ORDER] ([NUM_POID], [CHR_notes], [NUM_userID], [NUM_tax], [DT_delivery_date], [DT_created_date], [CHR_terms], [CHR_deliveryAddress], [NUM_vendorID], [FT_total], [NUM_POstatus]) VALUES (45462, N'', NULL, 0, CAST(N'2018-11-13' AS Date), CAST(N'2018-11-13' AS Date), N'', NULL, 2347, 3299.94, 1)
INSERT [dbo].[TBL_RECEIPT] ([NUM_receiptID], [FT_amount], [DT_printDate]) VALUES (6161, 90, CAST(N'2018-10-07' AS Date))
INSERT [dbo].[TBL_RECEIVED_ITEMS] ([NUM_RRID], [NUM_itemID], [NUM_quantity], [NUM_received]) VALUES (999001, 7812, 1, 0)
INSERT [dbo].[TBL_RECEIVED_ITEMS] ([NUM_RRID], [NUM_itemID], [NUM_quantity], [NUM_received]) VALUES (999001, 7841, 2, 0)
INSERT [dbo].[TBL_RECEIVED_ITEMS] ([NUM_RRID], [NUM_itemID], [NUM_quantity], [NUM_received]) VALUES (999001, 7878, 1, 0)
INSERT [dbo].[TBL_RECEIVED_ITEMS] ([NUM_RRID], [NUM_itemID], [NUM_quantity], [NUM_received]) VALUES (999001, 7890, 2, 0)
INSERT [dbo].[TBL_RECEIVED_ITEMS] ([NUM_RRID], [NUM_itemID], [NUM_quantity], [NUM_received]) VALUES (999001, 7891, 3, 0)
INSERT [dbo].[TBL_RECEIVED_ITEMS] ([NUM_RRID], [NUM_itemID], [NUM_quantity], [NUM_received]) VALUES (999002, 7832, 2, 0)
INSERT [dbo].[TBL_RECEIVED_ITEMS] ([NUM_RRID], [NUM_itemID], [NUM_quantity], [NUM_received]) VALUES (999002, 7867, 1, 0)
INSERT [dbo].[TBL_RECEIVED_ITEMS] ([NUM_RRID], [NUM_itemID], [NUM_quantity], [NUM_received]) VALUES (999002, 7890, 1, 0)
INSERT [dbo].[TBL_RECEIVED_ITEMS] ([NUM_RRID], [NUM_itemID], [NUM_quantity], [NUM_received]) VALUES (999003, 7894, 1, 1)
INSERT [dbo].[TBL_RECEIVED_ITEMS] ([NUM_RRID], [NUM_itemID], [NUM_quantity], [NUM_received]) VALUES (999003, 7895, 1, 1)
INSERT [dbo].[TBL_RECEIVING_REPORT] ([NUM_RRID], [DT_delivery_date], [DT_created_date], [CHR_terms], [NUM_POID], [CHR_notes], [FT_total], [NUM_RRstatus]) VALUES (999001, CAST(N'2018-09-05' AS Date), CAST(N'2018-09-04' AS Date), NULL, 45451, NULL, NULL, 0)
INSERT [dbo].[TBL_RECEIVING_REPORT] ([NUM_RRID], [DT_delivery_date], [DT_created_date], [CHR_terms], [NUM_POID], [CHR_notes], [FT_total], [NUM_RRstatus]) VALUES (999002, CAST(N'2018-07-28' AS Date), CAST(N'2018-07-25' AS Date), NULL, 45452, NULL, NULL, 0)
INSERT [dbo].[TBL_RECEIVING_REPORT] ([NUM_RRID], [DT_delivery_date], [DT_created_date], [CHR_terms], [NUM_POID], [CHR_notes], [FT_total], [NUM_RRstatus]) VALUES (999003, CAST(N'2018-10-30' AS Date), CAST(N'2018-07-04' AS Date), NULL, 45454, NULL, NULL, 0)
INSERT [dbo].[TBL_SALARY_TYPES] ([NUM_STID], [NUM_stype]) VALUES (1, N'yearly')
INSERT [dbo].[TBL_SALARY_TYPES] ([NUM_STID], [NUM_stype]) VALUES (2, N'monthly')
INSERT [dbo].[TBL_SALARY_TYPES] ([NUM_STID], [NUM_stype]) VALUES (3, N'weekly')
INSERT [dbo].[TBL_SALARY_TYPES] ([NUM_STID], [NUM_stype]) VALUES (4, N'custom')
INSERT [dbo].[TBL_SC_ITEMS] ([NUM_itemID], [CHR_item_name], [FT_price], [CHR_info], [NUM_manufacturer], [FT_VAT], [NUM_Quantity], [CHR_Product_saleflag], [NUM_Vat_category], [NUM_Product_category]) VALUES (7812, N'Grenn Shirt', 45, NULL, 2345, NULL, 5, NULL, NULL, NULL)
INSERT [dbo].[TBL_SC_ITEMS] ([NUM_itemID], [CHR_item_name], [FT_price], [CHR_info], [NUM_manufacturer], [FT_VAT], [NUM_Quantity], [CHR_Product_saleflag], [NUM_Vat_category], [NUM_Product_category]) VALUES (7832, N'Pullover ', 34.95, NULL, 2345, NULL, 5, NULL, NULL, NULL)
INSERT [dbo].[TBL_SC_ITEMS] ([NUM_itemID], [CHR_item_name], [FT_price], [CHR_info], [NUM_manufacturer], [FT_VAT], [NUM_Quantity], [CHR_Product_saleflag], [NUM_Vat_category], [NUM_Product_category]) VALUES (7841, N'Levis Tshirt', 25, NULL, 2346, NULL, 4, NULL, NULL, NULL)
INSERT [dbo].[TBL_SC_ITEMS] ([NUM_itemID], [CHR_item_name], [FT_price], [CHR_info], [NUM_manufacturer], [FT_VAT], [NUM_Quantity], [CHR_Product_saleflag], [NUM_Vat_category], [NUM_Product_category]) VALUES (7864, N'Hard Rock Tshirt', 19.99, NULL, 2346, NULL, 7, NULL, NULL, NULL)
INSERT [dbo].[TBL_SC_ITEMS] ([NUM_itemID], [CHR_item_name], [FT_price], [CHR_info], [NUM_manufacturer], [FT_VAT], [NUM_Quantity], [CHR_Product_saleflag], [NUM_Vat_category], [NUM_Product_category]) VALUES (7867, N'Adidas Cap', 15.99, NULL, 2345, NULL, 4, NULL, NULL, NULL)
INSERT [dbo].[TBL_SC_ITEMS] ([NUM_itemID], [CHR_item_name], [FT_price], [CHR_info], [NUM_manufacturer], [FT_VAT], [NUM_Quantity], [CHR_Product_saleflag], [NUM_Vat_category], [NUM_Product_category]) VALUES (7878, N'Blue tshirt', 6, NULL, 2345, NULL, 5, NULL, NULL, NULL)
INSERT [dbo].[TBL_SC_ITEMS] ([NUM_itemID], [CHR_item_name], [FT_price], [CHR_info], [NUM_manufacturer], [FT_VAT], [NUM_Quantity], [CHR_Product_saleflag], [NUM_Vat_category], [NUM_Product_category]) VALUES (7890, N'D&G Jeans', 89.99, NULL, 2345, NULL, 2, NULL, NULL, NULL)
INSERT [dbo].[TBL_SC_ITEMS] ([NUM_itemID], [CHR_item_name], [FT_price], [CHR_info], [NUM_manufacturer], [FT_VAT], [NUM_Quantity], [CHR_Product_saleflag], [NUM_Vat_category], [NUM_Product_category]) VALUES (7891, N'Blue Jeans', 23, NULL, 2345, NULL, 2, NULL, NULL, NULL)
INSERT [dbo].[TBL_SC_ITEMS] ([NUM_itemID], [CHR_item_name], [FT_price], [CHR_info], [NUM_manufacturer], [FT_VAT], [NUM_Quantity], [CHR_Product_saleflag], [NUM_Vat_category], [NUM_Product_category]) VALUES (7893, N'Socks RED', 12.95, NULL, 2346, NULL, 2, NULL, NULL, NULL)
INSERT [dbo].[TBL_SC_ITEMS] ([NUM_itemID], [CHR_item_name], [FT_price], [CHR_info], [NUM_manufacturer], [FT_VAT], [NUM_Quantity], [CHR_Product_saleflag], [NUM_Vat_category], [NUM_Product_category]) VALUES (7894, N'iPhone 7 Plus', 549.99, NULL, 2347, NULL, 5, NULL, NULL, NULL)
INSERT [dbo].[TBL_SC_ITEMS] ([NUM_itemID], [CHR_item_name], [FT_price], [CHR_info], [NUM_manufacturer], [FT_VAT], [NUM_Quantity], [CHR_Product_saleflag], [NUM_Vat_category], [NUM_Product_category]) VALUES (7895, N'iPhone XS', 800, NULL, 2347, NULL, 2, NULL, NULL, NULL)
INSERT [dbo].[TBL_USER] ([NUM_UserID], [CHR_firstname], [CHR_surname], [CHR_email], [NUM_phone], [CHR_city], [CHR_country], [CHR_username], [CHR_pass], [CHR_address]) VALUES (1234, N'Haris', N'Kyprianou', N'haris_kyprianou@gmail.com', 99903739, N'Nicosia', N'Cyprus', N'hariskyp', N'123', NULL)
INSERT [dbo].[TBL_USER] ([NUM_UserID], [CHR_firstname], [CHR_surname], [CHR_email], [NUM_phone], [CHR_city], [CHR_country], [CHR_username], [CHR_pass], [CHR_address]) VALUES (1235, N'Nico', N'Jonas', N'nico@gmail.com', 99845722, N'Paris', N'France', N'sa', N'123', NULL)
SET IDENTITY_INSERT [dbo].[TBL_VAT_CATEGORIES] ON 

INSERT [dbo].[TBL_VAT_CATEGORIES] ([NUM_Vat_id], [NUM_Vat_rate], [CHR_Description]) VALUES (1, 20, NULL)
SET IDENTITY_INSERT [dbo].[TBL_VAT_CATEGORIES] OFF
INSERT [dbo].[TBL_VENDOR] ([NUM_Vendor_ID], [NUM_phone], [CHR_address_], [CHR_companyName], [CHR_companyType], [CHR_country], [CHR_city], [CHR_titl], [CHR_firstname], [CHR_surname], [CHR_email]) VALUES (2345, 99887766, N'10 Strovolos ', N'MTN', N'Commercial', N'Cyprus', N'Nicosia', N'Mr.', N'Petros', N'Petrou', N'petros@mtn.com')
INSERT [dbo].[TBL_VENDOR] ([NUM_Vendor_ID], [NUM_phone], [CHR_address_], [CHR_companyName], [CHR_companyType], [CHR_country], [CHR_city], [CHR_titl], [CHR_firstname], [CHR_surname], [CHR_email]) VALUES (2346, 99553362, N'30 Themistokli, Strovolos, NIcosia, Cyprus', N'Logicom', N'Commercial', N'Cyprus', N'Nicosia', N'Mrs.', N'Anna', N'Frank', N'annafrank@logicom.com')
INSERT [dbo].[TBL_VENDOR] ([NUM_Vendor_ID], [NUM_phone], [CHR_address_], [CHR_companyName], [CHR_companyType], [CHR_country], [CHR_city], [CHR_titl], [CHR_firstname], [CHR_surname], [CHR_email]) VALUES (2347, 4283525, N'10 Cupertino', N'Apple', N'Products Selling', N'USA', N' California', N'Mr.', N'Tim', N'Cook', N'sales@apple.com')
INSERT [dbo].[TBL_VENDOR] ([NUM_Vendor_ID], [NUM_phone], [CHR_address_], [CHR_companyName], [CHR_companyType], [CHR_country], [CHR_city], [CHR_titl], [CHR_firstname], [CHR_surname], [CHR_email]) VALUES (2348, 88829342, N'10 Zuchin', N'Microsoft', N'Electronics', N'Japan', N' Tokyo', N'Mr.', N'Bill', N'Gates', N'support@microsoft.com')
INSERT [dbo].[TBL_VENDOR] ([NUM_Vendor_ID], [NUM_phone], [CHR_address_], [CHR_companyName], [CHR_companyType], [CHR_country], [CHR_city], [CHR_titl], [CHR_firstname], [CHR_surname], [CHR_email]) VALUES (2349, 8234923, N'12 Times Square', N'Huaweii', N'Smartphones', N'USA', N' New York', N'Mr.', N'Kim', N'Passat', N'contactus@huaweii.com')
ALTER TABLE [dbo].[TBL_INVOICE]  WITH CHECK ADD FOREIGN KEY([NUM_POID])
REFERENCES [dbo].[TBL_PURCHASE_ORDER] ([NUM_POID])
GO
ALTER TABLE [dbo].[TBL_INVOICE]  WITH CHECK ADD FOREIGN KEY([NUM_POID])
REFERENCES [dbo].[TBL_PURCHASE_ORDER] ([NUM_POID])
GO
ALTER TABLE [dbo].[TBL_INVOICE]  WITH CHECK ADD FOREIGN KEY([NUM_vendorID])
REFERENCES [dbo].[TBL_VENDOR] ([NUM_Vendor_ID])
GO
ALTER TABLE [dbo].[TBL_INVOICE]  WITH CHECK ADD FOREIGN KEY([NUM_vendorID])
REFERENCES [dbo].[TBL_VENDOR] ([NUM_Vendor_ID])
GO
ALTER TABLE [dbo].[TBL_INVOICE_ITEMS]  WITH CHECK ADD FOREIGN KEY([NUM_invoiceID])
REFERENCES [dbo].[TBL_INVOICE] ([NUM_invoiceID])
GO
ALTER TABLE [dbo].[TBL_INVOICE_ITEMS]  WITH CHECK ADD FOREIGN KEY([NUM_invoiceID])
REFERENCES [dbo].[TBL_INVOICE] ([NUM_invoiceID])
GO
ALTER TABLE [dbo].[TBL_INVOICE_ITEMS]  WITH CHECK ADD  CONSTRAINT [FK__TBL_INVOI__NUM_i__5BE2A6F2] FOREIGN KEY([NUM_itemID])
REFERENCES [dbo].[TBL_SC_ITEMS] ([NUM_itemID])
GO
ALTER TABLE [dbo].[TBL_INVOICE_ITEMS] CHECK CONSTRAINT [FK__TBL_INVOI__NUM_i__5BE2A6F2]
GO
ALTER TABLE [dbo].[TBL_INVOICE_ITEMS]  WITH CHECK ADD  CONSTRAINT [FK__TBL_INVOI__NUM_i__5CD6CB2B] FOREIGN KEY([NUM_itemID])
REFERENCES [dbo].[TBL_SC_ITEMS] ([NUM_itemID])
GO
ALTER TABLE [dbo].[TBL_INVOICE_ITEMS] CHECK CONSTRAINT [FK__TBL_INVOI__NUM_i__5CD6CB2B]
GO
ALTER TABLE [dbo].[TBL_PAYMENT]  WITH CHECK ADD FOREIGN KEY([NUM_PaymentType])
REFERENCES [dbo].[TBL_PAYMENT_TYPES] ([NUM_PTID])
GO
ALTER TABLE [dbo].[TBL_PO_ITEMS]  WITH CHECK ADD  CONSTRAINT [FK__TBL_PO_IT__NUM_i__5EBF139D] FOREIGN KEY([NUM_itemID])
REFERENCES [dbo].[TBL_SC_ITEMS] ([NUM_itemID])
GO
ALTER TABLE [dbo].[TBL_PO_ITEMS] CHECK CONSTRAINT [FK__TBL_PO_IT__NUM_i__5EBF139D]
GO
ALTER TABLE [dbo].[TBL_PO_ITEMS]  WITH CHECK ADD  CONSTRAINT [FK__TBL_PO_IT__NUM_i__5FB337D6] FOREIGN KEY([NUM_itemID])
REFERENCES [dbo].[TBL_SC_ITEMS] ([NUM_itemID])
GO
ALTER TABLE [dbo].[TBL_PO_ITEMS] CHECK CONSTRAINT [FK__TBL_PO_IT__NUM_i__5FB337D6]
GO
ALTER TABLE [dbo].[TBL_PO_ITEMS]  WITH CHECK ADD FOREIGN KEY([NUM_POID])
REFERENCES [dbo].[TBL_PURCHASE_ORDER] ([NUM_POID])
GO
ALTER TABLE [dbo].[TBL_PO_ITEMS]  WITH CHECK ADD FOREIGN KEY([NUM_POID])
REFERENCES [dbo].[TBL_PURCHASE_ORDER] ([NUM_POID])
GO
ALTER TABLE [dbo].[TBL_PURCHASE_ORDER]  WITH CHECK ADD FOREIGN KEY([NUM_userID])
REFERENCES [dbo].[TBL_USER] ([NUM_UserID])
GO
ALTER TABLE [dbo].[TBL_PURCHASE_ORDER]  WITH CHECK ADD FOREIGN KEY([NUM_userID])
REFERENCES [dbo].[TBL_USER] ([NUM_UserID])
GO
ALTER TABLE [dbo].[TBL_PURCHASE_ORDER]  WITH CHECK ADD FOREIGN KEY([NUM_vendorID])
REFERENCES [dbo].[TBL_VENDOR] ([NUM_Vendor_ID])
GO
ALTER TABLE [dbo].[TBL_PURCHASE_ORDER]  WITH CHECK ADD FOREIGN KEY([NUM_vendorID])
REFERENCES [dbo].[TBL_VENDOR] ([NUM_Vendor_ID])
GO
ALTER TABLE [dbo].[TBL_RECEIVED_ITEMS]  WITH CHECK ADD  CONSTRAINT [FK__TBL_RECEI__NUM_i__66603565] FOREIGN KEY([NUM_itemID])
REFERENCES [dbo].[TBL_SC_ITEMS] ([NUM_itemID])
GO
ALTER TABLE [dbo].[TBL_RECEIVED_ITEMS] CHECK CONSTRAINT [FK__TBL_RECEI__NUM_i__66603565]
GO
ALTER TABLE [dbo].[TBL_RECEIVED_ITEMS]  WITH CHECK ADD  CONSTRAINT [FK__TBL_RECEI__NUM_i__6754599E] FOREIGN KEY([NUM_itemID])
REFERENCES [dbo].[TBL_SC_ITEMS] ([NUM_itemID])
GO
ALTER TABLE [dbo].[TBL_RECEIVED_ITEMS] CHECK CONSTRAINT [FK__TBL_RECEI__NUM_i__6754599E]
GO
ALTER TABLE [dbo].[TBL_RECEIVED_ITEMS]  WITH CHECK ADD FOREIGN KEY([NUM_RRID])
REFERENCES [dbo].[TBL_RECEIVING_REPORT] ([NUM_RRID])
GO
ALTER TABLE [dbo].[TBL_RECEIVED_ITEMS]  WITH CHECK ADD FOREIGN KEY([NUM_RRID])
REFERENCES [dbo].[TBL_RECEIVING_REPORT] ([NUM_RRID])
GO
ALTER TABLE [dbo].[TBL_RECEIVING_REPORT]  WITH CHECK ADD FOREIGN KEY([NUM_POID])
REFERENCES [dbo].[TBL_PURCHASE_ORDER] ([NUM_POID])
GO
ALTER TABLE [dbo].[TBL_RECEIVING_REPORT]  WITH CHECK ADD FOREIGN KEY([NUM_POID])
REFERENCES [dbo].[TBL_PURCHASE_ORDER] ([NUM_POID])
GO
ALTER TABLE [dbo].[TBL_SALARY_PAYMENTS]  WITH CHECK ADD FOREIGN KEY([NUM_salaryType])
REFERENCES [dbo].[TBL_SALARY_TYPES] ([NUM_STID])
GO
ALTER TABLE [dbo].[TBL_SALARY_PAYMENTS]  WITH CHECK ADD FOREIGN KEY([NUM_userID])
REFERENCES [dbo].[TBL_USER] ([NUM_UserID])
GO
ALTER TABLE [dbo].[TBL_SC_ITEMS]  WITH CHECK ADD  CONSTRAINT [FK__TBL_SC_IT__NUM_m__6E01572D] FOREIGN KEY([NUM_manufacturer])
REFERENCES [dbo].[TBL_VENDOR] ([NUM_Vendor_ID])
GO
ALTER TABLE [dbo].[TBL_SC_ITEMS] CHECK CONSTRAINT [FK__TBL_SC_IT__NUM_m__6E01572D]
GO
ALTER TABLE [dbo].[TBL_SC_ITEMS]  WITH CHECK ADD  CONSTRAINT [FK__TBL_SC_IT__NUM_m__6EF57B66] FOREIGN KEY([NUM_manufacturer])
REFERENCES [dbo].[TBL_VENDOR] ([NUM_Vendor_ID])
GO
ALTER TABLE [dbo].[TBL_SC_ITEMS] CHECK CONSTRAINT [FK__TBL_SC_IT__NUM_m__6EF57B66]
GO
ALTER TABLE [dbo].[TBL_SC_ITEMS]  WITH CHECK ADD  CONSTRAINT [FK_ITEM_CATEGORY] FOREIGN KEY([NUM_Product_category])
REFERENCES [dbo].[TBL_PRODUCT_CATEGORIES] ([NUM_Category_id])
GO
ALTER TABLE [dbo].[TBL_SC_ITEMS] CHECK CONSTRAINT [FK_ITEM_CATEGORY]
GO
ALTER TABLE [dbo].[TBL_SC_ITEMS]  WITH CHECK ADD  CONSTRAINT [FK_VAT_CATEGORY] FOREIGN KEY([NUM_Vat_category])
REFERENCES [dbo].[TBL_VAT_CATEGORIES] ([NUM_Vat_id])
GO
ALTER TABLE [dbo].[TBL_SC_ITEMS] CHECK CONSTRAINT [FK_VAT_CATEGORY]
GO
USE [master]
GO
ALTER DATABASE [AccountsPayable] SET  READ_WRITE 
GO
