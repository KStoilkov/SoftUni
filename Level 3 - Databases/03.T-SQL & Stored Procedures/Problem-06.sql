CREATE TABLE Logs
(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	AccountId INT NOT NULL,
	OldSum MONEY NOT NULL,
	NewSum MONEY NOT NULL
)
GO

CREATE TRIGGER tr_SaveLogs
ON Accounts
FOR UPDATE
AS
	INSERT INTO Logs(AccountId, OldSum, NewSum)
	SELECT
		d.Id, d.Balance, i.Balance
	FROM deleted d, inserted i
GO

EXEC usp_depositMoney
	@accountId = 1,
	@money = 3500
GO