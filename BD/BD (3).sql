USE [master]
GO
/****** Object:  Database [Motor_show]    Script Date: 12.01.2021 18:41:06 ******/
CREATE DATABASE [Motor_show]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Motor_show', FILENAME = N'd:\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Motor_show.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Motor_show_log', FILENAME = N'd:\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Motor_show_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Motor_show] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Motor_show].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Motor_show] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Motor_show] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Motor_show] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Motor_show] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Motor_show] SET ARITHABORT OFF 
GO
ALTER DATABASE [Motor_show] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Motor_show] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Motor_show] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Motor_show] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Motor_show] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Motor_show] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Motor_show] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Motor_show] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Motor_show] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Motor_show] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Motor_show] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Motor_show] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Motor_show] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Motor_show] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Motor_show] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Motor_show] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Motor_show] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Motor_show] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Motor_show] SET  MULTI_USER 
GO
ALTER DATABASE [Motor_show] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Motor_show] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Motor_show] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Motor_show] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Motor_show]
GO
/****** Object:  Table [dbo].[Additional_equipment]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Additional_equipment](
	[id_buying _car] [int] IDENTITY(1,1) NOT NULL,
	[id_Additional equipment] [int] NULL,
	[Price] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[buying_car]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[buying_car](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[car] [int] NULL,
	[staff] [int] NULL,
	[car_Price] [money] NULL,
	[Discount] [nchar](10) NULL,
	[Final_price] [money] NULL,
	[date_transaction] [nchar](10) NULL,
 CONSTRAINT [PK_buying_car] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](20) NOT NULL,
	[Surname] [nchar](20) NOT NULL,
	[Middle_name] [nchar](20) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client_Contact_information]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client_Contact_information](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[address] [nchar](100) NULL,
	[telephone 1] [nchar](18) NULL,
	[telephone 2] [nchar](18) NULL,
 CONSTRAINT [PK_Client_Contact_information] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client_Personal_data]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client_Personal_data](
	[id] [int] NOT NULL,
	[Document] [int] NULL,
	[Series] [nchar](10) NULL,
	[Number] [int] NULL,
	[When_issued] [nchar](10) NULL,
	[Issued_by_whom] [nchar](100) NULL,
 CONSTRAINT [PK_Client_Personal_data] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client's_transactions]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client's_transactions](
	[id_client] [int] NULL,
	[id_deal] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Generations_car_model]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Generations_car_model](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_car_model] [int] NULL,
	[Generations] [nchar](30) NULL,
 CONSTRAINT [PK_Generations_car_model] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LCA]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LCA](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Level] [nchar](10) NULL,
	[Description] [nchar](100) NULL,
 CONSTRAINT [PK_LCA] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[refbok_car_models]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[refbok_car_models](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](10) NULL,
 CONSTRAINT [PK_refbok_car_models] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[refbook_body_type]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[refbook_body_type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](30) NULL,
	[Number_doors] [int] NULL,
	[frame] [bit] NULL,
	[number_seats] [int] NULL,
 CONSTRAINT [PK_refbook_body_type] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[refbook_Colour]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[refbook_Colour](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](30) NULL,
	[color_code] [nchar](30) NULL,
 CONSTRAINT [PK_refbook_Colour] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[refbook_document]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[refbook_document](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](10) NULL,
 CONSTRAINT [PK_refbook_document] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[refbook_drive_unit]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[refbook_drive_unit](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](30) NULL,
 CONSTRAINT [PK_refbook_drive_unit] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[refbook_engine]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[refbook_engine](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[volume] [float] NULL,
	[type] [nchar](20) NULL,
	[power] [int] NULL,
 CONSTRAINT [PK_refbook_engine] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[refbook_equipments]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[refbook_equipments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](100) NULL,
	[Price] [money] NULL,
 CONSTRAINT [PK_refbook_equipments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[refbook_headlight type]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[refbook_headlight type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](30) NULL,
 CONSTRAINT [PK_refbook_headlight type] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[refbook_Positions]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[refbook_Positions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](20) NULL,
 CONSTRAINT [PK_refbook_Positions] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[refbook_status]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[refbook_status](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nchar](10) NULL,
 CONSTRAINT [PK_refbook_status] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[refbook_statys_car]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[refbook_statys_car](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](20) NULL,
 CONSTRAINT [PK_refbook_statys_car] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[refbook_wheel_size]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[refbook_wheel_size](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](10) NULL,
 CONSTRAINT [PK_refbook_wheel_size] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[refbool_equipment]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[refbool_equipment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[engine] [int] NULL,
	[drive_unit] [int] NULL,
	[headlight_type] [int] NULL,
	[wheel_size] [int] NULL,
	[Colour] [int] NULL,
	[body_type] [int] NULL,
 CONSTRAINT [PK_refbool_equipment] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](10) NULL,
	[Surname] [nchar](10) NULL,
	[Middle_name] [nchar](10) NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff_Career]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff_Career](
	[id_staff] [int] NOT NULL,
	[Experience] [int] NULL,
	[id_Position] [int] NULL,
	[id_Goals] [int] NULL,
	[Date of employment] [nchar](10) NULL,
	[Date of dismissal] [nchar](10) NULL,
	[id_Status] [int] NULL,
	[Privileges] [int] NULL,
 CONSTRAINT [PK_Staff_Career] PRIMARY KEY CLUSTERED 
(
	[id_staff] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff_Contact_information]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff_Contact_information](
	[id] [int] NOT NULL,
	[adress] [nchar](100) NULL,
	[telephone 1] [nchar](18) NULL,
	[telephone 2] [nchar](18) NULL,
 CONSTRAINT [PK_Staff_Contact_information] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff_goal]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff_goal](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Date of issue of the goal] [nchar](10) NULL,
	[Goal end date] [nchar](10) NULL,
	[Goal] [nchar](50) NULL,
 CONSTRAINT [PK_Staff_goal] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff_Personal_data]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff_Personal_data](
	[id] [int] NOT NULL,
	[Series] [nchar](10) NULL,
	[Number] [nchar](10) NULL,
	[When_issued] [nchar](10) NULL,
	[Issued_by_whom] [nchar](100) NULL,
 CONSTRAINT [PK_Staff_Personal_data] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status_car_models]    Script Date: 12.01.2021 18:41:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status_car_models](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_car_models] [int] NULL,
	[Status] [int] NULL,
	[id_Generations] [int] NULL,
	[equipment] [int] NULL,
 CONSTRAINT [PK_Status_car_models] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Additional_equipment]  WITH CHECK ADD  CONSTRAINT [FK_Additional_equipment_buying_car] FOREIGN KEY([id_buying _car])
REFERENCES [dbo].[buying_car] ([id])
GO
ALTER TABLE [dbo].[Additional_equipment] CHECK CONSTRAINT [FK_Additional_equipment_buying_car]
GO
ALTER TABLE [dbo].[Additional_equipment]  WITH CHECK ADD  CONSTRAINT [FK_Additional_equipment_refbook_equipments] FOREIGN KEY([id_Additional equipment])
REFERENCES [dbo].[refbook_equipments] ([id])
GO
ALTER TABLE [dbo].[Additional_equipment] CHECK CONSTRAINT [FK_Additional_equipment_refbook_equipments]
GO
ALTER TABLE [dbo].[buying_car]  WITH CHECK ADD  CONSTRAINT [FK_buying_car_Staff] FOREIGN KEY([staff])
REFERENCES [dbo].[Staff] ([id])
GO
ALTER TABLE [dbo].[buying_car] CHECK CONSTRAINT [FK_buying_car_Staff]
GO
ALTER TABLE [dbo].[buying_car]  WITH CHECK ADD  CONSTRAINT [FK_buying_car_Status_car_models] FOREIGN KEY([car])
REFERENCES [dbo].[Status_car_models] ([id])
GO
ALTER TABLE [dbo].[buying_car] CHECK CONSTRAINT [FK_buying_car_Status_car_models]
GO
ALTER TABLE [dbo].[Client_Contact_information]  WITH CHECK ADD  CONSTRAINT [FK_Client_Contact_information_Client] FOREIGN KEY([id])
REFERENCES [dbo].[Client] ([id])
GO
ALTER TABLE [dbo].[Client_Contact_information] CHECK CONSTRAINT [FK_Client_Contact_information_Client]
GO
ALTER TABLE [dbo].[Client_Personal_data]  WITH CHECK ADD  CONSTRAINT [FK_Client_Personal_data_Client] FOREIGN KEY([id])
REFERENCES [dbo].[Client] ([id])
GO
ALTER TABLE [dbo].[Client_Personal_data] CHECK CONSTRAINT [FK_Client_Personal_data_Client]
GO
ALTER TABLE [dbo].[Client_Personal_data]  WITH CHECK ADD  CONSTRAINT [FK_Client_Personal_data_refbook_document] FOREIGN KEY([Document])
REFERENCES [dbo].[refbook_document] ([id])
GO
ALTER TABLE [dbo].[Client_Personal_data] CHECK CONSTRAINT [FK_Client_Personal_data_refbook_document]
GO
ALTER TABLE [dbo].[Client's_transactions]  WITH CHECK ADD  CONSTRAINT [FK_Client's_transactions_buying_car] FOREIGN KEY([id_deal])
REFERENCES [dbo].[buying_car] ([id])
GO
ALTER TABLE [dbo].[Client's_transactions] CHECK CONSTRAINT [FK_Client's_transactions_buying_car]
GO
ALTER TABLE [dbo].[Client's_transactions]  WITH CHECK ADD  CONSTRAINT [FK_Client's_transactions_Client] FOREIGN KEY([id_client])
REFERENCES [dbo].[Client] ([id])
GO
ALTER TABLE [dbo].[Client's_transactions] CHECK CONSTRAINT [FK_Client's_transactions_Client]
GO
ALTER TABLE [dbo].[Generations_car_model]  WITH CHECK ADD  CONSTRAINT [FK_Generations_car_model_refbok_car_models] FOREIGN KEY([id_car_model])
REFERENCES [dbo].[refbok_car_models] ([id])
GO
ALTER TABLE [dbo].[Generations_car_model] CHECK CONSTRAINT [FK_Generations_car_model_refbok_car_models]
GO
ALTER TABLE [dbo].[refbool_equipment]  WITH CHECK ADD  CONSTRAINT [FK_refbool_equipment_refbook_body_type] FOREIGN KEY([body_type])
REFERENCES [dbo].[refbook_body_type] ([id])
GO
ALTER TABLE [dbo].[refbool_equipment] CHECK CONSTRAINT [FK_refbool_equipment_refbook_body_type]
GO
ALTER TABLE [dbo].[refbool_equipment]  WITH CHECK ADD  CONSTRAINT [FK_refbool_equipment_refbook_Colour] FOREIGN KEY([Colour])
REFERENCES [dbo].[refbook_Colour] ([id])
GO
ALTER TABLE [dbo].[refbool_equipment] CHECK CONSTRAINT [FK_refbool_equipment_refbook_Colour]
GO
ALTER TABLE [dbo].[refbool_equipment]  WITH CHECK ADD  CONSTRAINT [FK_refbool_equipment_refbook_drive_unit] FOREIGN KEY([drive_unit])
REFERENCES [dbo].[refbook_drive_unit] ([id])
GO
ALTER TABLE [dbo].[refbool_equipment] CHECK CONSTRAINT [FK_refbool_equipment_refbook_drive_unit]
GO
ALTER TABLE [dbo].[refbool_equipment]  WITH CHECK ADD  CONSTRAINT [FK_refbool_equipment_refbook_engine] FOREIGN KEY([engine])
REFERENCES [dbo].[refbook_engine] ([id])
GO
ALTER TABLE [dbo].[refbool_equipment] CHECK CONSTRAINT [FK_refbool_equipment_refbook_engine]
GO
ALTER TABLE [dbo].[refbool_equipment]  WITH CHECK ADD  CONSTRAINT [FK_refbool_equipment_refbook_headlight type] FOREIGN KEY([headlight_type])
REFERENCES [dbo].[refbook_headlight type] ([id])
GO
ALTER TABLE [dbo].[refbool_equipment] CHECK CONSTRAINT [FK_refbool_equipment_refbook_headlight type]
GO
ALTER TABLE [dbo].[refbool_equipment]  WITH CHECK ADD  CONSTRAINT [FK_refbool_equipment_refbook_wheel_size] FOREIGN KEY([wheel_size])
REFERENCES [dbo].[refbook_wheel_size] ([id])
GO
ALTER TABLE [dbo].[refbool_equipment] CHECK CONSTRAINT [FK_refbool_equipment_refbook_wheel_size]
GO
ALTER TABLE [dbo].[Staff_Career]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Career_LCA] FOREIGN KEY([Privileges])
REFERENCES [dbo].[LCA] ([id])
GO
ALTER TABLE [dbo].[Staff_Career] CHECK CONSTRAINT [FK_Staff_Career_LCA]
GO
ALTER TABLE [dbo].[Staff_Career]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Career_refbook_Positions] FOREIGN KEY([id_Position])
REFERENCES [dbo].[refbook_Positions] ([id])
GO
ALTER TABLE [dbo].[Staff_Career] CHECK CONSTRAINT [FK_Staff_Career_refbook_Positions]
GO
ALTER TABLE [dbo].[Staff_Career]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Career_refbook_status] FOREIGN KEY([id_Status])
REFERENCES [dbo].[refbook_status] ([id])
GO
ALTER TABLE [dbo].[Staff_Career] CHECK CONSTRAINT [FK_Staff_Career_refbook_status]
GO
ALTER TABLE [dbo].[Staff_Career]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Career_Staff] FOREIGN KEY([id_staff])
REFERENCES [dbo].[Staff] ([id])
GO
ALTER TABLE [dbo].[Staff_Career] CHECK CONSTRAINT [FK_Staff_Career_Staff]
GO
ALTER TABLE [dbo].[Staff_Career]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Career_Staff_goal] FOREIGN KEY([id_Goals])
REFERENCES [dbo].[Staff_goal] ([id])
GO
ALTER TABLE [dbo].[Staff_Career] CHECK CONSTRAINT [FK_Staff_Career_Staff_goal]
GO
ALTER TABLE [dbo].[Staff_Contact_information]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Contact_information_Staff] FOREIGN KEY([id])
REFERENCES [dbo].[Staff] ([id])
GO
ALTER TABLE [dbo].[Staff_Contact_information] CHECK CONSTRAINT [FK_Staff_Contact_information_Staff]
GO
ALTER TABLE [dbo].[Staff_Personal_data]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Personal_data_Staff] FOREIGN KEY([id])
REFERENCES [dbo].[Staff] ([id])
GO
ALTER TABLE [dbo].[Staff_Personal_data] CHECK CONSTRAINT [FK_Staff_Personal_data_Staff]
GO
ALTER TABLE [dbo].[Status_car_models]  WITH CHECK ADD  CONSTRAINT [FK_Status_car_models_Generations_car_model] FOREIGN KEY([id_Generations])
REFERENCES [dbo].[Generations_car_model] ([id])
GO
ALTER TABLE [dbo].[Status_car_models] CHECK CONSTRAINT [FK_Status_car_models_Generations_car_model]
GO
ALTER TABLE [dbo].[Status_car_models]  WITH CHECK ADD  CONSTRAINT [FK_Status_car_models_refbook_statys_car] FOREIGN KEY([Status])
REFERENCES [dbo].[refbook_statys_car] ([id])
GO
ALTER TABLE [dbo].[Status_car_models] CHECK CONSTRAINT [FK_Status_car_models_refbook_statys_car]
GO
ALTER TABLE [dbo].[Status_car_models]  WITH CHECK ADD  CONSTRAINT [FK_Status_car_models_refbool_equipment] FOREIGN KEY([equipment])
REFERENCES [dbo].[refbool_equipment] ([id])
GO
ALTER TABLE [dbo].[Status_car_models] CHECK CONSTRAINT [FK_Status_car_models_refbool_equipment]
GO
USE [master]
GO
ALTER DATABASE [Motor_show] SET  READ_WRITE 
GO
