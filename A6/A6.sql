create database ProductInventory
use ProductInventory
create table Products
(
	ProductId int primary key,
	ProductName nvarchar(50),
	Price decimal(10,2),
	Quantity int,
	MfDate datetime,
	ExpDate datetime
)
--drop table Products





