USE SoftUni
GO

CREATE FUNCTION ufn_checkWord(@string NVARCHAR(MAX), @word NVARCHAR(MAX))
RETURNS INT
BEGIN
	DECLARE @char NVARCHAR(1),
			@index INT,
			@len INT

	SET	@index = 1
	SET @len = LEN(@word)

	WHILE @index <= @len
	BEGIN
		SET @char = SUBSTRING(@word, @index, 1)

		IF CHARINDEX(@char, @string) = 0
		BEGIN
			RETURN 0
		END

		SET @index = @index + 1
	END

	RETURN 1
END
GO

DECLARE empCursor CURSOR FOR
	(
		SELECT
			e.FirstName,
			e.LastName,
			t.Name
		FROM Employees e
		JOIN Addresses a
			ON a.AddressID = e.AddressID
		JOIN Towns t
			ON t.TownID = a.TownID
	)

OPEN empCursor
DECLARE @firstName NVARCHAR(50),
		@lastName NVARCHAR(50),
		@town NVARCHAR(50),
		@string NVARCHAR(50)

FETCH NEXT FROM empCursor INTO @firstName, @lastName, @town

SET @string = 'oistmiahf'

WHILE @@FETCH_STATUS = 0
BEGIN
	FETCH NEXT FROM empCursor INTO @firstName, @lastName, @town

	IF dbo.ufn_checkWord(@string, @firstName) = 1
	BEGIN
		PRINT 'First Name: ' + @firstName
	END

	IF dbo.ufn_checkWord(@string, @lastName) = 1
	BEGIN
		PRINT 'Last Name: ' + @lastName
	END

	IF dbo.ufn_checkWord(@string, @town) = 1
	BEGIN
		PRINT 'Town: ' + @town
	END
END

CLOSE empCursor
DEALLOCATE empCursor
GO