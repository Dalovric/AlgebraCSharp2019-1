USE [master]
GO
/****** Object:  Database [upisi]    Script Date: 19.3.2019. 18:15:05 ******/
CREATE DATABASE [upisi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'upisi', FILENAME = N'D:\Code\AlgebraCSharp2019-1\ConsoleApp1\Baza\upisi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'upisi_log', FILENAME = N'D:\Code\AlgebraCSharp2019-1\ConsoleApp1\Baza\upisi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [upisi] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [upisi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [upisi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [upisi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [upisi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [upisi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [upisi] SET ARITHABORT OFF 
GO
ALTER DATABASE [upisi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [upisi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [upisi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [upisi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [upisi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [upisi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [upisi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [upisi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [upisi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [upisi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [upisi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [upisi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [upisi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [upisi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [upisi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [upisi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [upisi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [upisi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [upisi] SET  MULTI_USER 
GO
ALTER DATABASE [upisi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [upisi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [upisi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [upisi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [upisi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [upisi] SET QUERY_STORE = OFF
GO
USE [upisi]
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
USE [upisi]
GO
/****** Object:  Table [dbo].[polaznici]    Script Date: 19.3.2019. 18:15:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[polaznici](
	[id] [int] IDENTITY(4,1) NOT NULL,
	[ime] [nchar](50) NOT NULL,
	[prezime] [nchar](50) NOT NULL,
	[mjesto_stanovanja] [nchar](25) NULL,
 CONSTRAINT [PK_polaznici] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tecajevi]    Script Date: 19.3.2019. 18:15:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tecajevi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [varchar](50) NOT NULL,
	[cijena] [money] NULL,
 CONSTRAINT [PK_tecajevi] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[upisi]    Script Date: 19.3.2019. 18:15:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[upisi](
	[tecajevi_id] [int] NOT NULL,
	[polaznici_id] [int] NOT NULL,
 CONSTRAINT [PK_upisi] PRIMARY KEY CLUSTERED 
(
	[tecajevi_id] ASC,
	[polaznici_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[polaznici] ON 

INSERT [dbo].[polaznici] ([id], [ime], [prezime], [mjesto_stanovanja]) VALUES (1, N'Ana                                               ', N'Milić                                             ', N'Zagreb                   ')
INSERT [dbo].[polaznici] ([id], [ime], [prezime], [mjesto_stanovanja]) VALUES (2, N'Sanja                                             ', N'Tarak                                             ', N'Split                    ')
INSERT [dbo].[polaznici] ([id], [ime], [prezime], [mjesto_stanovanja]) VALUES (3, N'Mladen                                            ', N'Gork                                              ', N'Osijek                   ')
INSERT [dbo].[polaznici] ([id], [ime], [prezime], [mjesto_stanovanja]) VALUES (4, N'Ivana                                             ', N'Matkić                                            ', N'Split                    ')
INSERT [dbo].[polaznici] ([id], [ime], [prezime], [mjesto_stanovanja]) VALUES (5, N'Marina                                            ', N'Anić                                              ', N'Osijek                   ')
INSERT [dbo].[polaznici] ([id], [ime], [prezime], [mjesto_stanovanja]) VALUES (6, N'Ivica                                             ', N'Limac                                             ', N'Split                    ')
SET IDENTITY_INSERT [dbo].[polaznici] OFF
SET IDENTITY_INSERT [dbo].[tecajevi] ON 

INSERT [dbo].[tecajevi] ([id], [naziv], [cijena]) VALUES (1, N'Osnove rada PC racunala', 1000.0000)
INSERT [dbo].[tecajevi] ([id], [naziv], [cijena]) VALUES (2, N'Microsoft Word', 780.0000)
INSERT [dbo].[tecajevi] ([id], [naziv], [cijena]) VALUES (3, N'SQL - Osnove', 1600.0000)
INSERT [dbo].[tecajevi] ([id], [naziv], [cijena]) VALUES (4, N'Racunalni operator', 1800.0000)
INSERT [dbo].[tecajevi] ([id], [naziv], [cijena]) VALUES (5, N'Specijalist poslovne primjene racunala', 2000.0000)
INSERT [dbo].[tecajevi] ([id], [naziv], [cijena]) VALUES (6, N'Graficki dizajner', 1600.0000)
SET IDENTITY_INSERT [dbo].[tecajevi] OFF
INSERT [dbo].[upisi] ([tecajevi_id], [polaznici_id]) VALUES (1, 1)
INSERT [dbo].[upisi] ([tecajevi_id], [polaznici_id]) VALUES (2, 2)
INSERT [dbo].[upisi] ([tecajevi_id], [polaznici_id]) VALUES (3, 3)
INSERT [dbo].[upisi] ([tecajevi_id], [polaznici_id]) VALUES (4, 4)
INSERT [dbo].[upisi] ([tecajevi_id], [polaznici_id]) VALUES (5, 5)
INSERT [dbo].[upisi] ([tecajevi_id], [polaznici_id]) VALUES (6, 6)
ALTER TABLE [dbo].[upisi]  WITH CHECK ADD  CONSTRAINT [FK__upisi__polaznici__4222D4EF] FOREIGN KEY([polaznici_id])
REFERENCES [dbo].[polaznici] ([id])
GO
ALTER TABLE [dbo].[upisi] CHECK CONSTRAINT [FK__upisi__polaznici__4222D4EF]
GO
ALTER TABLE [dbo].[upisi]  WITH CHECK ADD  CONSTRAINT [FK_upisi_tecajevi] FOREIGN KEY([tecajevi_id])
REFERENCES [dbo].[tecajevi] ([id])
GO
ALTER TABLE [dbo].[upisi] CHECK CONSTRAINT [FK_upisi_tecajevi]
GO
ALTER TABLE [dbo].[polaznici]  WITH CHECK ADD  CONSTRAINT [chk_id] CHECK  (([id]>=(1) AND [id]<=(1000)))
GO
ALTER TABLE [dbo].[polaznici] CHECK CONSTRAINT [chk_id]
GO
USE [master]
GO
ALTER DATABASE [upisi] SET  READ_WRITE 
GO
