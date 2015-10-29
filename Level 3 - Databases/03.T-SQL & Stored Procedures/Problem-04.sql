CREATE PROC usp_OneMonthInterest (@accountId INT, @interestRate INT)
AS
	SELECT
		a.Balance, 
		dbo.CalculateNewSum(a.Balance, @interestRate, 1) AS CalculatedBalance
	FROM Accounts a
	WHERE a.Id = @accountId
GO

EXEC usp_OneMonthInterest
	@accountId = 2,
	@interestRate = 45
GO