SELECT 
	FirstName + ' ' + LastName AS Employee, 
	Salary 
FROM Employees
WHERE Salary = (SELECT MIN(Salary) FROM Employees)