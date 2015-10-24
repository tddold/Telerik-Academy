--1.Create a table in SQL Server with 10 000 000 log entries (date + text).
--Search in the table by date range. Check the speed (without caching).

USE master
GO

CREATE DATABASE LogDB
GO

DROP TABLE Logs

USE LogDB

CREATE TABLE Logs(
	LogId int NOT NULL IDENTITY,
	LogDate datetime,
	LogText nvarchar(300),
	CONSTRAINT PK_Logs_LogId PRIMARY KEY (LogId)
)

DECLARE @RowCount int = 1000000
WHILE (@RowCount > 0)
BEGIN
	DECLARE @LogDate datetime = DATEADD(month, CONVERT(varbinary, newid()) % (50 * 12), getdate())
	DECLARE @LogText nvarchar(100) = 'Text ' + CONVERT(nvarchar(100), @RowCount) + ': ' +
			CONVERT(nvarchar(100), newid())
	INSERT INTO Logs(LogDate, LogText)
	VALUES (@LogDate, @LogText)
SET @RowCount = @RowCount - 1
END

SELECT COUNT(*) AS LogsCount FROM Logs

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

SELECT * FROM Logs
WHERE LogDate > '31-Dec-2013' and LogDate < '1-Jan-2015'


--2.Add an index to speed-up the search by date.
--Test the search speed (after cleaning the cache).

CREATE INDEX IDX_Logs_LogDate
ON Logs(LogDate)

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

SELECT * FROM Logs
WHERE LogDate > '31-Dec-2013' and LogDate < '1-Jan-2015'

DROP INDEX IDX_Logs_LogDate ON Logs

--3.Add a full text index for the text column.
--Try to search with and without the full-text index and compare the speed.

CREATE FULLTEXT CATALOG LogsFullTextCatalog
WITH ACCENT_SENSITIVITY = OFF

CREATE FULLTEXT INDEX ON Logs(LogText)
KEY INDEX PK_Logs_LogId
ON LogsFullTextCatalog
WITH CHANGE_TRACKING AUTO

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

SELECT * FROM Logs
WHERE CONTAINS(LogText, 'Text')

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

SELECT * FROM Logs
WHERE LogText LIKE '%Text%';

DROP FULLTEXT INDEX ON Logs
DROP FULLTEXT CATALOG LogsFullTextCatalog