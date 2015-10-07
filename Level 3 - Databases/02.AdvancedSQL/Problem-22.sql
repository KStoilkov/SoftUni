INSERT INTO Users (Username, Password, FullName)
SELECT
    LOWER(LEFT(FirstName, 3) + LastName) AS Username,
	LOWER(LEFT(FirstName, 3) + LastName + '12345') AS Password,
	FirstName + ' ' + LastName AS FullName
FROM Employees