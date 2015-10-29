CREATE FUNCTION dbo.CalculateNewSum(@sum INT, @yearlyRate INT, @months INT)
RETURNS INT
AS
	BEGIN
		DECLARE @monthlyInterestRate MONEY
		SET @monthlyInterestRate = @yearlyRate / 12
		RETURN @sum * (1 + @months * @monthlyInterestRate / 100)
	END;
GO

SELECT 
	FirstName + ' ' + LastName AS FullName,
	dbo.CalculateNewSum(a.Balance, 30, 2) AS CalculatedSum
FROM Persons p
JOIN Accounts a
	ON a.PersonId = p.Id