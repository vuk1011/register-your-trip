﻿USE [master]
GO
/****** Object:  Database [Sistem za prijavu putovanja]    Script Date: 17-Feb-25 19:42:31 ******/
CREATE DATABASE [Sistem za prijavu putovanja]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Sistem za prijavu putovanja', FILENAME = N'C:\Users\vukpe\Sistem za prijavu putovanja.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Sistem za prijavu putovanja_log', FILENAME = N'C:\Users\vukpe\Sistem za prijavu putovanja_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Sistem za prijavu putovanja].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET ARITHABORT OFF 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET  MULTI_USER 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET QUERY_STORE = OFF
GO
USE [Sistem za prijavu putovanja]
GO
/****** Object:  Table [dbo].[DrzavaEU]    Script Date: 17-Feb-25 19:42:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DrzavaEU](
	[naziv] [nvarchar](50) NOT NULL,
	[kod] [char](2) NOT NULL,
 CONSTRAINT [PK_Drzava] PRIMARY KEY CLUSTERED 
(
	[naziv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Korisnik]    Script Date: 17-Feb-25 19:42:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Korisnik](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[jmbg] [char](13) NOT NULL,
	[brojPasosa] [char](9) NOT NULL,
	[ime] [nvarchar](50) NOT NULL,
	[prezime] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Korisnik] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prijava]    Script Date: 17-Feb-25 19:42:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prijava](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[ime] [nvarchar](50) NOT NULL,
	[prezime] [nvarchar](50) NOT NULL,
	[jmbg] [char](13) NOT NULL,
	[brojPasosa] [char](9) NOT NULL,
	[datumUlaska] [date] NOT NULL,
	[datumIzlaska] [date] NOT NULL,
	[nacinPrevoza] [nvarchar](50) NOT NULL,
	[trebaPlatiti] [bit] NOT NULL,
 CONSTRAINT [PK_Prijava] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PrijavaDrzavaEU]    Script Date: 17-Feb-25 19:42:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrijavaDrzavaEU](
	[prijava] [bigint] NOT NULL,
	[drzavaEU] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PrijavaDrzavaEU] PRIMARY KEY CLUSTERED 
(
	[prijava] ASC,
	[drzavaEU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Аустрија', N'AT')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Белгија', N'BE')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Бугарска', N'BG')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Грчка', N'EL')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Данска', N'DK')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Естонија', N'EE')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Ирска', N'IE')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Италија', N'IT')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Кипар', N'CY')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Летонија', N'LV')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Литванија', N'LT')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Луксембург', N'LU')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Мађарска', N'HU')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Малта', N'MT')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Немачка', N'DE')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Пољска', N'PL')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Португалија', N'PT')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Румунија', N'RO')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Словачка', N'SK')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Словенија', N'SI')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Финска', N'FI')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Француска', N'FR')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Холандија', N'NL')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Хрватска', N'HR')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Чешка', N'CZ')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Шведска', N'SE')
INSERT [dbo].[DrzavaEU] ([naziv], [kod]) VALUES (N'Шпанија', N'ES')
GO
INSERT [dbo].[Korisnik] ([username], [password], [email], [jmbg], [brojPasosa], [ime], [prezime]) VALUES (N'test', N'test', N'test@test.com', N'0101001000000', N'000000000', N'ТЕСТ', N'ТЕСТ')
GO
SET IDENTITY_INSERT [dbo].[Prijava] ON 

INSERT [dbo].[Prijava] ([id], [ime], [prezime], [jmbg], [brojPasosa], [datumUlaska], [datumIzlaska], [nacinPrevoza], [trebaPlatiti]) VALUES (70011, N'ТЕСТ', N'ТЕСТ', N'0101001000000', N'000000000', CAST(N'2025-02-20' AS Date), CAST(N'2025-02-20' AS Date), N'PUTNICKI_AUTOMOBIL', 1)
SET IDENTITY_INSERT [dbo].[Prijava] OFF
GO
USE [master]
GO
ALTER DATABASE [Sistem za prijavu putovanja] SET  READ_WRITE 
GO
