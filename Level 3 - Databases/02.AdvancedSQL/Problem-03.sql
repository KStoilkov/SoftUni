SELECT 
	e.FirstName + ' ' + e.MiddleName + ' ' + e.LastName AS [Full Name],
	e.Salary,
	d.Name AS Department
FROM Employees e
INNER JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE Salary IN
	(SELECT MIN(Salary) 
	FROM Employees
	GROUP BY DepartmentID)