USE [master]
GO
/****** Object:  Database [StockManagement]    Script Date: 12/19/2017 1:09:02 PM ******/
CREATE DATABASE [StockManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StockManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\StockManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StockManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\StockManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [StockManagement] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StockManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StockManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StockManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StockManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StockManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StockManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [StockManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StockManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StockManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StockManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StockManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StockManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StockManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StockManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StockManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StockManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StockManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StockManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StockManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StockManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StockManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StockManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StockManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StockManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StockManagement] SET  MULTI_USER 
GO
ALTER DATABASE [StockManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StockManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StockManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StockManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StockManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StockManagement] SET QUERY_STORE = OFF
GO
USE [StockManagement]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [StockManagement]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 12/19/2017 1:09:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[catName] [varchar](50) NULL,
	[date] [date] NULL,
	[updateDate] [date] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 12/19/2017 1:09:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[comName] [varchar](50) NULL,
	[date] [date] NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 12/19/2017 1:09:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[catId] [int] NULL,
	[comId] [int] NULL,
	[itemName] [varchar](50) NULL,
	[reorderLabel] [int] NULL,
	[date] [date] NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockIn]    Script Date: 12/19/2017 1:09:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockIn](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cmpId] [int] NULL,
	[itemId] [int] NULL,
	[reorder] [int] NULL,
	[aviable_Quentity] [int] NOT NULL,
	[date] [date] NULL,
 CONSTRAINT [PK_StockIn] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Serch_view]    Script Date: 12/19/2017 1:09:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[Serch_view] AS

