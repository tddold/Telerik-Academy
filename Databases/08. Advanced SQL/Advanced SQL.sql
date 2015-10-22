use TelerikAcademy

--1. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
--Use a nested SELECT statement.

SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary = 
	(SELECT MIN(Salary) FROM Employees)

--2. Write a SQL query to find the names and salaries of the employees that 
--have a salary that is up to 10% higher than the minimal salary 
--for the company.

SELECT e.FirstName, e.LastName, e.Salary
FROM Employees e
WHERE Salary > 
	(SELECT (MIN(Salary) + (MIN(Salary) * 0.1)) FROM Employees)
ORDER BY Salary

--3. Write a SQL query to find the full name, salary and department of the employees 
--that take the minimal salary in their department.
--Use a nested SELECT statement.

SELECT CONCAT(e.FirstName, ' ', e.LastName) AS [Full Name], e.Salary, d.Name AS [DepartmentS Name]
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE Salary = 
	(SELECT MIN(Salary) FROM Employees emp
	WHERE emp.DepartmentID = d.DepartmentID)
ORDER BY Salary

--4. Write a SQL query to find the average salary in the department #1
SELECT AVG(Salary) [Average Salary]
FROM Employees
WHERE DepartmentID = 1

SELECT ROUND(AVG(Salary), 2) AS [Average Salary Rounded]
FROM Employees
WHERE DepartmentID = 1

--5. Write a SQL query to find the average salary in the "Sales" department.

SELECT ROUND(AVG(Salary), 2) AS [Average FROM Sales]
FROM Employees e
WHERE DepartmentID IN
	(SELECT DepartmentID FROM Departments
	WHERE Name = 'Sales')

SELECT ROUND(AVG(Salary), 2) AS [Average FROM Sales]
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
	WHERE d.Name = 'Sales'

--6. Write a SQL query to find the number of employees in the "Sales" department.

SELECT COUNT(*) [Count Employees]
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
	WHERE d.Name = 'Sales'

--7. Write a SQL query to find the number of all employees that have manager

SELECT COUNT(e.ManagerID) MgrCount
FROM Employees e

--8. Write a SQL query to find the number of all employees that have no manager.

SELECT COUNT(*) MgrCount
FROM Employees e
WHERE e.ManagerID  IS NULL

--9. Write a SQL query to find all departments and the average salary for each of them.

SELECT ROUND(AVG(e.Salary), 2) AS [AVERAGE], d.Name
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name
ORDER BY AVG(e.Salary)

--10. Write a SQL query to find the count of all employees in
 --each department and for each town.

SELECT COUNT(e.EmployeeID) AS EmploeeCount, d.Name, t.Name
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
JOIN Addresses a
	ON e.AddressID = d.DepartmentID
JOIN Towns t
	ON a.TownID = t.TownID
GROUP BY d.Name, t.Name
ORDER BY d.Name

--11. Write a SQL query to find all managers that have exactly 
--5 employees. Display their first name and last name.

SELECT  e.EmployeeID AS ManagerId,
		CONCAT(e.FirstName, ' ', e.LastName) AS ManagerName,
		COUNT(e.EmployeeID) as EmploeesCount
FROM Employees e
JOIN Employees emp
	ON e.EmployeeID = emp.ManagerID
GROUP BY e.EmployeeID, e.FirstName, e.LastName
HAVING COUNT(e.EmployeeID) = 5

--12. Write a SQL query to find all employees along with their managers. 
--For employees that do not have manager display the value "(no manager)".

SELECT  CONCAT(e.FirstName, ' ', e.LastName) AS [Employee Name],
		ISNULL(m.FirstName + ' ' + m.LastName, 'No manager') AS [Manager Name]		
	FROM Employees e
	LEFT JOIN Employees m
		ON e.ManagerID = m.EmployeeID

