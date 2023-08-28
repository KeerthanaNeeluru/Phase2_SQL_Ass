create database ContentDb
use ContentDb
create table Article
(
	ArticleId int primary key,
	Title nvarchar(50),
	Content nvarchar(50),
	PublishDate datetime
)
INSERT INTO Article (ArticleId, Title, Content, PublishDate)
VALUES
    (1, 'Title 1', 'Content 1', '2023-08-25 10:00:00'),
    (2, 'Title 2', 'Content 2', '2023-08-25 11:00:00'),
    (3, 'Title 3', 'Content 3', '2023-08-25 12:00:00'),
    (4, 'Title 4', 'Content 4', '2023-08-25 13:00:00'),
    (5, 'Title 5', 'Content 5', '2023-08-25 14:00:00'),
    (6, 'Title 6', 'Content 6', '2023-08-25 15:00:00'),
    (7, 'Title 7', 'Content 7', '2023-08-25 16:00:00'),
    (8, 'Title 8', 'Content 8', '2023-08-25 17:00:00')