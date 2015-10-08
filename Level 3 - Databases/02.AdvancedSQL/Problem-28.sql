SELECT
	t.Name AS Town,
	COUNT(*) AS [Number of managers]
FROM Employees e
JOIN Addresses a
	ON e.AddressID = a.AddressID
JOIN Towns t
	ON a.TownID = t.TownID
WHERE e.EmployeeID in (SELECT m.ManagerID FROM Employees m)
GROUP BY t.Name