USE [master]
GO
/****** Object:  Database [DB_Sargar]    Script Date: 15-May-22 09:58:13 ******/
CREATE DATABASE [DB_Sargar]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SB_Sargar', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SB_Sargar.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SB_Sargar_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SB_Sargar_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DB_Sargar] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_Sargar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_Sargar] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_Sargar] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_Sargar] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_Sargar] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_Sargar] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_Sargar] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_Sargar] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_Sargar] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_Sargar] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_Sargar] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_Sargar] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_Sargar] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_Sargar] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_Sargar] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_Sargar] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_Sargar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_Sargar] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_Sargar] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_Sargar] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_Sargar] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_Sargar] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_Sargar] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_Sargar] SET RECOVERY FULL 
GO
ALTER DATABASE [DB_Sargar] SET  MULTI_USER 
GO
ALTER DATABASE [DB_Sargar] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_Sargar] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_Sargar] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_Sargar] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DB_Sargar] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DB_Sargar]
GO
/****** Object:  Table [dbo].[BranchMaster]    Script Date: 15-May-22 09:58:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BranchMaster](
	[BranchId] [int] IDENTITY(1,1) NOT NULL,
	[BranchName] [nvarchar](50) NOT NULL,
	[Branch] [nvarchar](50) NULL,
	[BrCode] [nvarchar](50) NULL,
	[UserCode] [nvarchar](50) NULL,
	[Time] [datetime] NULL,
	[IsActive] [nvarchar](50) NULL,
 CONSTRAINT [PK_BranchMaster] PRIMARY KEY CLUSTERED 
(
	[BranchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Department]    Script Date: 15-May-22 09:58:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[DeptId] [int] IDENTITY(1,1) NOT NULL,
	[DeptName] [nvarchar](50) NOT NULL,
	[DeptType] [nvarchar](50) NULL,
	[BrCode] [nvarchar](50) NULL,
	[UserCode] [nvarchar](50) NULL,
	[Time] [datetime] NULL,
	[IsActive] [nvarchar](50) NULL,
	[PreparedBy] [int] NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[DeptId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DeptType]    Script Date: 15-May-22 09:58:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeptType](
	[DeptId] [int] IDENTITY(1,1) NOT NULL,
	[DeptName] [nvarchar](50) NOT NULL,
	[IsActive] [nvarchar](50) NULL,
 CONSTRAINT [PK_DeptType] PRIMARY KEY CLUSTERED 
(
	[DeptId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Designation]    Script Date: 15-May-22 09:58:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Designation](
	[desgid] [int] IDENTITY(1,1) NOT NULL,
	[desg_name] [nvarchar](max) NOT NULL,
	[class] [nvarchar](50) NULL,
	[BrCode] [nvarchar](50) NULL,
	[UserCode] [nvarchar](50) NULL,
	[Time] [datetime] NULL,
	[BPay] [float] NULL,
	[GradePay] [float] NULL,
	[VahatukBhatta] [float] NULL,
	[VahanBhatta] [float] NULL,
	[HRA] [float] NULL,
	[IsHandicapped] [int] NULL,
	[IsActive] [int] NULL,
	[PreparedBy] [int] NULL,
 CONSTRAINT [PK_Designation] PRIMARY KEY CLUSTERED 
(
	[desgid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_CompMst]    Script Date: 15-May-22 09:58:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_CompMst](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](max) NULL,
	[Website] [nvarchar](100) NULL,
	[GST] [nvarchar](50) NULL,
	[PAN] [nvarchar](50) NULL,
	[Mob] [nvarchar](50) NULL,
	[Mob1] [nvarchar](50) NULL,
	[Landline] [nvarchar](50) NULL,
	[IsActive] [int] NULL,
 CONSTRAINT [PK_Tbl_CompMst] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_ReportSummary]    Script Date: 15-May-22 09:58:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_ReportSummary](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LedName] [nvarchar](max) NULL,
	[PayAmt] [float] NULL,
	[RecAmt] [float] NULL,
	[IncomeAmt] [float] NULL,
	[Remarkd] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_ReportSummary] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblDailyDetail]    Script Date: 15-May-22 09:58:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblDailyDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TrandId] [int] NOT NULL,
	[TransDate] [date] NULL,
	[TMode] [nvarchar](50) NULL,
	[LedId] [int] NULL,
	[IId] [int] NULL,
	[IName] [nvarchar](max) NULL,
	[Amt] [float] NULL,
	[Mode] [nvarchar](100) NULL,
	[IsActive] [int] NULL,
	[MktYear] [nvarchar](50) NULL,
	[PrepBy] [int] NULL,
	[PrepDate] [date] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [date] NULL,
 CONSTRAINT [PK_TblDailyDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblDailyHeader]    Script Date: 15-May-22 09:58:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblDailyHeader](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LedId] [int] NULL,
	[LedName] [nvarchar](max) NULL,
	[Date] [date] NULL,
	[NetAmt] [float] NULL,
	[Remark] [nvarchar](max) NULL,
	[TMode] [nvarchar](100) NULL,
	[RecMode] [nvarchar](100) NULL,
	[IsActive] [int] NULL,
	[MktYear] [nvarchar](50) NULL,
	[PrepBy] [int] NULL,
	[PrepDate] [date] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [date] NULL,
 CONSTRAINT [PK_TblDailyHeader] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblItemMst]    Script Date: 15-May-22 09:58:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblItemMst](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IName] [nvarchar](max) NULL,
	[IRate] [float] NULL,
	[Iremark] [nvarchar](max) NULL,
	[IsActive] [int] NULL,
	[PrepBy] [int] NULL,
	[PrepDate] [date] NULL,
	[UpdatedBy] [int] NULL,
	[UpdDate] [date] NULL,
 CONSTRAINT [PK_TblItemMst] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblLedgerMst]    Script Date: 15-May-22 09:58:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblLedgerMst](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LedName] [nvarchar](500) NULL,
	[SanDate] [date] NULL,
	[SanNo] [nvarchar](50) NULL,
	[SanBy] [nvarchar](max) NULL,
	[SanTender] [nvarchar](200) NULL,
	[StartDate] [date] NULL,
	[TotCost] [float] NULL,
	[IsActive] [int] NULL,
	[PrepBy] [int] NULL,
	[PrepDate] [date] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [date] NULL,
 CONSTRAINT [PK_TblLedgerMst] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserLogin]    Script Date: 15-May-22 09:58:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLogin](
	[LoginId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](max) NOT NULL,
	[EmpName] [nvarchar](50) NOT NULL,
	[DeptId] [int] NOT NULL,
	[ActDeptName] [int] NOT NULL,
	[DesgID] [int] NULL,
	[HOD] [int] NOT NULL,
	[Location] [int] NULL,
	[E_Mail] [nvarchar](max) NULL,
	[resign] [int] NULL,
	[transfer] [int] NULL,
	[brnchcd] [int] NULL,
 CONSTRAINT [PK_UserLogin] PRIMARY KEY CLUSTERED 
(
	[LoginId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  View [dbo].[ViewSummary]    Script Date: 15-May-22 09:58:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[ViewSummary] as  select distinct t1.LedName, (select SUM(isnull(r1.NetAmt,0))  as PayAmt from TblDailyHeader r1 where r1.TMode = 'Payment' and r1.LedName=t1.LedName) as [Payment], (select SUM(isnull(r1.NetAmt,0))  as PayAmt from TblDailyHeader r1 where r1.TMode = 'Receipt' and r1.LedName=t1.LedName) as [Receipt], (((select SUM(isnull(r1.NetAmt,0))  as PayAmt from TblDailyHeader r1 where r1.TMode = 'Receipt' and r1.LedName=t1.LedName)) - ((select SUM(isnull(r1.NetAmt,0))  as PayAmt from TblDailyHeader r1 where r1.TMode = 'Payment' and r1.LedName=t1.LedName))) as profit  from TblDailyHeader t1
GO
ALTER TABLE [dbo].[UserLogin]  WITH CHECK ADD  CONSTRAINT [FK_UserLogin_ActDeptName] FOREIGN KEY([DeptId])
REFERENCES [dbo].[Department] ([DeptId])
GO
ALTER TABLE [dbo].[UserLogin] CHECK CONSTRAINT [FK_UserLogin_ActDeptName]
GO
ALTER TABLE [dbo].[UserLogin]  WITH CHECK ADD  CONSTRAINT [FK_UserLogin_BranchMaster] FOREIGN KEY([brnchcd])
REFERENCES [dbo].[BranchMaster] ([BranchId])
GO
ALTER TABLE [dbo].[UserLogin] CHECK CONSTRAINT [FK_UserLogin_BranchMaster]
GO
ALTER TABLE [dbo].[UserLogin]  WITH CHECK ADD  CONSTRAINT [FK_UserLogin_Department] FOREIGN KEY([DeptId])
REFERENCES [dbo].[Department] ([DeptId])
GO
ALTER TABLE [dbo].[UserLogin] CHECK CONSTRAINT [FK_UserLogin_Department]
GO
ALTER TABLE [dbo].[UserLogin]  WITH CHECK ADD  CONSTRAINT [FK_UserLogin_Designation] FOREIGN KEY([DesgID])
REFERENCES [dbo].[Designation] ([desgid])
GO
ALTER TABLE [dbo].[UserLogin] CHECK CONSTRAINT [FK_UserLogin_Designation]
GO
USE [master]
GO
ALTER DATABASE [DB_Sargar] SET  READ_WRITE 
GO
