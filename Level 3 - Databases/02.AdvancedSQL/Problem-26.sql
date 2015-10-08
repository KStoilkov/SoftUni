SELECT
	d.Name AS Department,
	e.JobTitle,
	e.FirstName,
	MIN(e.Salary) AS [Min Salary]
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle, e.FirstName