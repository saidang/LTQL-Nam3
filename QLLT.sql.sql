USE [master]
GO
/****** Object:  Database [QLLT]    Script Date: 05/11/2018 23:05:46 ******/
CREATE DATABASE [QLLT] ON  PRIMARY 
( NAME = N'QLLT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\QLLT.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLLT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\QLLT_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLLT] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLLT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLLT] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QLLT] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QLLT] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QLLT] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QLLT] SET ARITHABORT OFF
GO
ALTER DATABASE [QLLT] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [QLLT] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QLLT] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QLLT] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QLLT] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QLLT] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QLLT] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QLLT] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QLLT] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QLLT] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QLLT] SET  DISABLE_BROKER
GO
ALTER DATABASE [QLLT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QLLT] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QLLT] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QLLT] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QLLT] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QLLT] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QLLT] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QLLT] SET  READ_WRITE
GO
ALTER DATABASE [QLLT] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QLLT] SET  MULTI_USER
GO
ALTER DATABASE [QLLT] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QLLT] SET DB_CHAINING OFF
GO
USE [QLLT]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 05/11/2018 23:05:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[manv] [nvarchar](10) NOT NULL,
	[tennv] [nvarchar](50) NULL,
	[chucvu] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](5) NULL,
	[diachi] [nvarchar](50) NULL,
	[dienthoai] [nvarchar](20) NULL,
	[ngaysinh] [datetime] NULL,
 CONSTRAINT [PK_nhanvien1] PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[nhanvien] ([manv], [tennv], [chucvu], [gioitinh], [diachi], [dienthoai], [ngaysinh]) VALUES (N'nv01', N'lan', N'truong phong', N'Nữ', N'chau doc', N'0123456789', CAST(0x0000A88200000000 AS DateTime))