--13. Write a SQL query to find the names of all employees whose last name
 --is exactly 5 characters long. Use the built-in LEN(str) function.

 SELECT CONCAT(e.FirstName, ' ', e.LastName) AS [Name]
 FROM Employees e
 WHERE LEN(e.LastName) = 5

 --14. Write a SQL query to display the current date and time in the following 
 --format "day.month.year hour:minutes:seconds:milliseconds".
	--Search in Google to find how to format dates in SQL Server.

SELECT  FORMAT(GETDATE(), 'dd.MM.yyyy HH:mm:ss:ffff') AS [CURRENTDATE]

--15. Write a SQL statement to create a table Users. Users should have username, 
--password, full name and last login time.
--	* Choose appropriate data types for the table fields. Define a primary key column with a primary	key constraint.
--	* Define the primary key column as identity to facilitate inserting records.
--	* Define unique constraint to avoid repeating usernames.
--	* Define a check constraint to ensure the password is at least 5 characters long.

--CREATE TABLE Users(
--	UserID int IDENTITY,
--	Username nvarchar(100) NOT NULL CHECK (LEN(Username) > 3),
--	Password nvarchar(256) NOT NULL CHECK (LEN(Password) > 5),
--	FullName nvarchar(100) NOT NULL CHECK (LEN(FullName) > 5),
--	LastLoginTime DATETIME ,
--	CONSTRAINT PK_Users PRIMARY KEY(UserID),
--	CONSTRAINT UQ_Username UNIQUE(Username),
--	)
--	GO

--16. Write a SQL statement to create a view that displays the users from the 
--	Users table that have been in the system today.
--	Test if the view works correctly.

--CREATE VIEW [Logged Users Today] AS
--	SELECT Username FROM Users
--	WHERE DATEDIFF(DAY, LastLoginTime, GETDATE()) = 0
--	GO


-- 17. Write a SQL statement to create a table Groups. Groups should have 
-- unique name (use unique constraint).
-- Define primary key and identity column.

--CREATE TABLE Groups (
--	GroupsID int IDENTITY PRIMARY KEY,
--	Name nvarchar(50) NOT NULL UNIQUE
--)
--GO

