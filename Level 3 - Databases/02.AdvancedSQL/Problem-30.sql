INSERT INTO WorkHours(EmployeeID, Date, Task, Hours)
VALUES(27, '12-10-15', 'Something', 12.5)

INSERT INTO WorkHours(EmployeeID, Date, Task, Hours)
VALUES(35, '06-02-10', 'Something', 12.5)

INSERT INTO WorkHours(EmployeeID, Date, Task, Hours)
VALUES(2, '10-11-09', 'Something', 12.5)

UPDATE WorkHours
SET Task = 'Another thing'
WHERE EmployeeID = 27

UPDATE WorkHours
SET Task = 'Nothing', Hours = 22
WHERE EmployeeID = 2

DELETE FROM WorkHours
WHERE EmployeeID = 2


