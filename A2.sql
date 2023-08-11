create database Aug_11
use Aug_11

--Publisher table
create table Publisher(
Pid int primary key,
Publisher nvarchar(50) not null unique)
--Category table
create table Category(
Cid int primary key,
Category nvarchar(50) not null unique)
--Author table
create table Author(
Aid int primary key,
Author_name nvarchar(50) not null unique)
Drop table Author
--Book table
create table Book(
Bid int primary key,
BName nvarchar(50) not null,
Bprice int,
Author int foreign key references Author,
Publisher int foreign key references Publisher,
Category int foreign key references Category)
drop table Book
insert into Publisher values (1,'Penguin'),(2,'HarperCollins India'),(3,'Scholastic Press')
insert into Author values(1,'Akshat Guptha'),(2,'Amish Tripati'),(3,'Morgan Housel')
insert into Category values(1,'Scince-Fiction'),(2,' Historical Fiction'),(3,'Fictional')


insert into Book values(1,'The Hiden Hindu part-1',256,1,1,1),
						(2,'War of Lanka part-4',254,2,2,2),
						(3,'The hidden Hindu part-2',350,1,1,1),
						(4,'Moving Target',284,3,3,3),
						(5,'Melhua',223,2,2,2),
						(6,'Return Fire',250,3,3,3)

Select * from Book