-- 18. Write a SQL statement to add a column GroupID to the table Users.
-- Fill some data in this new column and as well in the `Groups table.
-- Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.

--ALTER TABLE Users 
--	ADD GroupID int NOT NULL
--GO

--ALTER TABLE Users
--	ADD CONSTRAINT FK_Users_Groups
--		FOREIGN KEY (GroupID)
--		REFERENCES Groups(GroupsID)
--GO

-- 19. Write SQL statements to insert several records in the Users and Groups tables.

--INSERT INTO Groups
--	 VALUES
--		('Facebook'),
--		('Twitter'),
--		('LinkedIn'),
--		('Google+'),
--		('Telerik Academy'),
--		('SoftUni')

--INSERT INTO Users VALUES
-- ('nickname1', 'qwerty1', 'Usernamed1', GETDATE(), 1),
-- ('nickname2', 'qwerty2', 'Usernamed2', GETDATE(), 2),
-- ('nickname3', 'qwerty3', 'Usernamed3', GETDATE(), 3),
-- ('nickname4', 'qwerty4', 'Usernamed4', GETDATE(), 4),
-- ('nickname5', 'qwerty5', 'Usernamed5', GETDATE(), 5),
-- ('nickname6', 'qwerty6', 'Usernamed6', GETDATE(), 6),
-- ('nickname7', 'qwerty7', 'Usernamed7', GETDATE(), 1),
-- ('nickname8', 'qwerty8', 'Usernamed8', GETDATE(), 2),
-- ('nickname9', 'qwerty9', 'Usernamed9', GETDATE(), 3)

-- 20. Write SQL statements to update some of the records in the Users and Groups tables.

--UPDATE Users
--	SET Username = REPLACE(Username, 'nickname', 'NICKNAME')
--	WHERE GroupID > 4

------------------------------------------------------------------------
-- 21. Write SQL statements to delete some of the records from the Users 
-- and Groups tables.
------------------------------------------------------------------------

--DELETE 
--	FROM Users
--	WHERE GroupID > 4

--DELETE
--	FROM Groups
--	WHERE GroupsID IN (5, 6)

------------------------------------------------------------------------
-- 22. Write SQL statements to insert in the Users table the names of all 
-- employees from the Employees table.
--	Combine the first and last names as a full name.
--	For username use the first letter of the first name + the last name 
--	(in lowercase).
--	Use the same for the password, and NULL for last login time
------------------------------------------------------------------------

--CREATE TABLE Users (
--	UserID int IDENTITY NOT NULL PRIMARY KEY,
--	Username nvarchar(50) NOT NULL,
--	Password nvarchar(256) NOT NULL,
--	Fullname nvarchar(50) NOT NULL,
--	LastLoginTime DATETIME
--)
--GO

INSERT INTO Users (Username, Password, FullName,GroupID)
	(SELECT LOWER(CONCAT(LEFT(e.FirstName, 1), e.LastName)),			
			LOWER(CONCAT(LEFT(e.FirstName, 1), e.LastName)),
			CONCAT(e.FirstName, ' ', e.LastName),
			1
	FROM Employees e)
GO
 
------------------------------------------------------------------------
-- 23. Write a SQL statement that changes the password to NULL for all users
-- that have not been in the system since 10.03.2010.
------------------------------------------------------------------------

--UPDATE Users
--	SET LastLoginTime = '2010-3-10 00:00:00'

--UPDATE Users
--	SET Password = NULL
--	WHERE DATEDIFF(day, LastLoginTime, '2015-10-13 03:11:50.637' ) > 0

------------------------------------------------------------------------
-- TASK 24: Write a SQL statement that deletes all users without pass-
-- words (NULL password).
------------------------------------------------------------------------

--DELETE 
--	FROM Users
--	WHERE Password IS NULL

--- 25. Write a SQL query to display the average 
--- employee salary by department and job title.

SELECT FLOOR(AVG(e.Salary)), d.Name, e.JobTitle
FROM Employees e 
JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle
ORDER BY d.Name

--- 26. Write a SQL query to display the minimal employee 
--- salary by department and job title along with the 
--- name of some of the employees that take it.

SELECT FLOOR(MIN(e.Salary)), d.Name, e.JobTitle, MIN(CONCAT(e.FirstName, ' ', e.LastName))
FROM Employees e 
JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle
ORDER BY d.Name

--- 27. Write a SQL query to display the town 
--- where maximal number of employees work.

SELECT TOP 1 t.Name, COUNT(e.EmployeeID) as EmployeesCount
FROM Employees e 
JOIN Addresses a
     ON e.AddressID = a.AddressID
JOIN Towns t
     ON t.TownID = a.TownID
GROUP BY t.Name
ORDER BY EmployeesCount DESC

--- 28. Write a SQL query to display the number of managers from each town.

SELECT t.Name, COUNT(e.EmployeeID) as ManagersCount
FROM Employees e 
JOIN Addresses a
     ON e.AddressID = a.AddressID
JOIN Towns t
     ON t.TownID = a.TownID
GROUP BY t.Name
ORDER BY ManagersCount DESC

--- 29. Write a SQL to create table WorkHours to store work reports 
--- for each employee (employee id, date, task, hours, comments). 
--- Don't forget to define  identity, primary key and appropriate foreign key. 
---
--- Issue few SQL statements to insert, update and delete of some data in the table.
--- Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers.
---
--- For each change keep the old record data, the new record data and the 
--- command (insert / update / delete).

--- TABLE: WorkHours
CREATE TABLE WorkHours (
    WorkReportId int IDENTITY,
    EmployeeId Int NOT NULL,
    OnDate DATETIME NOT NULL,
    Task nvarchar(256) NOT NULL,
    Hours Int NOT NULL,
    Comments nvarchar(256),
    CONSTRAINT PK_Id PRIMARY KEY(WorkReportId),
    CONSTRAINT FK_Employees_WorkHours 
        FOREIGN KEY (EmployeeId)
        REFERENCES Employees(EmployeeId)
) 
GO

--- INSERT
DECLARE @counter int;
SET @counter = 20;
WHILE @counter > 0
BEGIN
    INSERT INTO WorkHours(EmployeeId, OnDate, Task, [Hours])
    VALUES (@counter, GETDATE(), 'TASK: ' + CONVERT(varchar(10), @counter), @counter)
    SET @counter = @counter - 1
END

--- UPDATE
UPDATE WorkHours
SET Comments = 'Work hard or go home!'
WHERE [Hours] > 10

--- DELETE
DELETE FROM WorkHours
WHERE EmployeeId IN (1, 3, 5, 7, 13)

--- TABLE: WorkHoursLogs
CREATE TABLE WorkHoursLogs (
    WorkLogId int,
    EmployeeId Int NOT NULL,
    OnDate DATETIME NOT NULL,
    Task nvarchar(256) NOT NULL,
    Hours Int NOT NULL,
    Comments nvarchar(256),
    [Action] nvarchar(50) NOT NULL,
    CONSTRAINT FK_Employees_WorkHoursLogs
        FOREIGN KEY (EmployeeId)
        REFERENCES Employees(EmployeeId),
    CONSTRAINT [CC_WorkReportsLogs] CHECK ([Action] IN ('Insert', 'Delete', 'DeleteUpdate', 'InsertUpdate'))
) 
GO

--- TRIGGER FOR INSERT
CREATE TRIGGER tr_InsertWorkReports ON WorkHours FOR INSERT
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, [Hours], Comments, 'Insert'
    FROM inserted
GO

--- TRIGGER FOR DELETE
CREATE TRIGGER tr_DeleteWorkReports ON WorkHours FOR DELETE
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, [Hours], Comments, 'Delete'
    FROM deleted
GO

--- TRIGGER FOR UPDATE
CREATE TRIGGER tr_UpdateWorkReports ON WorkHours FOR UPDATE
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, [Hours], Comments, 'InsertUpdate'
    FROM inserted

INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, [Hours], Comments, 'DeleteUpdate'
    FROM deleted
GO

--- TEST TRIGGERS
DELETE FROM WorkHoursLogs

INSERT INTO WorkHours(EmployeeId, OnDate, Task, [Hours])
VALUES (25, GETDATE(), 'TASK: 25', 25)

DELETE FROM WorkHours
WHERE EmployeeId = 25

UPDATE WorkHours
SET Comments = 'Updated'
WHERE EmployeeId = 2

--- 30. Start a database transaction, delete all employees from 
--- the 'Sales' department along with all dependent records from 
--- the pother tables. At the end rollback the transaction.

BEGIN TRAN

ALTER TABLE Departments
DROP CONSTRAINT FK_Departments_Employees
GO

DELETE e FROM Employees e
JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

--- ROLLBACK TRAN
--- COMMIT TRAN

--- 31. Start a database transaction and drop the table EmployeesProjects.
--- Now how you could restore back the lost table data?

BEGIN TRANSACTION

DROP TABLE EmployeesProjects

--- ROLLBACK TRANSACTION
--- COMMIT TRANSACTION

--- 32. Find how to use temporary tables in SQL Server. Using temporary 
--- tables backup all records from EmployeesProjects and restore them back 
--- after dropping and re-creating the table.

BEGIN TRANSACTION

SELECT * 
INTO #TempEmployeesProjects  --- Create new table
FROM EmployeesProjects

DROP TABLE EmployeesProjects

SELECT * 
INTO EmployeesProjects --- Create new table
FROM #TempEmployeesProjects;

DROP TABLE #TempEmployeesProjects

--- ROLLBACK TRANSACTION
--- COMMIT TRANSACTION