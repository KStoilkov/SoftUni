SELECT 
	d.Name AS Department,
	AVG(Salary) AS AvgSalary
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
	GROUP BY d.Name