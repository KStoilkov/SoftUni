SELECT 
	i.Name AS Item,
	REPLACE(i.Price, ',', '.') AS Price,
	i.MinLevel,
	gt.Name AS [Forbidden Game Type]
FROM GameTypes gt
JOIN GameTypeForbiddenItems gtfi
	ON gt.Id = gtfi.GameTypeId
FULL JOIN Items i
	ON i.Id = gtfi.ItemId
ORDER BY [Forbidden Game Type] DESC, Item
