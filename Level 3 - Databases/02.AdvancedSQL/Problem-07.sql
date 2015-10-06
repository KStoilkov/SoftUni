SELECT
	COUNT(*) AS	[Employees with Manager]
FROM Employees
WHERE ManagerID IS NOT NULL