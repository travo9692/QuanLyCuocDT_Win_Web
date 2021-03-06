USE [QLCuocDT]
GO
ALTER TABLE [dbo].[ThongTinSim] DROP CONSTRAINT [FK__ThongTinS__TinhT__1273C1CD]
GO
ALTER TABLE [dbo].[HoaDonTinhCuoc] DROP CONSTRAINT [FK__HoaDonTin__Trang__182C9B23]
GO
ALTER TABLE [dbo].[HoaDonDangKy] DROP CONSTRAINT [FK__HoaDonDan__IDSIM__15502E78]
GO
ALTER TABLE [dbo].[ChiTietSuDung] DROP CONSTRAINT [FK__ChiTietSu__IDSIM__1B0907CE]
GO
/****** Object:  Table [dbo].[ThongTinSim]    Script Date: 12/5/2018 3:06:23 PM ******/
DROP TABLE [dbo].[ThongTinSim]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/5/2018 3:06:23 PM ******/
DROP TABLE [dbo].[KhachHang]
GO
/****** Object:  Table [dbo].[HoaDonTinhCuoc]    Script Date: 12/5/2018 3:06:23 PM ******/
DROP TABLE [dbo].[HoaDonTinhCuoc]
GO
/****** Object:  Table [dbo].[HoaDonDangKy]    Script Date: 12/5/2018 3:06:23 PM ******/
DROP TABLE [dbo].[HoaDonDangKy]
GO
/****** Object:  Table [dbo].[GiaCuoc]    Script Date: 12/5/2018 3:06:23 PM ******/
DROP TABLE [dbo].[GiaCuoc]
GO
/****** Object:  Table [dbo].[ChiTietSuDung]    Script Date: 12/5/2018 3:06:23 PM ******/
DROP TABLE [dbo].[ChiTietSuDung]
GO
/****** Object:  Table [dbo].[ChiTietSuDung]    Script Date: 12/5/2018 3:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietSuDung](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDSIM] [int] NULL,
	[TGBD] [datetime] NULL,
	[TGKT] [datetime] NULL,
	[SoPhut7h23h] [decimal](19, 3) NULL,
	[SoPhut23h7h] [decimal](19, 3) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GiaCuoc]    Script Date: 12/5/2018 3:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GiaCuoc](
	[MaGiaCuoc] [varchar](20) NOT NULL,
	[TGBD] [time](7) NULL,
	[TGKT] [time](7) NULL,
	[Giacuoc] [decimal](19, 3) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGiaCuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDonDangKy]    Script Date: 12/5/2018 3:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDonDangKy](
	[MaHDDK] [varchar](20) NOT NULL,
	[IDSIM] [int] NULL,
	[ChiPhiDK] [decimal](19, 3) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHDDK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDonTinhCuoc]    Script Date: 12/5/2018 3:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDonTinhCuoc](
	[MaHDTC] [varchar](20) NOT NULL,
	[IDSIM] [int] NULL,
	[PhiHangThang] [decimal](19, 3) NULL,
	[TongTien] [decimal](19, 3) NULL,
	[NgayTao] [datetime] NULL,
	[ThanhToan] [bit] NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHDTC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/5/2018 3:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](20) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[CMND] [varchar](10) NULL,
	[NgheNghiep] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[TinhTrang] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThongTinSim]    Script Date: 12/5/2018 3:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThongTinSim](
	[IDSIM] [int] IDENTITY(0,1) NOT NULL,
	[SoDienThoai] [varchar](12) NULL,
	[MaKH] [varchar](20) NULL,
	[NgayDK] [datetime] NULL,
	[TinhTrang] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDSIM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[ChiTietSuDung]  WITH CHECK ADD FOREIGN KEY([IDSIM])
REFERENCES [dbo].[ThongTinSim] ([IDSIM])
GO
ALTER TABLE [dbo].[HoaDonDangKy]  WITH CHECK ADD FOREIGN KEY([IDSIM])
REFERENCES [dbo].[ThongTinSim] ([IDSIM])
GO
ALTER TABLE [dbo].[HoaDonTinhCuoc]  WITH CHECK ADD FOREIGN KEY([IDSIM])
REFERENCES [dbo].[ThongTinSim] ([IDSIM])
GO
ALTER TABLE [dbo].[ThongTinSim]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
