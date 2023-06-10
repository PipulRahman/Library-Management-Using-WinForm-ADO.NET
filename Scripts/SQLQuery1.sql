USE Libarary
GO
CREATE TABLE Book
(
	id INT PRIMARY KEY IDENTITY,
	name VARCHAR(50) NOT NULL,
	Price INT NOT NULL
)
GO
CREATE TABLE Publisher
(
	id INT PRIMARY KEY IDENTITY,
	name VARCHAR(50) NOT NULL
)
GO
CREATE TABLE Stock
(
	BookId INT,
	PublisherId INT,
	Stock INT,
	PRIMARY KEY(BookId,PublisherId) 
)
GO
CREATE TABLE writters
(
	writterId INT PRIMARY KEY IDENTITY,
	writterName NVARCHAR(50) NOT NULL,
	writterContact NVARCHAR(20) NOT NULL,
	writterEmail NVARCHAR(30) NOT NULL,
	picture VARBINARY(MAX) NULL,
	PublisherId INT REFERENCES Publisher(id)
)
GO
SELECT id,name FROM Publisher
GO
SELECT name FROM Book
GO
INSERT INTO Book(name,Price) VALUES('The 4-Hour Work Week',5)
SELECT @@IDENTITY 
GO
SELECT * FROM Stock
GO
SELECT * FRom writters
GO
INSERT INTO writters(writterName,writterContact,writterEmail,picture,PublisherId) VALUES('name','contact','email','picture','PublisherId')
GO
SELECT w.writterId,w.writterName,w.writterContact,w.writterEmail,w.picture,p.name FROM writters w INNER JOIN Publisher p ON w.PublisherId=p.id
GO

