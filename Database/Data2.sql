USE [master]
GO
/****** Object:  Database [Scrum_StudentAccomodation]    Script Date: 4/25/2019 10:51:35 AM ******/
CREATE DATABASE [Scrum_StudentAccomodation]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Scrum_StudentAccomodation', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Scrum_StudentAccomodation.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Scrum_StudentAccomodation_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Scrum_StudentAccomodation_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Scrum_StudentAccomodation].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET ARITHABORT OFF 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET RECOVERY FULL 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET  MULTI_USER 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Scrum_StudentAccomodation', N'ON'
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET QUERY_STORE = OFF
GO
USE [Scrum_StudentAccomodation]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 4/25/2019 10:51:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[ID_Acc] [int] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[ID_Acc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[House]    Script Date: 4/25/2019 10:51:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[House](
	[ID_House] [int] NOT NULL,
	[ID_Acc] [int] NOT NULL,
	[ID_Type] [int] NOT NULL,
	[Adress] [nvarchar](50) NULL,
	[Area] [nvarchar](50) NULL,
	[Price] [nchar](10) NULL,
	[Contact] [nvarchar](50) NULL,
	[Image] [image] NULL,
 CONSTRAINT [PK_House] PRIMARY KEY CLUSTERED 
(
	[ID_House] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HouseType]    Script Date: 4/25/2019 10:51:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HouseType](
	[ID_Type] [int] NOT NULL,
	[Type] [nvarchar](50) NULL,
	[Description] [nvarchar](200) NULL,
 CONSTRAINT [PK_HouseType] PRIMARY KEY CLUSTERED 
(
	[ID_Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 4/25/2019 10:51:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID_Acc] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID_Acc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[House]  WITH CHECK ADD  CONSTRAINT [FK_House_Account] FOREIGN KEY([ID_Acc])
REFERENCES [dbo].[Account] ([ID_Acc])
GO
ALTER TABLE [dbo].[House] CHECK CONSTRAINT [FK_House_Account]
GO
ALTER TABLE [dbo].[House]  WITH CHECK ADD  CONSTRAINT [FK_House_HouseType1] FOREIGN KEY([ID_Type])
REFERENCES [dbo].[HouseType] ([ID_Type])
GO
ALTER TABLE [dbo].[House] CHECK CONSTRAINT [FK_House_HouseType1]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Account1] FOREIGN KEY([ID_Acc])
REFERENCES [dbo].[Account] ([ID_Acc])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Account1]
GO
USE [master]
GO
ALTER DATABASE [Scrum_StudentAccomodation] SET  READ_WRITE 
GO
