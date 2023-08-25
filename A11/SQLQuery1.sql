create database ContentDb
use ContentDb
create table Article
(
	ArticleId int primary key,
	Title nvarchar(50),
	Content nvarchar(50),
	PublishDate datetime
)