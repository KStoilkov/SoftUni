CREATE TABLE WorkHoursLogs
(
	Id INT IDENTITY PRIMARY KEY NOT NULL,
	OldEmployeeId INT NULL,
	OldDate DATE NULL,
	OldTask NVARCHAR(30) NULL,
	OldHours FLOAT NULL,
	OldComment NVARCHAR(MAX),
	NewEmployeeId INT NULL,
	NewDate DATE NULL,
	NewTask NVARCHAR(30) NULL,
	NewHours FLOAT NULL,
	NewComments NVARCHAR(MAX),
	Command NCHAR(10) NOT NULL
)
GO

CREATE TRIGGER TR_WorkHoursInsert ON WorkHours
FOR INSERT
AS
	INSERT INTO WorkHoursLogs(NewEmployeeId, NewDate, NewTask, NewHours, NewComments, Command)
	SELECT 
		i.EmployeeID, i.Date, i.Task, i.Hours, i.Comments, 
		'INSERT' 
	FROM inserted i
GO

CREATE TRIGGER TR_WorkHoursUpdate ON WorkHours
FOR UPDATE
AS
	INSERT INTO WorkHoursLogs(OldEmployeeId, OldDate, OldTask, OldHours, OldComments, 
					NewEmployeeId, NewDate, NewTask, NewHours, NewComments, Command)
	SELECT
		d.EmployeeID, d.Date, d.Task, d.Hours, d.Comments,
		i.EmployeeID, i.Date, i.Task, i.Hours, i.Comments,
		'UPDATE'
	FROM deleted d, inserted i
GO

CREATE TRIGGER TR_WorkHoursDelete ON WorkHours
FOR DELETE
AS
	INSERT INTO WorkHoursLogs(OldEmployeeId, OldDate, OldTask, OldHours, OldComments, Command)
	SELECT
		d.EmployeeID, d.Date, d.Task, d.Hours, d.Comments,
		'DELETE'
	FROM deleted d
GO
