SELECT 
	FirstName + ' ' + LastName AS Employee,
	Salary FROM Employees
WHERE Salary <= (SELECT MIN(Salary) * 0.10 + MIN(Salary) FROM Employees)
ORDER BY Salary DESC