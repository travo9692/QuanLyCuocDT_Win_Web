USE [QLCuocDT]
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateSim]    Script Date: 12/5/2018 3:07:10 PM ******/
DROP PROCEDURE [dbo].[SP_UpdateSim]
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateLoaiCuoc]    Script Date: 12/5/2018 3:07:10 PM ******/
DROP PROCEDURE [dbo].[SP_UpdateLoaiCuoc]
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateKHStatus]    Script Date: 12/5/2018 3:07:10 PM ******/
DROP PROCEDURE [dbo].[SP_UpdateKHStatus]
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateKH]    Script Date: 12/5/2018 3:07:10 PM ******/
DROP PROCEDURE [dbo].[SP_UpdateKH]
GO
/****** Object:  StoredProcedure [dbo].[SP_TimKiemSimBySoSim]    Script Date: 12/5/2018 3:07:10 PM ******/
DROP PROCEDURE [dbo].[SP_TimKiemSimBySoSim]
GO
/****** Object:  StoredProcedure [dbo].[SP_TimKiemSimByMaSim]    Script Date: 12/5/2018 3:07:10 PM ******/
DROP PROCEDURE [dbo].[SP_TimKiemSimByMaSim]
GO
/****** Object:  StoredProcedure [dbo].[SP_TimKiemKHByTen]    Script Date: 12/5/2018 3:07:10 PM ******/
DROP PROCEDURE [dbo].[SP_TimKiemKHByTen]
GO
/****** Object:  StoredProcedure [dbo].[SP_TimKiemKHByMa]    Script Date: 12/5/2018 3:07:10 PM ******/
DROP PROCEDURE [dbo].[SP_TimKiemKHByMa]
GO
/****** Object:  StoredProcedure [dbo].[SP_TimKiemHoaDonDK]    Script Date: 12/5/2018 3:07:10 PM ******/
DROP PROCEDURE [dbo].[SP_TimKiemHoaDonDK]
GO
/****** Object:  StoredProcedure [dbo].[SP_TaoLoaiCuoc]    Script Date: 12/5/2018 3:07:10 PM ******/
DROP PROCEDURE [dbo].[SP_TaoLoaiCuoc]
GO
/****** Object:  StoredProcedure [dbo].[SP_TaoKH]    Script Date: 12/5/2018 3:07:10 PM ******/
DROP PROCEDURE [dbo].[SP_TaoKH]
GO
/****** Object:  StoredProcedure [dbo].[SP_LoadAllKhachHang]    Script Date: 12/5/2018 3:07:10 PM ******/
DROP PROCEDURE [dbo].[SP_LoadAllKhachHang]
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertSim]    Script Date: 12/5/2018 3:07:10 PM ******/
DROP PROCEDURE [dbo].[SP_InsertSim]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetHDTT]    Script Date: 12/5/2018 3:07:10 PM ******/
DROP PROCEDURE [dbo].[SP_GetHDTT]
GO
/****** Object:  StoredProcedure [dbo].[SP_DanhSachSim]    Script Date: 12/5/2018 3:07:10 PM ******/
DROP PROCEDURE [dbo].[SP_DanhSachSim]
GO
/****** Object:  StoredProcedure [dbo].[SP_DanhSachLoaiCuoc]    Script Date: 12/5/2018 3:07:10 PM ******/
DROP PROCEDURE [dbo].[SP_DanhSachLoaiCuoc]
GO
/****** Object:  StoredProcedure [dbo].[SP_DanhSachHDTT]    Script Date: 12/5/2018 3:07:10 PM ******/
DROP PROCEDURE [dbo].[SP_DanhSachHDTT]
GO
/****** Object:  StoredProcedure [dbo].[SP_DanhSachHDTT]    Script Date: 12/5/2018 3:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE  [dbo].[SP_DanhSachHDTT]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	
	SELECT * from HoaDonTinhCuoc

END

GO
/****** Object:  StoredProcedure [dbo].[SP_DanhSachLoaiCuoc]    Script Date: 12/5/2018 3:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE  [dbo].[SP_DanhSachLoaiCuoc]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	
	SELECT * from GiaCuoc

END
GO
/****** Object:  StoredProcedure [dbo].[SP_DanhSachSim]    Script Date: 12/5/2018 3:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE  [dbo].[SP_DanhSachSim]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	
	SELECT * from ThongTinSim

END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetHDTT]    Script Date: 12/5/2018 3:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_GetHDTT]
@MaKH varchar(20)
	-- Add the parameters for the stored procedure here
AS
BEGIN
	Select hdtt.IDSIM, hdtt.NgayTao, hdtt.PhiHangThang, hdtt.ThanhToan, hdtt.TongTien, hdtt.TrangThai 
	from HoaDonTinhCuoc hdtt, ThongTinSim sim, KhachHang kh 
	where kh.MaKH = @MaKH and kh.MaKH = sim.MaKH and sim.IDSIM = hdtt.IDSIM
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertSim]    Script Date: 12/5/2018 3:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE  [dbo].[SP_InsertSim]
@SoSIm varchar(12), 
@MaKH varchar(20),
@NgayDK datetime,
@Status bit
	-- Add the parameters for the stored procedure here
AS
BEGIN
	
	insert into ThongTinSim values (@SoSIm,@MaKH,@NgayDK,@Status)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LoadAllKhachHang]    Script Date: 12/5/2018 3:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE  [dbo].[SP_LoadAllKhachHang]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	
	SELECT * from KhachHang

END
GO
/****** Object:  StoredProcedure [dbo].[SP_TaoKH]    Script Date: 12/5/2018 3:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_TaoKH]
@MaKH varchar(20),
@Ten nvarchar(50),
@NgheNghiep nvarchar(50),
@ChucVu nvarchar(50),
@Cmnd nvarchar(50),
@DiaChi nvarchar(50),
@Status bit
	-- Add the parameters for the stored procedure here
AS
BEGIN
	
	Insert into KhachHang (MaKH, TenKH, NgheNghiep, ChucVu,CMND, DiaChi, TinhTrang )values(@MaKH, @Ten,@NgheNghiep,@ChucVu,@Cmnd,@DiaChi,@Status)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_TaoLoaiCuoc]    Script Date: 12/5/2018 3:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE  [dbo].[SP_TaoLoaiCuoc]
@MaLoaiCuoc varchar(20),
@TGBD time,
@TGKT time,
@Gia decimal
	-- Add the parameters for the stored procedure here
AS
BEGIN
	insert into GiaCuoc values (@MaLoaiCuoc,@TGBD, @TGKT, @Gia)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_TimKiemHoaDonDK]    Script Date: 12/5/2018 3:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_TimKiemHoaDonDK]
@Col nvarchar(50),
@MaKH varchar(20)
	-- Add the parameters for the stored procedure here
AS
BEGIN
	Select hd.MaHDDK, hd.IDSIM, hd.ChiPhiDK 
	from HoaDonDangKy hd, ThongTinSim sim, KhachHang kh 
	where hd.IDSIM = sim.IDSIM and sim.MaKH = kh.MaKH and kh.MaKH = @MaKH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_TimKiemKHByMa]    Script Date: 12/5/2018 3:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_TimKiemKHByMa]
@Text varchar(20)
	-- Add the parameters for the stored procedure here
AS
BEGIN
	
	SELECT * from KhachHang where MaKH like @Text

END
GO
/****** Object:  StoredProcedure [dbo].[SP_TimKiemKHByTen]    Script Date: 12/5/2018 3:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE  [dbo].[SP_TimKiemKHByTen]
@Text nvarchar(50)
	-- Add the parameters for the stored procedure here
AS
BEGIN
	
	SELECT * from KhachHang where TenKH like @Text

END
GO
/****** Object:  StoredProcedure [dbo].[SP_TimKiemSimByMaSim]    Script Date: 12/5/2018 3:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE  [dbo].[SP_TimKiemSimByMaSim]
@Text int
	-- Add the parameters for the stored procedure here
AS
BEGIN
	SELECT * from ThongTinSim where IDSIM = @Text

END

GO
/****** Object:  StoredProcedure [dbo].[SP_TimKiemSimBySoSim]    Script Date: 12/5/2018 3:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE  [dbo].[SP_TimKiemSimBySoSim]
@Text varchar(12)
	-- Add the parameters for the stored procedure here
AS
BEGIN
	SELECT * from ThongTinSim where SoDienThoai like @Text

END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateKH]    Script Date: 12/5/2018 3:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_UpdateKH]
@Id varchar(20),
@Ten nvarchar(50),
@NgheNghiep nvarchar(50),
@ChucVu nvarchar(50),
@Cmnd nvarchar(50),
@DiaChi nvarchar(50),
@Status bit
	-- Add the parameters for the stored procedure here
AS
BEGIN
	
	update KhachHang set TenKH=@Ten,NgheNghiep=@NgheNghiep,ChucVu=@ChucVu,CMND=@Cmnd, DiaChi=@DiaChi, TinhTrang=@Status
	where MaKH = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateKHStatus]    Script Date: 12/5/2018 3:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE  [dbo].[SP_UpdateKHStatus]
@MaKH int, 
@Status bit
	-- Add the parameters for the stored procedure here
AS
BEGIN
	
	update KhachHang set TinhTrang=@Status
	where MaKH = @MaKH
END

GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateLoaiCuoc]    Script Date: 12/5/2018 3:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE  [dbo].[SP_UpdateLoaiCuoc]
@MaLoaiCuoc varchar(20),
@TGBD time,
@TGKT time,
@Gia decimal
	-- Add the parameters for the stored procedure here
AS
BEGIN
	Update GiaCuoc set TGBD = @TGBD, TGKT = @TGKT, GiaCuoc = @Gia
	where MaGiaCuoc = @MaLoaiCuoc

END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateSim]    Script Date: 12/5/2018 3:07:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE  [dbo].[SP_UpdateSim]
@MaSim int,
@SoSim varchar(12),
@MaKH varchar(20),
@NgayDK datetime,
@Status bit

	-- Add the parameters for the stored procedure here
AS
BEGIN
	update ThongTinSim set SoDienThoai=@SoSim,MaKH=@MaKH,NgayDK=@NgayDK,TinhTrang=@Status where IDSIM = @MaSim

END
GO
