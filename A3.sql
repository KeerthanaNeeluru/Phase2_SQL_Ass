create database Ass_3
use Ass_3

--part 1


create table CompanyInfo
(
	Cid int primary key ,
	CName nvarchar(50) not null unique
)

create table ProductInfo
(
	Pid int primary key,
	PName nvarchar(50) not null,
	PPrice float,
	PMDate Date,
	Cid int foreign key references CompanyInfo
)

insert into CompanyInfo values(1,'Samsung'),
								(2,'HP'),
								(3,'Apple'),
								(4,'Dell'),
								(5,'Toshiba'),
								(6,'Redmi')

select * from CompanyInfo

insert into ProductInfo values (101,'Laptop',55000.90,'12/12/2023',1),
								(102,'Laptop',35000.90,'12/12/2012',2),
								(103,'Mobile',15000.90,'12/03/2012',2),
								(104,'Laptop',135000.90,'12/12/2012',3),
								(105,'Mobile',65000.90,'12/12/2012',3),
								(106,'Laptop',35000.90,'12/12/2012',5),
								(107,'Mobile',35000.90,'12/01/2012',5),
								(108,'Earpod',1000.90,'12/12/2022',3),
								(109,'Laptop',85000.90,'12/12/2021',6),
								(110,'Mobile',55000.70,'12/12/2020',1)

select * from ProductInfo
--company names and their product details
select CName,PName from CompanyInfo c  join ProductInfo p on p.Cid=c.Cid
--Product name and their respective company name
select PName,CName from ProductInfo p  join CompanyInfo c on p.Cid=c.Cid 
--all possible combinations
select CName,PName from CompanyInfo c cross join ProductInfo p 



--part 2


create table Products
( 
	Pid int primary key,
	PQ int,
	PPrice float,
	Discount int
)

insert into Products values (1,1,50000.50,15),
							(2,2,120000.60,20),
							(3,2,1000,10)

select  * from Products

create function DiscountedValue(

@price float,
@discount float
)
returns float
as
begin

return (@price-(@price*(@discount/100))  )
end
drop function  dbo.DiscountedValue
select Pid,PPrice,Discount,dbo.DiscountedValue(PPrice,Discount)as Price_After_Discount  from Products
