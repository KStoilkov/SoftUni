SELECT 
	AVG(Salary) AS [AvgSalary in Sales Department]
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'