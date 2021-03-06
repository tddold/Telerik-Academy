USE [master]
GO
/****** Object:  Database [University]    Script Date: 6.10.2015 г. 19:28:01 ******/
CREATE DATABASE [University]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Universities', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Universities .mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Universities _log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Universities _log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [University] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [University].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [University] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [University] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [University] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [University] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [University] SET ARITHABORT OFF 
GO
ALTER DATABASE [University] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [University] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [University] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [University] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [University] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [University] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [University] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [University] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [University] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [University] SET  DISABLE_BROKER 
GO
ALTER DATABASE [University] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [University] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [University] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [University] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [University] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [University] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [University] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [University] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [University] SET  MULTI_USER 
GO
ALTER DATABASE [University] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [University] SET DB_CHAINING OFF 
GO
ALTER DATABASE [University] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [University] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [University] SET DELAYED_DURABILITY = DISABLED 
GO
USE [University]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 6.10.2015 г. 19:28:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[CoursId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) NOT NULL,
	[ProfessorId] [int] NOT NULL,
	[DepartamentId] [int] NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[CoursId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departments]    Script Date: 6.10.2015 г. 19:28:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[DepartmantId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) NOT NULL,
	[FacultyId] [int] NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[DepartmantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 6.10.2015 г. 19:28:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculties](
	[FacultyId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[FacultyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Professors]    Script Date: 6.10.2015 г. 19:28:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professors](
	[ProfessorId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) NOT NULL,
	[DepartamentId] [int] NOT NULL,
 CONSTRAINT [PK_Professors] PRIMARY KEY CLUSTERED 
(
	[ProfessorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 6.10.2015 г. 19:28:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) NOT NULL,
	[FacultyId] [int] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentsCurses]    Script Date: 6.10.2015 г. 19:28:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentsCurses](
	[StudentId] [int] NOT NULL,
	[CourseId] [int] NOT NULL,
 CONSTRAINT [PK_StudentsCurses_1] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC,
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Titles]    Script Date: 6.10.2015 г. 19:28:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Titles](
	[TitleId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Titles] PRIMARY KEY CLUSTERED 
(
	[TitleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TitlesProfessors]    Script Date: 6.10.2015 г. 19:28:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TitlesProfessors](
	[TitlesId] [int] NOT NULL,
	[ProfessorsId] [int] NOT NULL,
 CONSTRAINT [PK_TitlesProfessors] PRIMARY KEY CLUSTERED 
(
	[TitlesId] ASC,
	[ProfessorsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Courses] ON 

INSERT [dbo].[Courses] ([CoursId], [Name], [ProfessorId], [DepartamentId]) VALUES (1, N'Introduction to Computers and Computing           ', 1, 1)
INSERT [dbo].[Courses] ([CoursId], [Name], [ProfessorId], [DepartamentId]) VALUES (2, N'Programming Concepts                              ', 2, 1)
INSERT [dbo].[Courses] ([CoursId], [Name], [ProfessorId], [DepartamentId]) VALUES (3, N'Basic Drawing                                     ', 3, 1)
INSERT [dbo].[Courses] ([CoursId], [Name], [ProfessorId], [DepartamentId]) VALUES (4, N'Graphic Communications                            ', 3, 1)
INSERT [dbo].[Courses] ([CoursId], [Name], [ProfessorId], [DepartamentId]) VALUES (6, N'Electronic Devices and Analog Circuits            ', 4, 2)
SET IDENTITY_INSERT [dbo].[Courses] OFF
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([DepartmantId], [Name], [FacultyId]) VALUES (1, N'Computer systems and technologies                 ', 1)
INSERT [dbo].[Departments] ([DepartmantId], [Name], [FacultyId]) VALUES (2, N'Electronics                                       ', 1)
INSERT [dbo].[Departments] ([DepartmantId], [Name], [FacultyId]) VALUES (3, N'Automation, Information and Control Engineering   ', 1)
INSERT [dbo].[Departments] ([DepartmantId], [Name], [FacultyId]) VALUES (4, N'Electrical                                        ', 1)
INSERT [dbo].[Departments] ([DepartmantId], [Name], [FacultyId]) VALUES (5, N'Industrial ecology                                ', 1)
INSERT [dbo].[Departments] ([DepartmantId], [Name], [FacultyId]) VALUES (6, N'Industrial Engineering (English)                  ', 1)
INSERT [dbo].[Departments] ([DepartmantId], [Name], [FacultyId]) VALUES (7, N'Optoelectronics and Laser Technology              ', 1)
INSERT [dbo].[Departments] ([DepartmantId], [Name], [FacultyId]) VALUES (10, N'Signaling equipment and automated systems security', 1)
INSERT [dbo].[Departments] ([DepartmantId], [Name], [FacultyId]) VALUES (11, N'Mechanical and Instrument Engineering             ', 2)
INSERT [dbo].[Departments] ([DepartmantId], [Name], [FacultyId]) VALUES (12, N'Manufacturing Technologies                        ', 2)
INSERT [dbo].[Departments] ([DepartmantId], [Name], [FacultyId]) VALUES (13, N'Mechatronics                                      ', 2)
INSERT [dbo].[Departments] ([DepartmantId], [Name], [FacultyId]) VALUES (14, N'Transport Equipment and Technology                ', 2)
INSERT [dbo].[Departments] ([DepartmantId], [Name], [FacultyId]) VALUES (15, N'Aeronautical Engineering                          ', 2)
INSERT [dbo].[Departments] ([DepartmantId], [Name], [FacultyId]) VALUES (16, N'Industrial Management                             ', 2)
INSERT [dbo].[Departments] ([DepartmantId], [Name], [FacultyId]) VALUES (17, N'Polygraphy                                        ', 2)
SET IDENTITY_INSERT [dbo].[Departments] OFF
SET IDENTITY_INSERT [dbo].[Faculties] ON 

INSERT [dbo].[Faculties] ([FacultyId], [Name]) VALUES (1, N'Electronics and Automatics                        ')
INSERT [dbo].[Faculties] ([FacultyId], [Name]) VALUES (2, N'Mechanical and Instrument Engineering             ')
SET IDENTITY_INSERT [dbo].[Faculties] OFF
SET IDENTITY_INSERT [dbo].[Professors] ON 

INSERT [dbo].[Professors] ([ProfessorId], [Name], [DepartamentId]) VALUES (1, N'Petrov                                            ', 1)
INSERT [dbo].[Professors] ([ProfessorId], [Name], [DepartamentId]) VALUES (2, N'Ivanov                                            ', 1)
INSERT [dbo].[Professors] ([ProfessorId], [Name], [DepartamentId]) VALUES (3, N'Peshev                                            ', 2)
INSERT [dbo].[Professors] ([ProfessorId], [Name], [DepartamentId]) VALUES (4, N'Georgiev                                          ', 3)
SET IDENTITY_INSERT [dbo].[Professors] OFF
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([StudentId], [Name], [FacultyId]) VALUES (1, N'Pesho Peshev                                      ', 1)
INSERT [dbo].[Students] ([StudentId], [Name], [FacultyId]) VALUES (2, N'Ivan Ivanov                                       ', 1)
INSERT [dbo].[Students] ([StudentId], [Name], [FacultyId]) VALUES (3, N'Gosho Goshev                                      ', 2)
INSERT [dbo].[Students] ([StudentId], [Name], [FacultyId]) VALUES (4, N'Mitko Mitev                                       ', 2)
SET IDENTITY_INSERT [dbo].[Students] OFF
INSERT [dbo].[StudentsCurses] ([StudentId], [CourseId]) VALUES (1, 1)
INSERT [dbo].[StudentsCurses] ([StudentId], [CourseId]) VALUES (1, 2)
INSERT [dbo].[StudentsCurses] ([StudentId], [CourseId]) VALUES (1, 3)
INSERT [dbo].[StudentsCurses] ([StudentId], [CourseId]) VALUES (1, 4)
INSERT [dbo].[StudentsCurses] ([StudentId], [CourseId]) VALUES (2, 1)
INSERT [dbo].[StudentsCurses] ([StudentId], [CourseId]) VALUES (2, 2)
INSERT [dbo].[StudentsCurses] ([StudentId], [CourseId]) VALUES (2, 3)
INSERT [dbo].[StudentsCurses] ([StudentId], [CourseId]) VALUES (3, 4)
INSERT [dbo].[StudentsCurses] ([StudentId], [CourseId]) VALUES (3, 6)
INSERT [dbo].[StudentsCurses] ([StudentId], [CourseId]) VALUES (4, 4)
INSERT [dbo].[StudentsCurses] ([StudentId], [CourseId]) VALUES (4, 6)
SET IDENTITY_INSERT [dbo].[Titles] ON 

INSERT [dbo].[Titles] ([TitleId], [Name]) VALUES (1, N'Ph. D                                             ')
INSERT [dbo].[Titles] ([TitleId], [Name]) VALUES (2, N'Academician                                       ')
INSERT [dbo].[Titles] ([TitleId], [Name]) VALUES (3, N'Senior assistant                                  ')
SET IDENTITY_INSERT [dbo].[Titles] OFF
INSERT [dbo].[TitlesProfessors] ([TitlesId], [ProfessorsId]) VALUES (1, 1)
INSERT [dbo].[TitlesProfessors] ([TitlesId], [ProfessorsId]) VALUES (1, 4)
INSERT [dbo].[TitlesProfessors] ([TitlesId], [ProfessorsId]) VALUES (2, 2)
INSERT [dbo].[TitlesProfessors] ([TitlesId], [ProfessorsId]) VALUES (3, 3)
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Departments] FOREIGN KEY([DepartamentId])
REFERENCES [dbo].[Departments] ([DepartmantId])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Departments]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Professors] FOREIGN KEY([ProfessorId])
REFERENCES [dbo].[Professors] ([ProfessorId])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Professors]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Faculties] FOREIGN KEY([FacultyId])
REFERENCES [dbo].[Faculties] ([FacultyId])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Faculties]
GO
ALTER TABLE [dbo].[Professors]  WITH CHECK ADD  CONSTRAINT [FK_Professors_Departments] FOREIGN KEY([DepartamentId])
REFERENCES [dbo].[Departments] ([DepartmantId])
GO
ALTER TABLE [dbo].[Professors] CHECK CONSTRAINT [FK_Professors_Departments]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Faculties] FOREIGN KEY([FacultyId])
REFERENCES [dbo].[Faculties] ([FacultyId])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Faculties]
GO
ALTER TABLE [dbo].[StudentsCurses]  WITH CHECK ADD  CONSTRAINT [FK_StudentsCurses_Courses] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Courses] ([CoursId])
GO
ALTER TABLE [dbo].[StudentsCurses] CHECK CONSTRAINT [FK_StudentsCurses_Courses]
GO
ALTER TABLE [dbo].[StudentsCurses]  WITH CHECK ADD  CONSTRAINT [FK_StudentsCurses_Students] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([StudentId])
GO
ALTER TABLE [dbo].[StudentsCurses] CHECK CONSTRAINT [FK_StudentsCurses_Students]
GO
ALTER TABLE [dbo].[TitlesProfessors]  WITH CHECK ADD  CONSTRAINT [FK_TitlesProfessors_Professors] FOREIGN KEY([ProfessorsId])
REFERENCES [dbo].[Professors] ([ProfessorId])
GO
ALTER TABLE [dbo].[TitlesProfessors] CHECK CONSTRAINT [FK_TitlesProfessors_Professors]
GO
ALTER TABLE [dbo].[TitlesProfessors]  WITH CHECK ADD  CONSTRAINT [FK_TitlesProfessors_Titles] FOREIGN KEY([TitlesId])
REFERENCES [dbo].[Titles] ([TitleId])
GO
ALTER TABLE [dbo].[TitlesProfessors] CHECK CONSTRAINT [FK_TitlesProfessors_Titles]
GO
USE [master]
GO
ALTER DATABASE [University] SET  READ_WRITE 
GO
