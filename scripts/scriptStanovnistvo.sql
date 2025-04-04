USE [master]
GO
/****** Object:  Database [Stanovnistvo]    Script Date: 17-Feb-25 19:43:17 ******/
CREATE DATABASE [Stanovnistvo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Stanovnistvo', FILENAME = N'C:\Users\vukpe\Stanovnistvo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Stanovnistvo_log', FILENAME = N'C:\Users\vukpe\Stanovnistvo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Stanovnistvo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Stanovnistvo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Stanovnistvo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Stanovnistvo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Stanovnistvo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Stanovnistvo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Stanovnistvo] SET ARITHABORT OFF 
GO
ALTER DATABASE [Stanovnistvo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Stanovnistvo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Stanovnistvo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Stanovnistvo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Stanovnistvo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Stanovnistvo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Stanovnistvo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Stanovnistvo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Stanovnistvo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Stanovnistvo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Stanovnistvo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Stanovnistvo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Stanovnistvo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Stanovnistvo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Stanovnistvo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Stanovnistvo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Stanovnistvo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Stanovnistvo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Stanovnistvo] SET  MULTI_USER 
GO
ALTER DATABASE [Stanovnistvo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Stanovnistvo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Stanovnistvo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Stanovnistvo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Stanovnistvo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Stanovnistvo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Stanovnistvo] SET QUERY_STORE = OFF
GO
USE [Stanovnistvo]
GO
/****** Object:  Table [dbo].[Stanovnik]    Script Date: 17-Feb-25 19:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stanovnik](
	[jmbg] [char](13) NOT NULL,
	[ime] [nvarchar](50) NOT NULL,
	[prezime] [nvarchar](50) NOT NULL,
	[brojPasosa] [char](9) NOT NULL,
 CONSTRAINT [PK_Stanovnik] PRIMARY KEY CLUSTERED 
(
	[jmbg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Stanovnik] ([jmbg], [ime], [prezime], [brojPasosa]) VALUES (N'0101000805028', N'АНА', N'АНТИЋ', N'306952971')
INSERT [dbo].[Stanovnik] ([jmbg], [ime], [prezime], [brojPasosa]) VALUES (N'0101001000000', N'ТЕСТ', N'ТЕСТ', N'000000000')
INSERT [dbo].[Stanovnik] ([jmbg], [ime], [prezime], [brojPasosa]) VALUES (N'0104952780771', N'ЉУБОМИР', N'КОВАЧ', N'331124829')
INSERT [dbo].[Stanovnik] ([jmbg], [ime], [prezime], [brojPasosa]) VALUES (N'0503998992001', N'МИЛОШ', N'РАДОВИЋ', N'683727108')
INSERT [dbo].[Stanovnik] ([jmbg], [ime], [prezime], [brojPasosa]) VALUES (N'1009943996508', N'ДЕСАНКА', N'МАРКОВИЋ', N'406531063')
INSERT [dbo].[Stanovnik] ([jmbg], [ime], [prezime], [brojPasosa]) VALUES (N'1511002731005', N'ВУК', N'ПЕРОВИЋ', N'031414230')
INSERT [dbo].[Stanovnik] ([jmbg], [ime], [prezime], [brojPasosa]) VALUES (N'1812975848540', N'ТИЈАНА', N'ЈОВАНОВИЋ', N'169879363')
INSERT [dbo].[Stanovnik] ([jmbg], [ime], [prezime], [brojPasosa]) VALUES (N'1910964798002', N'ТАТЈАНА', N'РАЈИЋ', N'652154330')
INSERT [dbo].[Stanovnik] ([jmbg], [ime], [prezime], [brojPasosa]) VALUES (N'2308970894981', N'ДРАГАН', N'РАКОЧЕВИЋ', N'832334723')
INSERT [dbo].[Stanovnik] ([jmbg], [ime], [prezime], [brojPasosa]) VALUES (N'2701968703031', N'НИКОЛА', N'СРЕЋКОВИЋ', N'834448257')
INSERT [dbo].[Stanovnik] ([jmbg], [ime], [prezime], [brojPasosa]) VALUES (N'3007994917716', N'МИЈА', N'СТАНКОВИЋ', N'764174350')
GO
USE [master]
GO
ALTER DATABASE [Stanovnistvo] SET  READ_WRITE 
GO