INSERT [dbo].[nhanvien] ([manv], [tennv], [chucvu], [gioitinh], [diachi], [dienthoai], [ngaysinh]) VALUES (N'nv03', N'ngoc', N'kế toán', N'Nữ', N'An Phú', N'0123456789', CAST(0x0000A88200000000 AS DateTime))
INSERT [dbo].[nhanvien] ([manv], [tennv], [chucvu], [gioitinh], [diachi], [dienthoai], [ngaysinh]) VALUES (N'nv04', N'thoa', N'Trợ Lý', N'Nữ', N'Hà Nội', N'0123456789', CAST(0x0000A88200000000 AS DateTime))
/****** Object:  Table [dbo].[nhacungcap]    Script Date: 05/11/2018 23:05:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhacungcap](
	[mancc] [nvarchar](10) NOT NULL,
	[tenncc] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[dienthoai] [nvarchar](15) NULL,
	[ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_nhacungcap] PRIMARY KEY CLUSTERED 
(
	[mancc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[nhacungcap] ([mancc], [tenncc], [diachi], [dienthoai], [ghichu]) VALUES (N'TS01', N'CTLuong Thuc Thoại Sơn', N'Châu Phú', N'0926789456', N'ngưng')
/****** Object:  Table [dbo].[nguoidung]    Script Date: 05/11/2018 23:05:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nguoidung](
	[ten] [nvarchar](30) NOT NULL,
	[matkhau] [varchar](50) NULL,
	[quyen] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ten] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[nguoidung] ([ten], [matkhau], [quyen]) VALUES (N'nhanvien', N'a906449d5769fa7361d7ecc6aa3f6d28', 2)
INSERT [dbo].[nguoidung] ([ten], [matkhau], [quyen]) VALUES (N'quantri', N'e99a18c428cb38d5f260853678922e03', 1)
/****** Object:  Table [dbo].[khachhang]    Script Date: 05/11/2018 23:05:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachhang](
	[makh] [nvarchar](10) NOT NULL,
	[tenkh] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[dienthoai] [nvarchar](15) NULL,
 CONSTRAINT [PK_khachhang] PRIMARY KEY CLUSTERED 
(
	[makh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[khachhang] ([makh], [tenkh], [diachi], [dienthoai]) VALUES (N'KH02', N'Trần Thị Bích Ngọc', N'Long Xuyên ', N'0911439170')
INSERT [dbo].[khachhang] ([makh], [tenkh], [diachi], [dienthoai]) VALUES (N'KH03', N'Sai', N'Long Xuyên ', N'0911439170')
INSERT [dbo].[khachhang] ([makh], [tenkh], [diachi], [dienthoai]) VALUES (N'KH04', N'Ngoc', N'Long Xuyên ', N'0911439171')
/****** Object:  Table [dbo].[hoadonban]    Script Date: 05/11/2018 23:05:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadonban](
	[mahd] [nvarchar](10) NOT NULL,
	[manv] [nvarchar](10) NULL,
	[ngayban] [datetime] NULL,
	[makh] [nvarchar](10) NULL,
	[soluong] [int] NULL,
	[tongtien] [float] NULL,
 CONSTRAINT [PK_hoadonban] PRIMARY KEY CLUSTERED 
(
	[mahd] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[hoadonban] ([mahd], [manv], [ngayban], [makh], [soluong], [tongtien]) VALUES (N'HD002', N'nv03', CAST(0x0000A7C900000000 AS DateTime), N'KH02', 13, 6000)
INSERT [dbo].[hoadonban] ([mahd], [manv], [ngayban], [makh], [soluong], [tongtien]) VALUES (N'HD005', N'nv01', CAST(0x0000A7C900000000 AS DateTime), N'KH03', 12, 5000000)
/****** Object:  Table [dbo].[hdnhang]    Script Date: 05/11/2018 23:05:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hdnhang](
	[shhd] [nvarchar](10) NOT NULL,
	[mancc] [nvarchar](10) NULL,
	[manv] [nvarchar](10) NULL,
	[sotien] [float] NULL,
	[datra] [nvarchar](20) NULL,
	[conno] [nvarchar](20) NULL,
 CONSTRAINT [PK_hdnhang] PRIMARY KEY CLUSTERED 
(
	[shhd] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[hdnhang] ([shhd], [mancc], [manv], [sotien], [datra], [conno]) VALUES (N'sh01', N'TS01', N'NV01', 100000, N'30000', N'7000')
INSERT [dbo].[hdnhang] ([shhd], [mancc], [manv], [sotien], [datra], [conno]) VALUES (N'sh02', N'TS01', N'nv04', 100000, N'30000', N'7000')
/****** Object:  Table [dbo].[hang]    Script Date: 05/11/2018 23:05:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hang](
	[mah] [nvarchar](10) NOT NULL,
	[tenh] [nvarchar](50) NULL,
	[mancc] [nvarchar](10) NULL,
	[soluong] [int] NULL,
	[dongianhap] [float] NULL,
	[dongiaban] [float] NULL,
 CONSTRAINT [PK_hang] PRIMARY KEY CLUSTERED 
(
	[mah] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[hang] ([mah], [tenh], [mancc], [soluong], [dongianhap], [dongiaban]) VALUES (N'G04', N'Gạo thơm', N'TS01', 12, 6.8, 7000)
/****** Object:  Table [dbo].[cthd]    Script Date: 05/11/2018 23:05:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cthd](
	[mahd] [nvarchar](10) NOT NULL,
	[mah] [nvarchar](10) NOT NULL,
	[soluong] [int] NULL,
	[dongia] [float] NULL,
	[giamgia] [nvarchar](50) NULL,
 CONSTRAINT [PK_cthd] PRIMARY KEY CLUSTERED 
(
	[mahd] ASC,
	[mah] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[cthd] ([mahd], [mah], [soluong], [dongia], [giamgia]) VALUES (N'HD002', N'G04', 5, 50000, N'60000')
/****** Object:  ForeignKey [FK_hoadonban_khachhang]    Script Date: 05/11/2018 23:05:47 ******/
ALTER TABLE [dbo].[hoadonban]  WITH CHECK ADD  CONSTRAINT [FK_hoadonban_khachhang] FOREIGN KEY([makh])
REFERENCES [dbo].[khachhang] ([makh])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[hoadonban] CHECK CONSTRAINT [FK_hoadonban_khachhang]
GO
/****** Object:  ForeignKey [FK_hoadonban_nhanvien]    Script Date: 05/11/2018 23:05:47 ******/
ALTER TABLE [dbo].[hoadonban]  WITH CHECK ADD  CONSTRAINT [FK_hoadonban_nhanvien] FOREIGN KEY([manv])
REFERENCES [dbo].[nhanvien] ([manv])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[hoadonban] CHECK CONSTRAINT [FK_hoadonban_nhanvien]
GO
/****** Object:  ForeignKey [FK_hdnhang_nhacungcap]    Script Date: 05/11/2018 23:05:47 ******/
ALTER TABLE [dbo].[hdnhang]  WITH CHECK ADD  CONSTRAINT [FK_hdnhang_nhacungcap] FOREIGN KEY([mancc])
REFERENCES [dbo].[nhacungcap] ([mancc])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[hdnhang] CHECK CONSTRAINT [FK_hdnhang_nhacungcap]
GO
/****** Object:  ForeignKey [FK_hdnhang_nhanvien]    Script Date: 05/11/2018 23:05:47 ******/
ALTER TABLE [dbo].[hdnhang]  WITH CHECK ADD  CONSTRAINT [FK_hdnhang_nhanvien] FOREIGN KEY([manv])
REFERENCES [dbo].[nhanvien] ([manv])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[hdnhang] CHECK CONSTRAINT [FK_hdnhang_nhanvien]
GO
/****** Object:  ForeignKey [FK_hang_nhacungcap]    Script Date: 05/11/2018 23:05:47 ******/
ALTER TABLE [dbo].[hang]  WITH CHECK ADD  CONSTRAINT [FK_hang_nhacungcap] FOREIGN KEY([mancc])
REFERENCES [dbo].[nhacungcap] ([mancc])
GO
ALTER TABLE [dbo].[hang] CHECK CONSTRAINT [FK_hang_nhacungcap]
GO
/****** Object:  ForeignKey [FK_cthd_hang]    Script Date: 05/11/2018 23:05:47 ******/
ALTER TABLE [dbo].[cthd]  WITH CHECK ADD  CONSTRAINT [FK_cthd_hang] FOREIGN KEY([mah])
REFERENCES [dbo].[hang] ([mah])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[cthd] CHECK CONSTRAINT [FK_cthd_hang]
GO
/****** Object:  ForeignKey [FK_cthd_hoadonban]    Script Date: 05/11/2018 23:05:47 ******/
ALTER TABLE [dbo].[cthd]  WITH CHECK ADD  CONSTRAINT [FK_cthd_hoadonban] FOREIGN KEY([mahd])
REFERENCES [dbo].[hoadonban] ([mahd])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[cthd] CHECK CONSTRAINT [FK_cthd_hoadonban]
GO
