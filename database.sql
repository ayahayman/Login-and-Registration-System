USE [master]
GO
/****** Object:  Database [Login and Registration System]    Script Date: 7/17/2024 1:20:40 PM ******/
CREATE DATABASE [Login and Registration System]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Login and Registration System', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Login and Registration System.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Login and Registration System_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Login and Registration System_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Login and Registration System] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Login and Registration System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Login and Registration System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Login and Registration System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Login and Registration System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Login and Registration System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Login and Registration System] SET ARITHABORT OFF 
GO
ALTER DATABASE [Login and Registration System] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Login and Registration System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Login and Registration System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Login and Registration System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Login and Registration System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Login and Registration System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Login and Registration System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Login and Registration System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Login and Registration System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Login and Registration System] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Login and Registration System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Login and Registration System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Login and Registration System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Login and Registration System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Login and Registration System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Login and Registration System] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Login and Registration System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Login and Registration System] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Login and Registration System] SET  MULTI_USER 
GO
ALTER DATABASE [Login and Registration System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Login and Registration System] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Login and Registration System] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Login and Registration System] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Login and Registration System] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Login and Registration System] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Login and Registration System] SET QUERY_STORE = ON
GO
ALTER DATABASE [Login and Registration System] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Login and Registration System]
GO
/****** Object:  Table [dbo].[Account Details]    Script Date: 7/17/2024 1:20:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account Details](
	[Username] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Phone Number] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Login and Registration System] SET  READ_WRITE 
GO
