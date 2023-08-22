create database Ass_8
use Ass_8
create table Employee
(
	EmpId int primary key,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	BirthDate date,
	Salary decimal(10,2)
)

create table Products
(
	ProdId int primary key,
	ProdName nvarchar(50),
	Describe nvarchar(50),
	Price money,
	ReleaseDate datetime
)

create table Orders
(
	OrderId int primary key,
	OrderDate datetime,
	Quantity int,
	Discount float,
	isShipped bit
)
INSERT INTO Employee (EmpId, FirstName, LastName, BirthDate, Salary)
VALUES
    (1, 'John', 'Doe', '1990-01-15', 50000.00),
    (2, 'Jane', 'Smith', '1985-06-20', 60000.00),
    (3, 'Michael', 'Johnson', '1993-03-10', 55000.00)
INSERT INTO Products (ProdId, ProdName, Describe, Price, ReleaseDate)
VALUES
    (101, 'Widget', 'A small widget', 19.99, '2023-01-10 '),
    (102, 'Gizmo', 'A fancy gizmo', 49.99, '2022-08-15 '),
    (103, 'Doodad', 'A useful doodad', 9.99, '2023-05-05 ')
INSERT INTO Orders (OrderId, OrderDate, Quantity, Discount, IsShipped)
VALUES
    (1001, '2023-03-20 ', 5, 0.1, 1),
    (1002, '2023-06-05 ', 3, 0.05, 0),
    (1003, '2023-07-18 ', 10, 0.2, 0)
select * from Employee
select * from Products
select * from Orders