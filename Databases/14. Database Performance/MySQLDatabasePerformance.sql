/*
4.Create the same table in MySQL and partition it by date (1990, 2000, 2010).
--Fill 1 000 000 log entries.
--Compare the searching speed in all partitions (random dates) to certain partition (e.g. year 1995).
*/

CREATE DATABASE LogDB;

USE LogDB;

CREATE TABLE Logs(
	LogId int NOT NULL AUTO_INCREMENT,
	LogDate datetime,
	LogText nvarchar(300),
	PRIMARY KEY (LogId, LogDate)
) PARTITION BY RANGE(YEAR(LogDate))(
	PARTITION p1 VALUES LESS THAN (1990),
	PARTITION p2 VALUES LESS THAN (2000),
    PARTITION p3 VALUES LESS THAN (2010),
	PARTITION p4 VALUES LESS THAN MAXVALUE
);

DROP TABLE Logs;

CALL FILL();

SELECT COUNT(*) FROM Logs PARTITION (p1);
SELECT COUNT(*) FROM Logs PARTITION (p2);
SELECT COUNT(*) FROM Logs PARTITION (p3);
SELECT COUNT(*) FROM Logs PARTITION (p4);

-- all partitions
SELECT * FROM Logs  WHERE YEAR(LogDate) = 1995;

-- partition with 1995 year
SELECT * FROM Logs PARTITION (p2) WHERE YEAR(LogDate) = 1995;
 
 
DROP PROCEDURE FILL

DELIMITER $$
CREATE PROCEDURE Fill()
BEGIN
DECLARE RowCount int DEFAULT 1000000;
DECLARE LogDate datetime;
DECLARE LogText nvarchar(100);
WHILE RowCount > 0 DO

    SET LogDate =  FROM_UNIXTIME(RAND() * 2147483647);
	SET LogText  = CONCAT('Text ', RowCount);
	INSERT INTO Logs(LogDate, LogText)
	VALUES (LogDate, LogText);
SET RowCount = RowCount - 1;
END WHILE;
END;
