CREATE DATABASE Martinez
USE Martinez;

CREATE TABLE Rafael
(
	Id INT PRIMARY KEY IDENTITY(5,5),
	Lastname VARCHAR(255) NOT NULL CHECK(Lastname != ''),
	Firstname VARCHAR(255) NOT NULL,
	Age INT NOT NULL CHECK(Age > 16),
	Email VARCHAR(255) NOT NULL,
	Username VARCHAR(255) NOT NULL,
	[Password] VARCHAR(255) NOT NULL,
);

DROP TABLE dbo.Rafael;


CREATE OR ALTER PROCEDURE SaveRecord
	@Lastname VARCHAR(255),
	@Firstname VARCHAR(255),
	@Age INT,
	@Email VARCHAR(255),
	@Username VARCHAR(255),
	@Password VARCHAR(255)
	AS
	INSERT INTO Rafael VALUES 
	(
		@Lastname,
		@Firstname,
		@Age,
		@Email,
		@Username,
		@Password
	)

CREATE OR ALTER PROCEDURE UpdateRecord
	@Id INT,
	@Lastname VARCHAR(255),
	@Firstname VARCHAR(255),
	@Age INT,
	@Email VARCHAR(255),
	@Username VARCHAR(255),
	@Password VARCHAR(255)
	AS
	UPDATE Rafael SET Lastname = @Lastname, Firstname = @Firstname, Age = @Age, Email = @Email, Username = @Username, Password = @Password WHERE Id = @Id

CREATE OR ALTER PROCEDURE RemoveRecord
	@Id INT
	AS
	DELETE FROM Rafael WHERE Id = @Id;

CREATE OR ALTER PROCEDURE FetchAllRecord
	AS
	SELECT * FROM Rafael;

CREATE OR ALTER PROCEDURE FindRecord
	@Key VARCHAR(255)
	AS
	SELECT * FROM Rafael WHERE Id LIKE @Key + '%' 
	OR Firstname LIKE @Key + '%' 
	OR Lastname LIKE @Key + '%' 
	OR Age LIKE @Key + '%' 
	OR Email LIKE @Key + '%' 
	OR Username LIKE @Key + '%'
	OR Password LIKE @Key + '%'