use master
go
create database QLCuocDT
go
use QLCuocDT

drop database QLCuocDT



create table KhachHang
(
	MaKH varchar(20) primary key,
	TenKH nvarchar(50),
	CMND varchar(10),
	NgheNghiep nvarchar(50),
	ChucVu nvarchar(50),
	DiaChi nvarchar(100),
	TinhTrang bit
)


create table ThongTinSim
(
	IDSIM int IDENTITY(0,1) PRIMARY KEY,
	SoDienThoai varchar(12),
	MaKH varchar(20),
	NgayDK datetime,
	TinhTrang bit
	
	foreign key (MaKH) references KhachHang(MaKH)
)




create table HoaDonDangKy
(
	MaHDDK varchar(20) primary key,
	IDSIM int,
	ChiPhiDK decimal(19,3),

	foreign key (IDSIM) references ThongTinSim(IDSIM)
)


create table HoaDonTinhCuoc
(
	MaHDTC varchar(20) primary key,
	IDSIM int,
	PhiHangThang decimal(19,3),
	TongTien decimal(19,3),
	NgayTao datetime,
	ThanhToan bit,
	TrangThai bit
	foreign key (IDSIM) references ThongTinSim(IDSIM)
)



create table ChiTietSuDung
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	IDSIM int,
	TGBD datetime,
	TGKT datetime,
	SoPhut7h23h decimal(19,3),
	SoPhut23h7h decimal(19,3),
	
	
	foreign key (IDSIM) references ThongTinSIM(IDSIM)

)

create table GiaCuoc
(
	MaGiaCuoc varchar(20) primary key,
	
	TGBD time,
	TGKT time,
	Giacuoc decimal(19, 3)

)



insert into KhachHang values('KH001','Minh Hằng','1234567890','Diễn viên','Không','Sài gòn','1')
insert into KhachHang values('KH002','Hồ Ngọc Hà','6543219870','Ca sĩ','Không','Hà nội','1')
insert into KhachHang values('KH003','Hoài Linh','9876543210','Bác sĩ','Không','Huế','1')
insert into KhachHang values('KH004','Thành Lộc','1563249870','Giám đốc','Không','Bình Thuận','1')
insert into KhachHang values('KH005','Trấn Thành','1472583690','Sinh viên','Không','Sóc Trăng','1')
insert into KhachHang values('KH006','Việt Hương','1472583690','Sinh viên','Không','Sóc Trăng','1')
insert into KhachHang values('KH007','Đàm Vĩnh Hưng','1472583690','Sinh viên','Không','Sóc Trăng','1')
insert into KhachHang values('KH008','Mỹ Tâm','1472583690','Y tá','Không','Sóc Trăng','1')

insert into ThongTinSIM values('0123457689','KH001','2018/11/12','1')
insert into ThongTinSIM values('0123456789','KH002','2018/11/12','1')
insert into ThongTinSIM values('0987654321','KH003','2018/11/11','1')
insert into ThongTinSIM values('0123789456','KH004','2018/11/10','1')
insert into ThongTinSIM values('0789123456','KH005','2018/11/09','1')
insert into ThongTinSIM values('0135792468','KH006','2018/11/08','1')
insert into ThongTinSIM values('0122426789','KH007','2018/11/12','1')
insert into ThongTinSIM values('0787674321','KH008','2018/11/11','1')
insert into ThongTinSIM values('0133789356','KH001','2018/11/10','1')
insert into ThongTinSIM values('0781123416','KH002','2018/11/09','1')


insert into HoaDonDangKy values('DK001','0','50000')
insert into HoaDonDangKy values('DK002','1','50000')
insert into HoaDonDangKy values('DK003','2','50000')
insert into HoaDonDangKy values('DK004','3','50000')
insert into HoaDonDangKy values('DK005','4','50000')
insert into HoaDonDangKy values('DK006','5','50000')
insert into HoaDonDangKy values('DK007','6','50000')
insert into HoaDonDangKy values('DK008','7','50000')
insert into HoaDonDangKy values('DK009','8','50000')
insert into HoaDonDangKy values('DK010','9','50000')

insert into GiaCuoc values('GC01','07:00:00','23:00:00','200')
insert into GiaCuoc values('GC02','23:00:00','07:00:00','150')

Create proc Tinhcuoc
@sdt varchar(12),
@Ngaybd datetime,
@ngaykt datetime
as
begin
	select SoDienThoai as 'Số Điện Thoại', 50000+sum(SoPhut7h23h)*200+sum(SoPhut23h7h)*150 as 'Tổng Giá Cước'
	from ChiTietSuDung
	inner join ThongTinSim
	ON ThongTinSim.IDSIM = ChiTietSuDung.IDSIM 
	Where TGBD between @Ngaybd and @ngaykt and TGKT between @Ngaybd and @ngaykt and @sdt = SoDienThoai 
	group by SoDienThoai
end
drop proc Tinhcuoc

--------------------------------------
create proc hienthi
@sdt varchar(12),
@Ngaybd datetime,
@ngaykt datetime
as
begin
	select SoDienThoai as 'Số Điện Thoại', TGBD as 'Bắt Đầu', TGKT as 'Kết Thúc' from ThongTinSim
inner join ChiTietSuDung
ON ThongTinSim.IDSIM = ChiTietSuDung.IDSIM 
Where TGBD between @Ngaybd and @ngaykt and TGKT between @Ngaybd and @ngaykt and @sdt = SoDienThoai 
end