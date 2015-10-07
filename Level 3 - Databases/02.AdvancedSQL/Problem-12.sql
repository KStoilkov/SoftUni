SELECT 
	DISTINCT e.FirstName + ' ' + e.LastName AS Employee, 
	CASE WHEN e.ManagerID IS NULL THEN 'No Manager'
	ELSE m.FirstName + ' ' + m.LastName
	END AS Manager
FROM Employees e
JOIN Employees m
	ON e.ManagerID = m.EmployeeID OR e.ManagerID IS NULL
