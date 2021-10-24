--create database dbQuanLyChiTieu

use dbQuanLyChiTieu

go

create table tbAccount
(
	account_id int primary key identity,
	username nvarchar(max),
	fullname nvarchar(max),
	pass nvarchar(max),
)

go

create table tbDanhMuc
(
	danhmuc_id int primary key identity,
	danhmuc_name nvarchar(max),
)


go

create table tbHangHoa
(
	hanghoa_id int primary key identity,
	hanghoa_name nvarchar(max),
	danhmuc_id int foreign key references tbDanhMuc(danhmuc_id),
)

go

create table tbChiTieu
(
	chitieu_id int primary key identity,
	chitieu_name nvarchar(max),
	account_id int foreign key references tbAccount(account_id),
	ngaytao date,
	total int,
)

go

create table tbChiTieuChiTiet
(
	chitieuchitiet_id int primary key identity,
	chitieu_id int foreign key references tbChiTieu(chitieu_id),
	hanghoa_id int,
	soluong int,
	thanhtien int,
)