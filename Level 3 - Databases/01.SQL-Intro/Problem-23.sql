SELECT 
	e.FirstName + ' ' + e.LastName as Employee,
	m.FirstName + ' ' + m.LastName as Manager
FROM Employees e
LEFT OUTER JOIN Employees m
	on e.ManagerID = m.EmployeeID