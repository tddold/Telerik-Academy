USE [master]
GO
/****** Object:  Database [Database_Modeling]    Script Date: 6.10.2015 г. 14:15:24 ******/
CREATE DATABASE [Database_Modeling]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Database_Modeling', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Database_Modeling.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Database_Modeling_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Database_Modeling_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Database_Modeling] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Database_Modeling].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Database_Modeling] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Database_Modeling] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Database_Modeling] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Database_Modeling] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Database_Modeling] SET ARITHABORT OFF 
GO
ALTER DATABASE [Database_Modeling] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Database_Modeling] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Database_Modeling] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Database_Modeling] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Database_Modeling] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Database_Modeling] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Database_Modeling] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Database_Modeling] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Database_Modeling] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Database_Modeling] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Database_Modeling] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Database_Modeling] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Database_Modeling] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Database_Modeling] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Database_Modeling] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Database_Modeling] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Database_Modeling] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Database_Modeling] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Database_Modeling] SET  MULTI_USER 
GO
ALTER DATABASE [Database_Modeling] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Database_Modeling] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Database_Modeling] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Database_Modeling] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Database_Modeling] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Database_Modeling]
GO
/****** Object:  Table [dbo].[ADDRESS]    Script Date: 6.10.2015 г. 14:15:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADDRESS](
	[AddressId] [int] IDENTITY(1,1) NOT NULL,
	[AddressText] [nchar](50) NULL,
	[TownId] [int] NOT NULL,
 CONSTRAINT [PK_ADDRESS] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CONTINENTS]    Script Date: 6.10.2015 г. 14:15:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONTINENTS](
	[ContinentId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) NOT NULL,
 CONSTRAINT [PK_CONTINENTS] PRIMARY KEY CLUSTERED 
(
	[ContinentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[COUNTRIES]    Script Date: 6.10.2015 г. 14:15:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COUNTRIES](
	[CountryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) NOT NULL,
	[ContinentId] [int] NOT NULL,
 CONSTRAINT [PK_COUNTRIES] PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PERSONS]    Script Date: 6.10.2015 г. 14:15:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERSONS](
	[PesonId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nchar](50) NOT NULL,
	[LastName] [nchar](50) NOT NULL,
	[AddressId] [int] NOT NULL,
 CONSTRAINT [PK_PERSONS] PRIMARY KEY CLUSTERED 
(
	[PesonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TOWNS]    Script Date: 6.10.2015 г. 14:15:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TOWNS](
	[TownId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) NOT NULL,
	[CountryId] [int] NOT NULL,
 CONSTRAINT [PK_TOWNS] PRIMARY KEY CLUSTERED 
(
	[TownId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[ADDRESS] ON 

INSERT [dbo].[ADDRESS] ([AddressId], [AddressText], [TownId]) VALUES (1, N'Al. Malinov 20                                    ', 1)
INSERT [dbo].[ADDRESS] ([AddressId], [AddressText], [TownId]) VALUES (2, N'Nqkoia ulica                                      ', 2)
INSERT [dbo].[ADDRESS] ([AddressId], [AddressText], [TownId]) VALUES (3, N'Dryga ulica                                       ', 3)
SET IDENTITY_INSERT [dbo].[ADDRESS] OFF
SET IDENTITY_INSERT [dbo].[CONTINENTS] ON 

INSERT [dbo].[CONTINENTS] ([ContinentId], [Name]) VALUES (1, N'Europe                                            ')
INSERT [dbo].[CONTINENTS] ([ContinentId], [Name]) VALUES (2, N'North America                                     ')
INSERT [dbo].[CONTINENTS] ([ContinentId], [Name]) VALUES (3, N'South Amerika                                     ')
INSERT [dbo].[CONTINENTS] ([ContinentId], [Name]) VALUES (4, N'Africa                                            ')
INSERT [dbo].[CONTINENTS] ([ContinentId], [Name]) VALUES (5, N'Australia                                         ')
INSERT [dbo].[CONTINENTS] ([ContinentId], [Name]) VALUES (6, N'Antarctica                                        ')
SET IDENTITY_INSERT [dbo].[CONTINENTS] OFF
SET IDENTITY_INSERT [dbo].[COUNTRIES] ON 

INSERT [dbo].[COUNTRIES] ([CountryId], [Name], [ContinentId]) VALUES (1, N'Bulgaria                                          ', 1)
INSERT [dbo].[COUNTRIES] ([CountryId], [Name], [ContinentId]) VALUES (2, N'USA                                               ', 2)
INSERT [dbo].[COUNTRIES] ([CountryId], [Name], [ContinentId]) VALUES (3, N'UK                                                ', 1)
INSERT [dbo].[COUNTRIES] ([CountryId], [Name], [ContinentId]) VALUES (4, N'Germany                                           ', 1)
SET IDENTITY_INSERT [dbo].[COUNTRIES] OFF
SET IDENTITY_INSERT [dbo].[PERSONS] ON 

INSERT [dbo].[PERSONS] ([PesonId], [FirstName], [LastName], [AddressId]) VALUES (3, N'Pesho                                             ', N'Peshev                                            ', 1)
INSERT [dbo].[PERSONS] ([PesonId], [FirstName], [LastName], [AddressId]) VALUES (4, N'Ivan                                              ', N'Ivanov                                            ', 2)
INSERT [dbo].[PERSONS] ([PesonId], [FirstName], [LastName], [AddressId]) VALUES (5, N'Gosho                                             ', N'Goshev                                            ', 1)
SET IDENTITY_INSERT [dbo].[PERSONS] OFF
SET IDENTITY_INSERT [dbo].[TOWNS] ON 

INSERT [dbo].[TOWNS] ([TownId], [Name], [CountryId]) VALUES (1, N'Sofia                                             ', 1)
INSERT [dbo].[TOWNS] ([TownId], [Name], [CountryId]) VALUES (2, N'New York                                          ', 2)
INSERT [dbo].[TOWNS] ([TownId], [Name], [CountryId]) VALUES (3, N'London                                            ', 3)
INSERT [dbo].[TOWNS] ([TownId], [Name], [CountryId]) VALUES (4, N'Berlin                                            ', 4)
SET IDENTITY_INSERT [dbo].[TOWNS] OFF
ALTER TABLE [dbo].[ADDRESS]  WITH CHECK ADD  CONSTRAINT [FK_ADDRESS_TOWNS] FOREIGN KEY([TownId])
REFERENCES [dbo].[TOWNS] ([TownId])
GO
ALTER TABLE [dbo].[ADDRESS] CHECK CONSTRAINT [FK_ADDRESS_TOWNS]
GO
ALTER TABLE [dbo].[COUNTRIES]  WITH CHECK ADD  CONSTRAINT [FK_COUNTRIES_CONTINENTS] FOREIGN KEY([ContinentId])
REFERENCES [dbo].[CONTINENTS] ([ContinentId])
GO
ALTER TABLE [dbo].[COUNTRIES] CHECK CONSTRAINT [FK_COUNTRIES_CONTINENTS]
GO
ALTER TABLE [dbo].[PERSONS]  WITH CHECK ADD  CONSTRAINT [FK_PERSONS_ADDRESS] FOREIGN KEY([AddressId])
REFERENCES [dbo].[ADDRESS] ([AddressId])
GO
ALTER TABLE [dbo].[PERSONS] CHECK CONSTRAINT [FK_PERSONS_ADDRESS]
GO
ALTER TABLE [dbo].[TOWNS]  WITH CHECK ADD  CONSTRAINT [FK_TOWNS_COUNTRIES] FOREIGN KEY([CountryId])
REFERENCES [dbo].[COUNTRIES] ([CountryId])
GO
ALTER TABLE [dbo].[TOWNS] CHECK CONSTRAINT [FK_TOWNS_COUNTRIES]
GO
USE [master]
GO
ALTER DATABASE [Database_Modeling] SET  READ_WRITE 
GO
