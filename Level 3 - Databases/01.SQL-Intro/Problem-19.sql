SELECT e.FirstName, e.LastName, a.AddressText FROM Employees e
INNER JOIN Addresses a
ON e.AddressId = a.AddressID