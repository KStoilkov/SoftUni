SELECT 
	COUNT(*) AS [Sales Employees Count]
FROM Employees 
WHERE DepartmentID = 
	(SELECT DepartmentID 
	FROM Departments
	WHERE Name = 'Sales')