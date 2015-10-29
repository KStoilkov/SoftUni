CREATE PROC usp_HaveMoreMoney(@amount MONEY)
AS
	SELECT * FROM Persons p
	JOIN Accounts a
		ON p.Id = a.PersonId
	WHERE a.Balance > @amount
GO

EXEC usp_HaveMoreMoney
	@amount = 100
GO