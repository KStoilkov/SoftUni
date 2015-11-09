CREATE FUNCTION fn_CashInUsersGames (@GameName NVARCHAR(50))
RETURNS MONEY
BEGIN
	DECLARE userCursor CURSOR FOR 
	(
		SELECT ug.Cash, ROW_NUMBER() OVER(ORDER BY ug.Cash) FROM Games g
		JOIN UsersGames ug
			ON ug.GameId = g.Id
		JOIN Users u 
			ON u.Id = ug.UserId
		WHERE g.Name = @GameName
 	)

	OPEN userCursor

	DECLARE @cash MONEY
	DECLARE @row INT
	DECLARE @sum MONEY

	SET @sum = 0

	FETCH NEXT FROM userCursor INTO @cash, @row

	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF @row % 2 = 1
		BEGIN
			SET @sum = @sum + @cash
		END

		FETCH NEXT FROM userCursor INTO @cash, @row
	END

	RETURN @sum
END
GO

CREATE TABLE GamesCash
(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	Cash MONEY NOT NULL
)

INSERT INTO GamesCash (Cash)
VALUES(dbo.fn_CashInUsersGames('Bali'))

INSERT INTO GamesCash (Cash)
VALUES(dbo.fn_CashInUsersGames('Lily Stargazer'))

INSERT INTO GamesCash (Cash)
VALUES(dbo.fn_CashInUsersGames('Love in a mist'))

INSERT INTO GamesCash (Cash)
VALUES(dbo.fn_CashInUsersGames('Mimosa'))

INSERT INTO GamesCash (Cash)
VALUES(dbo.fn_CashInUsersGames('Ming fern'))

SELECT 
	REPLACE(Cash, ',', '.') AS SumCash
FROM GamesCash
ORDER BY Cash ASC

