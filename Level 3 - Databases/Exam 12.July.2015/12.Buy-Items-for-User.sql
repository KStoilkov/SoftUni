CREATE PROC usp_BuyItem(@ItemName NVARCHAR(50), @Username NVARCHAR(50), @Gamename NVARCHAR(50))
AS
	INSERT INTO UserGameItems(ItemId, UserGameId)
	VALUES
	(
		(
			SELECT 
				Id 
			From Items 
			WHERE Name = @ItemName
		),
		(
			SELECT 
				ug.Id
			FROM UsersGames ug
			JOIN Users u
				ON u.Id = ug.UserId
			JOIN Games g
				ON g.Id = ug.GameId
			WHERE u.Username = @Username AND
				  g.Name = @Gamename
		)
	)

	UPDATE UsersGames
	SET Cash = Cash - (SELECT Price FROM Items WHERE Name = @ItemName)
	WHERE UserId = (
						SELECT 
							u.Id 
						FROM Users u
						JOIN UsersGames ug
							ON u.Id = ug.UserId
						JOIN Games g
							ON g.Id = ug.GameId
						WHERE Username = @Username AND
							  g.Name = @Gamename
					)

GO

EXEC usp_BuyItem
	@ItemName = 'Blackguard',
	@Username = 'Alex',
	@Gamename = 'Edinburgh'
GO

EXEC usp_BuyItem
	@ItemName = 'Bottomless Potion of Amplification',
	@Username = 'Alex',
	@Gamename = 'Edinburgh'
GO

EXEC usp_BuyItem
	@ItemName = 'Eye of Etlich (Diablo III)',
	@Username = 'Alex',
	@Gamename = 'Edinburgh'
GO

EXEC usp_BuyItem
	@ItemName = 'Gem of Efficacious Toxin',
	@Username = 'Alex',
	@Gamename = 'Edinburgh'
GO

EXEC usp_BuyItem
	@ItemName = 'Golden Gorget of Leoric',
	@Username = 'Alex',
	@Gamename = 'Edinburgh'
GO

EXEC usp_BuyItem
	@ItemName = 'Hellfire Amulet',
	@Username = 'Alex',
	@Gamename = 'Edinburgh'
GO

SELECT 
	u.Username,
	g.Name,
	REPLACE(ug.Cash, ',', '.') AS Cash,
	i.Name AS [Item Name]
FROM Users u
JOIN UsersGames ug
	ON ug.UserId = u.Id
JOIN Games g
	ON ug.GameId = g.Id
JOIN UserGameItems ugi
	ON ugi.UserGameId = ug.Id
JOIN Items i
	ON i.Id = ugi.ItemId
WHERE g.Name = 'Edinburgh'
ORDER BY i.Name

