SELECT 
	m.FirstName + ' ' + m.LastName AS [Manager Name],
	COUNT(e.ManagerID) AS [Employees count]
FROM Employees e
JOIN Employees m
	ON m.EmployeeID = e.ManagerID
GROUP BY m.FirstName, m.LastName
HAVING COUNT(e.ManagerID) = 5
