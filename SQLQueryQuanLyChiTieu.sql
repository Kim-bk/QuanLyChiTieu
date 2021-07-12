--create database dbQuanLyChiTieu



use dbQuanLyChiTieu

go

create table tbAccount
(
	account_id int identity primary key,
	account_username nvarchar(max),
	account_password nvarchar(max),
)

go

create table tbDanhMuc
(
	danhmuc_id int primary key identity,
	danhmuc_name nvarchar(max),
)


go

create table tbDienGiai
(
	diengiai_id int primary key identity,
	diengiai_name nvarchar(max),
	danhmuc_id int foreign key references tbDanhMuc(danhmuc_id),
	diengiai_price bigint,
)

go

create table tbChiTieu
(
	chitieu_id int primary key identity,
	account_id int foreign key references tbAccount(account_id),
	created_date date,
	total_cost int,
)

go 

create table tbChiTieuChiTiet
(
	chitieuchitiet_id int identity primary key,
	chitieu_id int foreign key references tbChiTieu(chitieu_id),
	diengiai_id int foreign key references tbDienGiai(diengiai_id),
	price float,
	soluong int,
)

go 

create table tbThongKe
(
	thongke_id int identity primary key,
	thongke_name nvarchar(max),
	chitieuchitiet_id int foreign key references tbChiTieuChiTiet(chitieuchitiet_id),
)