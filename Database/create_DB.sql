USE [master]
GO

/****** Object:  Database [szkolkarz]    Script Date: 2014-11-12 16:57:42 ******/
DROP DATABASE [szkolkarz]
GO

/****** Object:  Database [szkolkarz]    Script Date: 2014-11-12 16:57:42 ******/
CREATE DATABASE [szkolkarz]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'szkolkarz', FILENAME = N'D:\progi\MS SQL Server\MSSQL11.CHRUPEK\MSSQL\DATA\szkolkarz.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'szkolkarz_log', FILENAME = N'D:\progi\MS SQL Server\MSSQL11.CHRUPEK\MSSQL\DATA\szkolkarz_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [szkolkarz] SET COMPATIBILITY_LEVEL = 110
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [szkolkarz].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [szkolkarz] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [szkolkarz] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [szkolkarz] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [szkolkarz] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [szkolkarz] SET ARITHABORT OFF 
GO

ALTER DATABASE [szkolkarz] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [szkolkarz] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [szkolkarz] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [szkolkarz] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [szkolkarz] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [szkolkarz] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [szkolkarz] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [szkolkarz] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [szkolkarz] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [szkolkarz] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [szkolkarz] SET  DISABLE_BROKER 
GO

ALTER DATABASE [szkolkarz] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [szkolkarz] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [szkolkarz] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [szkolkarz] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [szkolkarz] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [szkolkarz] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [szkolkarz] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [szkolkarz] SET RECOVERY FULL 
GO

ALTER DATABASE [szkolkarz] SET  MULTI_USER 
GO

ALTER DATABASE [szkolkarz] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [szkolkarz] SET DB_CHAINING OFF 
GO

ALTER DATABASE [szkolkarz] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [szkolkarz] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [szkolkarz] SET  READ_WRITE 
GO

