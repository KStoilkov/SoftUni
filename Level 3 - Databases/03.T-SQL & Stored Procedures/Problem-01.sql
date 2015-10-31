CREATE TABLE Persons
(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	FirstName NVARCHAR(20) NOT NULL,
	LastName NVARCHAR(20) NOT NULL,
	SSN NVARCHAR(50) NOT NULL UNIQUE
)
GO

CREATE TABLE Accounts
(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	PersonId INT NOT NULL,
	CONSTRAINT fk_PersonId FOREIGN KEY (PersonId) REFERENCES Persons(Id),
	Balance MONEY
)
GO

INSERT INTO Persons VALUES ('Toshko', 'Toshkov', '155-555-555')
INSERT INTO Persons VALUES ('Goshko', 'Goshkov', '255-555-555')
INSERT INTO Persons VALUES ('Petko', 'Petkov', '355-555-555')

INSERT INTO Accounts VALUES (1, 2)
INSERT INTO Accounts VALUES (2, 300)
INSERT INTO Accounts VALUES (3, 5000)

GO

CREATE PROC usp_FullNameOfPersons
AS
	SELECT FirstName + ' ' + LastName AS FullName FROM Persons
GO

EXEC usp_FullNameOfPersons
GO