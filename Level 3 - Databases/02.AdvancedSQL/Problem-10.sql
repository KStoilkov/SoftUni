SELECT
	t.Name AS Town,
	d.Name AS Department,
	COUNT(*) 
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
JOIN Addresses a
	ON e.AddressID = a.AddressID
JOIN Towns t
	ON t.TownID = a.TownID
GROUP BY t.Name, d.Name

	
	