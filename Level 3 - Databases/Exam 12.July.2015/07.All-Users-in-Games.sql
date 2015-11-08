SELECT 
	g.Name AS Game,
	gt.Name AS [Game Type],
	u.Username,
	ug.Level,
	Replace(ug.Cash, ',', '.') AS Cash,
	c.Name AS Character
FROM Users u
JOIN UsersGames ug
	ON ug.UserId = u.Id
JOIN Games g
	ON ug.GameId = g.Id
JOIN GameTypes gt
	ON gt.Id = g.GameTypeId
JOIN Characters c
	ON ug.CharacterId = c.Id
ORDER BY ug.Level DESC, u.Username, g.Name ASC

	