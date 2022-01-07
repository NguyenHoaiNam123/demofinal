CREATE DATABASE QuanLyBanHang
GO

USE QuanLyBanHang
GO


CREATE TABLE TaiKhoan
(
	id varchar(10) PRIMARY KEY,
	TenDangNhap varchar(255), 
	Matkhau     varchar(255),   

	HovaTen       nvarchar(255), 
	Sodienthoai   char(12),      
	Diachi        nvarchar(255),
	Vaitro	nvarchar(50)
)
GO


CREATE TABLE PhieuNhapHang
(
	maHang	varchar(5)  PRIMARY KEY,
	tenHang	varchar(255), 
	soLuong	int,   

	giaNhapHang	int, 
	tongTien	float,      
	ngayNhap	datetime
)
GO

CREATE TABLE DatHang
(
	MaDaiLy	varchar(5) PRIMARY KEY,
	TenHang	varchar(255),
	Gia	int,
	soLuong	int,   
 
	tongTien	float,
	HinhThucThanhToan nvarchar(50),
	NgayDat	datetime
)
GO
CREATE TABLE TinhTrangDonHang
(
	SoPhieu        varchar(10)PRIMARY KEY,
	MaDaiLy	varchar(10) ,
	   
	NgayDat    datetime,
	NgayNhanHang   datetime,
	HinhThucThanhToan	nvarchar(50),
	TrangThai      nvarchar(50)				--thanh toán
)

GO
CREATE TABLE ChuyenHang
(
	SoPhieu        varchar(10),
	MaDaiLy    varchar(10),
	NgayDat    datetime,
	NgayNhanHang   datetime,
	TrangThai      nvarchar(50)				--tình trạng đơn hàng
)
GO	

CREATE TABLE HangHoa
(
	maHang	varchar(5),
	   
	TenHang	varchar(255),
	GiaNhap	int,
	GiaBan	int,   
	TonKho  int
)
GO	

--
Insert Into 
   Taikhoan(id,TenDangNhap,MatKhau,HovaTen,Sodienthoai,Diachi,Vaitro) 
      Values ('DL01','daily01','daily123',N'Circle K','0356966352',N'Lê Văn Lương',N'Daily'),
             ('DL02','daily02','daily123',N'Nhà Thuốc lá Hoài Nam','0369852478',N'Nguyễn Huệ',N'Daily'),
             ('DL03','daily03','daily123',N'Bách Hóa Xanh','0145963589',N'Hàm Nghi',N'Daily'),
             ('DL04','daily04','daily123',N'Thuốc Lá Quốc Huy','0358998747',N'Tây Ninh',N'Daily'),
             ('DL05','daily05','daily123',N'Cà phê Why Not','0936698988',N'Tôn Đức Thắng',N'Daily'),
			 ('KT01','ketoan01','ketoan123',N'Kế toán 01','0366698787',N'Tobacco VietNam Company',N'Ketoan'),
             ('KT02','ketoan02','ketoan123',N'Kế toán 02','0366698744',N'Tobacco VietNam Company',N'Ketoan')
GO
DELETE FROM TaiKhoan WHERE id = 'ACC01';
Insert Into
   HangHoa(maHang,TenHang,GiaNhap,GiaBan,TonKho)
      Values ('M01',N'Jet',2000,2500,1000),
             ('M02',N'Khánh Hội',1000,1200,500),
			 ('M03',N'555',2500,3000,5000),
			 ('M04',N'Camel',1500,1800,2000),
			 ('M05',N'Sài Gòn',1400,1800,3000),
			 ('M06',N'Marlboro',1500,2500,8000),
			 ('M07',N'Marula',2500,3000,5000),
			 ('M08',N'Hero',1600,2200,2000),
			 ('M09',N'Craven',1800,2600,2500)
GO

Insert Into
   ChuyenHang(SoPhieu,MaDaiLy,NgayDat,NgayNhanHang,Trangthai)
       Values('HN01','DL02','2020-11-02',NULL,N'Dang xu ly'),('HN02','DL03','2020-01-15',NULL,N'Dang xu ly'),('HN03','DL05','2020-06-05',NULL,N'Dang Xu Ly'),
			 ('HN04','DL01','2020-10-09','2020-12-02',N'Da Xuat Kho'),('HN05','DL04','2020-05-19',NULL,N'Da Tiep Nhan'),('HN06','DL01','2020-11-30',NULL,N'Dang Xu Ly'),
			 ('HN07','DL05','2020-08-29',NULL,N'Dang xu ly'),('HN08','DL02','2020-02-17',NULL,N'Da Tiep Nhan'),('HN09','DL03','2020-09-01','2020-11-25',N'Da Xuat Kho'),
			 ('HN10','DL01','2020-09-03','2020-12-25',N'Da Xuat Kho'),('HN11','DL05','2020-07-18',NULL,N'Dang Xu Ly'),('HN12','DL03','2020-04-08','2020-06-02',N'Da Xuat Kho')

GO

Insert Into
   TinhTrangDonHang(SoPhieu,MaDaiLy,NgayDat,NgayNhanHang,HinhThucThanhToan,TrangThai)
       Values('HN01','DL02','2020-11-02',NULL,N'Momo',N'Dang xu ly'),('HN02','DL03','2020-01-15',NULL,N'Banking',N'Dang xu ly'),('HN03','DL05','2020-06-05',NULL, N'Tien Mat',N'Dang Xu Ly'),
			 ('HN04','DL01','2020-10-09','2020-12-02',N'Tien Mat',N'Da Xuat Kho'),('HN05','DL04','2020-05-19',NULL,N'Momo',N'Da Tiep Nhan'),('HN06','DL01','2020-11-30',NULL, N'Banking',N'Dang Xu Ly'),
			 ('HN07','DL05','2020-08-29',NULL,N'Banking',N'Dang xu ly'),('HN08','DL02','2020-02-17',NULL,N'Momo',N'Da Tiep Nhan'),('HN09','DL03','2020-09-01','2020-11-25',N'Tien Mat',N'Da Xuat Kho'),
			 ('HN10','DL01','2020-09-03','2020-12-25',N'Tien Mat',N'Da Xuat Kho'),('HN11','DL05','2020-07-18',NULL,N'Momo',N'Dang Xu Ly'),('HN12','DL03','2020-04-08','2020-06-02', N'Banking',N'Da Xuat Kho')

GO