select i.itemName,c.comName,cat.catName,s.aviable_Quentity,s.reorder,c.id as companyId,cat.id as categroyID  from Company as c
left outer join Item as i
on c.id = i.comId
left outer join Category as cat
On i.catId= cat.id
left outer join StockIn as s
on i.id = s.itemId
GO
/****** Object:  Table [dbo].[StockOut]    Script Date: 12/19/2017 1:09:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockOut](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cmp_id] [int] NULL,
	[item_id] [int] NULL,
	[taken_quentity] [int] NULL,
	[sell_item] [varchar](50) NOT NULL,
	[damage_item] [varchar](50) NOT NULL,
	[lost_item] [varchar](50) NOT NULL,
	[insert_date] [date] NULL,
	[update_date] [date] NULL,
 CONSTRAINT [PK_StockOut] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[saleView]    Script Date: 12/19/2017 1:09:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[saleView] as 
select taken_quentity as takenQuentity,item_id,itemName,insert_date,sell_item from StockOut
full outer join Item
on StockOut.item_id=Item.id
GO
/****** Object:  Table [dbo].[Login]    Script Date: 12/19/2017 1:09:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userName] [varchar](50) NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([id], [catName], [date], [updateDate]) VALUES (1, N'Stationary', CAST(N'2017-12-14' AS Date), CAST(N'2017-12-15' AS Date))
INSERT [dbo].[Category] ([id], [catName], [date], [updateDate]) VALUES (2, N'Cosmetics', CAST(N'2017-12-14' AS Date), CAST(N'2017-12-15' AS Date))
INSERT [dbo].[Category] ([id], [catName], [date], [updateDate]) VALUES (3, N'Electronics', CAST(N'2017-12-14' AS Date), CAST(N'2017-12-15' AS Date))
INSERT [dbo].[Category] ([id], [catName], [date], [updateDate]) VALUES (4, N'Kitchen Items', CAST(N'2017-12-14' AS Date), CAST(N'2017-12-15' AS Date))
INSERT [dbo].[Category] ([id], [catName], [date], [updateDate]) VALUES (5, N'Computer Accessoriess', CAST(N'2017-12-14' AS Date), CAST(N'2017-12-15' AS Date))
INSERT [dbo].[Category] ([id], [catName], [date], [updateDate]) VALUES (20, N'kamal', CAST(N'2017-12-15' AS Date), CAST(N'2017-12-15' AS Date))
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Company] ON 

INSERT [dbo].[Company] ([id], [comName], [date]) VALUES (1, N'RFL', CAST(N'0001-01-01' AS Date))
INSERT [dbo].[Company] ([id], [comName], [date]) VALUES (2, N'BSL', CAST(N'0001-01-01' AS Date))
INSERT [dbo].[Company] ([id], [comName], [date]) VALUES (3, N'BSRM', CAST(N'0001-01-01' AS Date))
INSERT [dbo].[Company] ([id], [comName], [date]) VALUES (4, N'Crispi', CAST(N'0001-01-01' AS Date))
INSERT [dbo].[Company] ([id], [comName], [date]) VALUES (6, N'DDL', CAST(N'0001-01-01' AS Date))
INSERT [dbo].[Company] ([id], [comName], [date]) VALUES (7, N'Walton', CAST(N'0001-01-01' AS Date))
INSERT [dbo].[Company] ([id], [comName], [date]) VALUES (11, N'Iner national Police', CAST(N'2017-12-17' AS Date))
SET IDENTITY_INSERT [dbo].[Company] OFF
SET IDENTITY_INSERT [dbo].[Item] ON 

INSERT [dbo].[Item] ([id], [catId], [comId], [itemName], [reorderLabel], [date]) VALUES (1, 2, 2, N'Cheps', 2, CAST(N'2017-12-15' AS Date))
INSERT [dbo].[Item] ([id], [catId], [comId], [itemName], [reorderLabel], [date]) VALUES (2, 1, 1, N'Kamal', 4, CAST(N'2017-12-15' AS Date))
INSERT [dbo].[Item] ([id], [catId], [comId], [itemName], [reorderLabel], [date]) VALUES (3, 3, 3, N'Steel', 5, CAST(N'2017-12-16' AS Date))
INSERT [dbo].[Item] ([id], [catId], [comId], [itemName], [reorderLabel], [date]) VALUES (4, 1, 3, N'Container', 4, CAST(N'2017-12-16' AS Date))
INSERT [dbo].[Item] ([id], [catId], [comId], [itemName], [reorderLabel], [date]) VALUES (5, 1, 3, N'DLL', 0, CAST(N'2017-12-16' AS Date))
INSERT [dbo].[Item] ([id], [catId], [comId], [itemName], [reorderLabel], [date]) VALUES (6, 4, 6, N'SOFA', 4, CAST(N'2017-12-16' AS Date))
INSERT [dbo].[Item] ([id], [catId], [comId], [itemName], [reorderLabel], [date]) VALUES (7, 1, 1, N'Crispi Jsop fos', 4, CAST(N'2017-12-17' AS Date))
INSERT [dbo].[Item] ([id], [catId], [comId], [itemName], [reorderLabel], [date]) VALUES (8, 3, 1, N'BMW', 45, CAST(N'2017-12-17' AS Date))
INSERT [dbo].[Item] ([id], [catId], [comId], [itemName], [reorderLabel], [date]) VALUES (9, 3, 7, N'Oven', 2, CAST(N'2017-12-17' AS Date))
INSERT [dbo].[Item] ([id], [catId], [comId], [itemName], [reorderLabel], [date]) VALUES (10, 2, 2, N'HLOLO', 4, CAST(N'2017-12-17' AS Date))
INSERT [dbo].[Item] ([id], [catId], [comId], [itemName], [reorderLabel], [date]) VALUES (11, 2, 1, N'LeapStick', 4, CAST(N'2017-12-17' AS Date))
INSERT [dbo].[Item] ([id], [catId], [comId], [itemName], [reorderLabel], [date]) VALUES (12, 3, 1, N'Watch', 2, CAST(N'2017-12-17' AS Date))
INSERT [dbo].[Item] ([id], [catId], [comId], [itemName], [reorderLabel], [date]) VALUES (13, -1, -1, N'fdf', 4, CAST(N'2017-12-17' AS Date))
INSERT [dbo].[Item] ([id], [catId], [comId], [itemName], [reorderLabel], [date]) VALUES (14, -1, -1, N'sss', 7, CAST(N'2017-12-17' AS Date))
INSERT [dbo].[Item] ([id], [catId], [comId], [itemName], [reorderLabel], [date]) VALUES (15, 2, 2, N'denail', 3, CAST(N'2017-12-17' AS Date))
INSERT [dbo].[Item] ([id], [catId], [comId], [itemName], [reorderLabel], [date]) VALUES (16, 2, 2, N'LLL', 3, CAST(N'2017-12-17' AS Date))
INSERT [dbo].[Item] ([id], [catId], [comId], [itemName], [reorderLabel], [date]) VALUES (17, 2, 11, N'LOLYPOP', 5, CAST(N'2017-12-17' AS Date))
INSERT [dbo].[Item] ([id], [catId], [comId], [itemName], [reorderLabel], [date]) VALUES (18, 1, 1, N'BOOL', 6, CAST(N'2017-12-18' AS Date))
INSERT [dbo].[Item] ([id], [catId], [comId], [itemName], [reorderLabel], [date]) VALUES (19, 1, 1, N'Jusip', -32, CAST(N'2017-12-19' AS Date))
SET IDENTITY_INSERT [dbo].[Item] OFF
SET IDENTITY_INSERT [dbo].[Login] ON 

INSERT [dbo].[Login] ([id], [userName], [password]) VALUES (1, N'nishad', N'12345')
SET IDENTITY_INSERT [dbo].[Login] OFF
SET IDENTITY_INSERT [dbo].[StockIn] ON 

INSERT [dbo].[StockIn] ([id], [cmpId], [itemId], [reorder], [aviable_Quentity], [date]) VALUES (14, 1, 7, 4, 4, CAST(N'2017-12-17' AS Date))
INSERT [dbo].[StockIn] ([id], [cmpId], [itemId], [reorder], [aviable_Quentity], [date]) VALUES (16, 1, 8, 45, 3, CAST(N'2017-12-17' AS Date))
INSERT [dbo].[StockIn] ([id], [cmpId], [itemId], [reorder], [aviable_Quentity], [date]) VALUES (17, 3, 4, 4, 12, CAST(N'2017-12-17' AS Date))
INSERT [dbo].[StockIn] ([id], [cmpId], [itemId], [reorder], [aviable_Quentity], [date]) VALUES (18, 2, 1, 2, 13, CAST(N'2017-12-17' AS Date))
INSERT [dbo].[StockIn] ([id], [cmpId], [itemId], [reorder], [aviable_Quentity], [date]) VALUES (19, 1, 2, 5, 16, CAST(N'2017-12-17' AS Date))
INSERT [dbo].[StockIn] ([id], [cmpId], [itemId], [reorder], [aviable_Quentity], [date]) VALUES (20, 7, 9, 2, 6, CAST(N'2017-12-19' AS Date))
SET IDENTITY_INSERT [dbo].[StockIn] OFF
SET IDENTITY_INSERT [dbo].[StockOut] ON 

INSERT [dbo].[StockOut] ([id], [cmp_id], [item_id], [taken_quentity], [sell_item], [damage_item], [lost_item], [insert_date], [update_date]) VALUES (12, 1, 2, 37, N'Yes', N'No', N'No', CAST(N'2017-12-16' AS Date), NULL)
INSERT [dbo].[StockOut] ([id], [cmp_id], [item_id], [taken_quentity], [sell_item], [damage_item], [lost_item], [insert_date], [update_date]) VALUES (13, 3, 5, 110, N'Yes', N'No', N'No', CAST(N'2009-09-18' AS Date), NULL)
INSERT [dbo].[StockOut] ([id], [cmp_id], [item_id], [taken_quentity], [sell_item], [damage_item], [lost_item], [insert_date], [update_date]) VALUES (14, 1, 2, 1, N'No', N'Yes', N'No', CAST(N'2011-04-10' AS Date), NULL)
INSERT [dbo].[StockOut] ([id], [cmp_id], [item_id], [taken_quentity], [sell_item], [damage_item], [lost_item], [insert_date], [update_date]) VALUES (15, 3, 5, 1, N'No', N'Yes', N'No', CAST(N'2017-12-17' AS Date), NULL)
INSERT [dbo].[StockOut] ([id], [cmp_id], [item_id], [taken_quentity], [sell_item], [damage_item], [lost_item], [insert_date], [update_date]) VALUES (16, 3, 5, 1, N'No', N'Yes', N'No', CAST(N'2017-12-15' AS Date), NULL)
INSERT [dbo].[StockOut] ([id], [cmp_id], [item_id], [taken_quentity], [sell_item], [damage_item], [lost_item], [insert_date], [update_date]) VALUES (17, 2, 1, 38, N'No', N'Yes', N'No', CAST(N'2015-12-28' AS Date), NULL)
INSERT [dbo].[StockOut] ([id], [cmp_id], [item_id], [taken_quentity], [sell_item], [damage_item], [lost_item], [insert_date], [update_date]) VALUES (20, 2, 1, 38, N'No', N'No', N'Yes', CAST(N'2017-12-17' AS Date), NULL)
INSERT [dbo].[StockOut] ([id], [cmp_id], [item_id], [taken_quentity], [sell_item], [damage_item], [lost_item], [insert_date], [update_date]) VALUES (21, 2, 1, 38, N'Yes', N'No', N'No', CAST(N'2017-12-17' AS Date), NULL)
INSERT [dbo].[StockOut] ([id], [cmp_id], [item_id], [taken_quentity], [sell_item], [damage_item], [lost_item], [insert_date], [update_date]) VALUES (22, 1, 7, 87, N'Yes', N'No', N'No', CAST(N'2017-12-17' AS Date), NULL)
INSERT [dbo].[StockOut] ([id], [cmp_id], [item_id], [taken_quentity], [sell_item], [damage_item], [lost_item], [insert_date], [update_date]) VALUES (23, 1, 7, 87, N'No', N'Yes', N'No', CAST(N'2017-11-17' AS Date), NULL)
INSERT [dbo].[StockOut] ([id], [cmp_id], [item_id], [taken_quentity], [sell_item], [damage_item], [lost_item], [insert_date], [update_date]) VALUES (24, 1, 8, 39, N'No', N'Yes', N'No', CAST(N'2017-09-17' AS Date), NULL)
INSERT [dbo].[StockOut] ([id], [cmp_id], [item_id], [taken_quentity], [sell_item], [damage_item], [lost_item], [insert_date], [update_date]) VALUES (25, 3, 4, 65, N'No', N'Yes', N'No', CAST(N'2017-12-17' AS Date), NULL)
INSERT [dbo].[StockOut] ([id], [cmp_id], [item_id], [taken_quentity], [sell_item], [damage_item], [lost_item], [insert_date], [update_date]) VALUES (26, 3, 4, 65, N'Yes', N'No', N'No', CAST(N'2008-03-06' AS Date), NULL)
INSERT [dbo].[StockOut] ([id], [cmp_id], [item_id], [taken_quentity], [sell_item], [damage_item], [lost_item], [insert_date], [update_date]) VALUES (27, 1, 8, 39, N'Yes', N'No', N'No', CAST(N'2017-12-18' AS Date), NULL)
INSERT [dbo].[StockOut] ([id], [cmp_id], [item_id], [taken_quentity], [sell_item], [damage_item], [lost_item], [insert_date], [update_date]) VALUES (28, 1, 7, 87, N'No', N'No', N'Yes', CAST(N'2017-12-18' AS Date), NULL)
INSERT [dbo].[StockOut] ([id], [cmp_id], [item_id], [taken_quentity], [sell_item], [damage_item], [lost_item], [insert_date], [update_date]) VALUES (29, 3, 4, 65, N'No', N'No', N'Yes', CAST(N'2017-12-18' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[StockOut] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Category]    Script Date: 12/19/2017 1:09:02 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Category] ON [dbo].[Category]
(
	[catName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Company]    Script Date: 12/19/2017 1:09:02 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Company] ON [dbo].[Company]
(
	[comName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[StockIn] ADD  CONSTRAINT [DF_StockIn_aviable_Quentity]  DEFAULT ((0)) FOR [aviable_Quentity]
GO
ALTER TABLE [dbo].[StockOut] ADD  CONSTRAINT [DF_StockOut_losing_item]  DEFAULT ('No') FOR [sell_item]
GO
ALTER TABLE [dbo].[StockOut] ADD  CONSTRAINT [DF_StockOut_damage_item]  DEFAULT ('No') FOR [damage_item]
GO
ALTER TABLE [dbo].[StockOut] ADD  CONSTRAINT [DF_StockOut_lost_item]  DEFAULT ('No') FOR [lost_item]
GO
ALTER TABLE [dbo].[StockIn]  WITH CHECK ADD  CONSTRAINT [FK_StockIn_Company] FOREIGN KEY([cmpId])
REFERENCES [dbo].[Company] ([id])
GO
ALTER TABLE [dbo].[StockIn] CHECK CONSTRAINT [FK_StockIn_Company]
GO
ALTER TABLE [dbo].[StockIn]  WITH CHECK ADD  CONSTRAINT [FK_StockIn_Item] FOREIGN KEY([itemId])
REFERENCES [dbo].[Item] ([id])
GO
ALTER TABLE [dbo].[StockIn] CHECK CONSTRAINT [FK_StockIn_Item]
GO
ALTER TABLE [dbo].[StockOut]  WITH CHECK ADD  CONSTRAINT [FK_StockOut_Company] FOREIGN KEY([cmp_id])
REFERENCES [dbo].[Company] ([id])
GO
ALTER TABLE [dbo].[StockOut] CHECK CONSTRAINT [FK_StockOut_Company]
GO
ALTER TABLE [dbo].[StockOut]  WITH CHECK ADD  CONSTRAINT [FK_StockOut_Item] FOREIGN KEY([item_id])
REFERENCES [dbo].[Item] ([id])
GO
ALTER TABLE [dbo].[StockOut] CHECK CONSTRAINT [FK_StockOut_Item]
GO
USE [master]
GO
ALTER DATABASE [StockManagement] SET  READ_WRITE 
GO
