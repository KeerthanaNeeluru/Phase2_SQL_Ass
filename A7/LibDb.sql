create database LibraryDB
use LibraryDB
create table Books
(
	BookId int primary key,
	Title nvarchar(50),
	Author nvarchar(50),
	Genre nvarchar(50),
	Quantity int
)


insert into Books values(1,'The Hidden Hindu Triology','Akshat Gupta','Religious & Spiritual Fiction',3),
						(2,'Moving target','Christina Diaz Gonzalez','Children Stories',2)

select * from Books