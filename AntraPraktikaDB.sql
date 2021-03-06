USE [master]
GO
/****** Object:  Database [praktika_db]    Script Date: 2020-12-15 19:50:41 ******/
CREATE DATABASE [praktika_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'praktika_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\praktika_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'praktika_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\praktika_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [praktika_db] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [praktika_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [praktika_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [praktika_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [praktika_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [praktika_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [praktika_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [praktika_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [praktika_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [praktika_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [praktika_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [praktika_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [praktika_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [praktika_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [praktika_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [praktika_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [praktika_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [praktika_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [praktika_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [praktika_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [praktika_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [praktika_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [praktika_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [praktika_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [praktika_db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [praktika_db] SET  MULTI_USER 
GO
ALTER DATABASE [praktika_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [praktika_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [praktika_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [praktika_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [praktika_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [praktika_db] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [praktika_db] SET QUERY_STORE = OFF
GO
USE [praktika_db]
GO
/****** Object:  Table [dbo].[Evaluation]    Script Date: 2020-12-15 19:50:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evaluation](
	[Student_Id] [int] NULL,
	[Value] [int] NULL,
	[Comment] [nvarchar](50) NULL,
	[Date] [date] NULL,
	[Lesson_Id] [int] NULL,
	[Evaluation_Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Evaluation] PRIMARY KEY CLUSTERED 
(
	[Evaluation_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group_Lessons]    Script Date: 2020-12-15 19:50:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group_Lessons](
	[Lesson_Id] [int] NULL,
	[Group_Id] [int] NULL,
	[Teacher_Id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group_Students]    Script Date: 2020-12-15 19:50:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group_Students](
	[Group_Id] [int] NULL,
	[Student_Id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Groups]    Script Date: 2020-12-15 19:50:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Groups](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
 CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lessons]    Script Date: 2020-12-15 19:50:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lessons](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
 CONSTRAINT [PK_Lessons] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2020-12-15 19:50:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[Birthdate] [date] NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[UserType] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Evaluation]  WITH CHECK ADD  CONSTRAINT [FK_Evaluation_Users] FOREIGN KEY([Lesson_Id])
REFERENCES [dbo].[Lessons] ([Id])
GO
ALTER TABLE [dbo].[Evaluation] CHECK CONSTRAINT [FK_Evaluation_Users]
GO
ALTER TABLE [dbo].[Group_Lessons]  WITH CHECK ADD  CONSTRAINT [FK_Group_Lessons_Groups] FOREIGN KEY([Group_Id])
REFERENCES [dbo].[Groups] ([Id])
GO
ALTER TABLE [dbo].[Group_Lessons] CHECK CONSTRAINT [FK_Group_Lessons_Groups]
GO
ALTER TABLE [dbo].[Group_Lessons]  WITH CHECK ADD  CONSTRAINT [FK_Group_Lessons_Lessons] FOREIGN KEY([Lesson_Id])
REFERENCES [dbo].[Lessons] ([Id])
GO
ALTER TABLE [dbo].[Group_Lessons] CHECK CONSTRAINT [FK_Group_Lessons_Lessons]
GO
ALTER TABLE [dbo].[Group_Lessons]  WITH CHECK ADD  CONSTRAINT [FK_Group_Lessons_Users] FOREIGN KEY([Teacher_Id])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Group_Lessons] CHECK CONSTRAINT [FK_Group_Lessons_Users]
GO
ALTER TABLE [dbo].[Group_Students]  WITH CHECK ADD  CONSTRAINT [FK_Group_Students_Groups] FOREIGN KEY([Group_Id])
REFERENCES [dbo].[Groups] ([Id])
GO
ALTER TABLE [dbo].[Group_Students] CHECK CONSTRAINT [FK_Group_Students_Groups]
GO
ALTER TABLE [dbo].[Group_Students]  WITH CHECK ADD  CONSTRAINT [FK_Group_Students_Users] FOREIGN KEY([Student_Id])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Group_Students] CHECK CONSTRAINT [FK_Group_Students_Users]
GO
USE [master]
GO
ALTER DATABASE [praktika_db] SET  READ_WRITE 
GO
