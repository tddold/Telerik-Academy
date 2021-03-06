USE [master]
GO
/****** Object:  Database [Dictionary]    Script Date: 7.10.2015 г. 13:33:53 ******/
CREATE DATABASE [Dictionary]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Dictionary', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Dictionary.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Dictionary_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Dictionary_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Dictionary] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Dictionary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Dictionary] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Dictionary] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Dictionary] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Dictionary] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Dictionary] SET ARITHABORT OFF 
GO
ALTER DATABASE [Dictionary] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Dictionary] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Dictionary] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Dictionary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Dictionary] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Dictionary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Dictionary] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Dictionary] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Dictionary] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Dictionary] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Dictionary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Dictionary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Dictionary] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Dictionary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Dictionary] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Dictionary] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Dictionary] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Dictionary] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Dictionary] SET  MULTI_USER 
GO
ALTER DATABASE [Dictionary] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Dictionary] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Dictionary] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Dictionary] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Dictionary] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Dictionary]
GO
/****** Object:  Table [dbo].[Languages]    Script Date: 7.10.2015 г. 13:33:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Languages](
	[LanguageId] [int] IDENTITY(1,1) NOT NULL,
	[Language] [nchar](100) NOT NULL,
 CONSTRAINT [PK_Languages] PRIMARY KEY CLUSTERED 
(
	[LanguageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Words]    Script Date: 7.10.2015 г. 13:33:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Words](
	[WordId] [int] IDENTITY(1,1) NOT NULL,
	[Word] [nchar](50) NOT NULL,
	[LanguageId] [int] NOT NULL,
 CONSTRAINT [PK_Words] PRIMARY KEY CLUSTERED 
(
	[WordId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Words_Explanations]    Script Date: 7.10.2015 г. 13:33:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Words_Explanations](
	[WordExplanationId] [int] IDENTITY(1,1) NOT NULL,
	[Explanation] [nchar](100) NOT NULL,
	[ExplanationLanguageId] [int] NOT NULL,
 CONSTRAINT [PK_Words_Explanations] PRIMARY KEY CLUSTERED 
(
	[WordExplanationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Words_Synonyms]    Script Date: 7.10.2015 г. 13:33:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Words_Synonyms](
	[WordSinonymId] [int] IDENTITY(1,1) NOT NULL,
	[WordId] [int] NOT NULL,
 CONSTRAINT [PK_Words_Synonyms_1] PRIMARY KEY CLUSTERED 
(
	[WordSinonymId] ASC,
	[WordId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Words_Translations]    Script Date: 7.10.2015 г. 13:33:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Words_Translations](
	[WordTranslationId] [int] IDENTITY(1,1) NOT NULL,
	[WordId] [int] NOT NULL,
 CONSTRAINT [PK_Words_Translations_1] PRIMARY KEY CLUSTERED 
(
	[WordTranslationId] ASC,
	[WordId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_Languages] FOREIGN KEY([LanguageId])
REFERENCES [dbo].[Languages] ([LanguageId])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_Languages]
GO
ALTER TABLE [dbo].[Words_Explanations]  WITH CHECK ADD  CONSTRAINT [FK_Words_Explanations_Languages] FOREIGN KEY([ExplanationLanguageId])
REFERENCES [dbo].[Languages] ([LanguageId])
GO
ALTER TABLE [dbo].[Words_Explanations] CHECK CONSTRAINT [FK_Words_Explanations_Languages]
GO
ALTER TABLE [dbo].[Words_Explanations]  WITH CHECK ADD  CONSTRAINT [FK_Words_Explanations_Words] FOREIGN KEY([ExplanationLanguageId])
REFERENCES [dbo].[Words] ([WordId])
GO
ALTER TABLE [dbo].[Words_Explanations] CHECK CONSTRAINT [FK_Words_Explanations_Words]
GO
ALTER TABLE [dbo].[Words_Synonyms]  WITH CHECK ADD  CONSTRAINT [FK_Words_Synonyms_Words] FOREIGN KEY([WordId])
REFERENCES [dbo].[Words] ([WordId])
GO
ALTER TABLE [dbo].[Words_Synonyms] CHECK CONSTRAINT [FK_Words_Synonyms_Words]
GO
ALTER TABLE [dbo].[Words_Synonyms]  WITH CHECK ADD  CONSTRAINT [FK_Words_Synonyms_Words1] FOREIGN KEY([WordSinonymId])
REFERENCES [dbo].[Words] ([WordId])
GO
ALTER TABLE [dbo].[Words_Synonyms] CHECK CONSTRAINT [FK_Words_Synonyms_Words1]
GO
ALTER TABLE [dbo].[Words_Translations]  WITH CHECK ADD  CONSTRAINT [FK_Words_Translations_Words] FOREIGN KEY([WordId])
REFERENCES [dbo].[Words] ([WordId])
GO
ALTER TABLE [dbo].[Words_Translations] CHECK CONSTRAINT [FK_Words_Translations_Words]
GO
ALTER TABLE [dbo].[Words_Translations]  WITH CHECK ADD  CONSTRAINT [FK_Words_Translations_Words1] FOREIGN KEY([WordTranslationId])
REFERENCES [dbo].[Words] ([WordId])
GO
ALTER TABLE [dbo].[Words_Translations] CHECK CONSTRAINT [FK_Words_Translations_Words1]
GO
USE [master]
GO
ALTER DATABASE [Dictionary] SET  READ_WRITE 
GO
