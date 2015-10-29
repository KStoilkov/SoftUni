CREATE PROC usp_withdrawMoney(@accountId INT, @money MONEY)
AS
	UPDATE Accounts
	SET Balance = Balance - @money
	WHERE Id = @accountId
GO

EXEC usp_withdrawMoney
	@accountId = 3,
	@money = 250
GO

CREATE PROC usp_depositMoney(@accountId INT, @money MONEY)
AS
	UPDATE Accounts
	SET Balance = Balance + @money
	WHERE id = @accountId
GO

EXEC usp_depositMoney
	@accountId = 2,
	@money = 350
GO